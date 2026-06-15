// Quick inspect: what types/methods does ClrMD 3.x have?
using System.Reflection;
var asm = typeof(Microsoft.Diagnostics.Runtime.DataTarget).Assembly;
foreach (var t in asm.GetExportedTypes().Where(t => t.IsPublic))
{
    if (t.Namespace != "Microsoft.Diagnostics.Runtime") continue;
    var methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
    var props = t.GetProperties();
    if (!methods.Any() && !props.Any()) continue;
    Console.WriteLine($"// {t.Name}");
    foreach (var p in props)
        Console.WriteLine($"  prop {p.PropertyType.Name} {p.Name}");
    foreach (var m in methods)
    {
        if (m.IsSpecialName) continue;
        var parms = string.Join(", ", m.GetParameters().Select(p => p.ParameterType.Name));
        Console.WriteLine($"  {m.ReturnType.Name} {m.Name}({parms})");
    }
    Console.WriteLine();
}
