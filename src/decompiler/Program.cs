using System;
using System.IO;
using System.Linq;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using System.Text;

var targetDir = args[0];
var outputDir = args[1];

Directory.CreateDirectory(outputDir);
var resolver = new UniversalAssemblyResolver(targetDir, false, null);

foreach (var asmFile in Directory.GetFiles(targetDir, "*.exe").Concat(Directory.GetFiles(targetDir, "*.dll")))
{
    var name = Path.GetFileNameWithoutExtension(asmFile);
    var asmOutputDir = Path.Combine(outputDir, name);
    Directory.CreateDirectory(asmOutputDir);

    Console.WriteLine($"\n=== Decompiling: {asmFile} ===");
    try
    {
        var decompiler = new CSharpDecompiler(asmFile, resolver, new DecompilerSettings
        {
            ThrowOnAssemblyResolveErrors = false,
        });

        var types = decompiler.TypeSystem.MainModule.TypeDefinitions;
        foreach (var type in types)
        {
            var fullName = type.FullName.Replace('/', '.');
            Console.WriteLine($"  Type: {fullName}");
            try
            {
                var code = decompiler.DecompileTypeAsString(type.FullTypeName);
                var safeName = fullName.Replace('<', '_').Replace('>', '_').Replace('+', '.').Replace('\n', '_').Replace('\r', '_');
                if (safeName.Length > 200) safeName = safeName[..200];
                var filePath = Path.Combine(asmOutputDir, safeName + ".cs");
                File.WriteAllText(filePath, code, Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"    Error: {ex.Message}");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"  FAILED: {ex.Message}");
    }
}

Console.WriteLine("\nDone decompiling all assemblies.");
