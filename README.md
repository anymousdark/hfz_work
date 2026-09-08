# HFZ Activator A12+ Premium - Reverse Engineering Analysis Repository

Um projeto completo de análise e engenharia reversa do **HFZ Activator A12+ Premium V1.2**, um aplicativo malicioso focado em exploração de dispositivos iOS. Este repositório contém ferramentas de desempacotamento, scripts de análise dinâmica e relatórios técnicos detalhados sobre a arquitetura, criptografia e vetores de ataque do malware.

## 📋 Índice

- [Visão Geral](#visão-geral)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Componentes Principais](#componentes-principais)
- [Scripts de Análise](#scripts-de-análise)
- [Ferramentas Necessárias](#ferramentas-necessárias)
- [Como Usar](#como-usar)
- [Detalhes Técnicos](#detalhes-técnicos)

---

## 🎯 Visão Geral

### O que é este projeto?

Este repositório é um espaço de trabalho documentado para análise forense e reverse engineering do malware **HFZ Activator A12+ Premium**. O projeto documenta:

- **Arquitetura de malware** com desempacotadores dinâmicos
- **Ofuscação e criptografia** (LZMA, AES, string encryption)
- **Engenharia reversa dinâmica** via memory dumping e decompilação
- **Análise de rede** para capturar comunicações maliciosas
- **Extração de payloads** de processos em memória

### Características do Malware

| Aspecto | Detalhes |
|--------|----------|
| **Nome** | HFZ Activator A12+ Premium V1.2 |
| **Tipo** | .NET WinForms + Native (libruntime.dll) |
| **Arquitetura** | x86 (32-bit) |
| **Tamanho** | ~8 MB (EXE) + 20 MB (DLL) |
| **Namespace** | GusActivatorPRO |
| **Licença** | GPLv3 (repositório de análise) |
| **Alvo** | iOS A12+ (iCloud bypass, SEP exploit, baseband unlock) |

---

## 📁 Estrutura do Projeto

```
hfz_work/
├── README.md                           # Este arquivo
├── LICENSE                             # GPLv3
├── .gitignore                          # Configuração Git
├── .gitattributes                      # Configuração de atributos
│
├── src/                                # Código-fonte das ferramentas de análise
│   ├── hfzdec/                         # ⭐ FERRAMENTA PRINCIPAL: Desempacotador HFZ
│   │   ├── Program.cs                  # Scanner de memória para PE headers (.NET)
│   │   └── hfzdec.csproj               # Configuração do projeto C#
│   │
│   ├── decompiler/                     # Descompilador de assemblies .NET
│   │   ├── Program.cs                  # ILSpy/SharpLab para decompilação em lote
│   │   └── decompiler.csproj           # Configuração do projeto
│   │
│   ├── clrmd_inspect/                  # Inspetor de runtime .NET via CLRMD
│   │   ├── Program.cs                  # Exploração de ClrMD 3.x APIs
│   │   └── clrmd_inspect.csproj        # Configuração do projeto
│   │
│   └── HFZ Activator A12+ Premium/     # (Referência, não incluído)
│       └── [binários maliciosos]
│
├── scripts/                            # Scripts de automação (PowerShell / Batch)
│   │
│   ├── [MEMORY DUMPING]
│   ├── dump-managed.ps1                # P/Invoke dbghelp.dll → MiniDumpWriteDump
│   ├── dump-memory.ps1                 # ProcDump wrapper (full memory dump)
│   ├── run-dump.ps1                    # Orquestrador: launch + wait + dump + log
│   ├── run_dump.bat                    # Variante batch simples
│   ├── run_dump2.bat                   # Variante com hfzdec.exe automático
│   │
│   ├── [NETWORK MONITORING]
│   ├── monitor_net.ps1                 # Get-NetTCPConnection loop + DNS resolve
│   ├── monitor_net.bat                 # Batch version
│   ├── run_netcap.bat                  # TCPView/tcpvcon64.exe capture → CSV
│   ├── run_capture.bat                 # tcpvcon com timeout
│   ├── run_capture2.bat                # PowerShell Get-NetTCPConnection loop
│   │
│   ├── [UTILITY]
│   └── run_strings.bat                 # Extract strings from libruntime.dll
│
├── analysis/                           # Relatórios e outputs de análise
│   │
│   ├── REPORT.md                       # ⭐ RELATÓRIO TÉCNICO COMPLETO
│   │   └── Contém: arquitetura, classes .NET, crypto, LZMA, anti-debug
│   │
│   ├── r2_analyze.py                   # Radare2 headless script
│   │   └── Análise de libruntime.dll desempacotado
│   │
│   ├── decompiled/                     # Output da descompilação
│   │   └── [Tipos .NET descompilados em C#]
│   │
│   ├── dnSpy-output/                   # Output do dnSpy (manual)
│   │   └── [Classes obfuscadas, métodos extern]
│   │
│   └── dumps/                          # Memory dumps (gerados em runtime)
│       ├── managed-dump-*.dmp          # MiniDump da CLI
│       ├── HFZ_*.dmp                   # ProcDump full memory
│       └── [Carregáveis em dnSpy]
```

---

## 🔧 Componentes Principais

### 1. **hfzdec (HFZ Decompressor)**
**Localização:** `src/hfzdec/Program.cs`

Ferramenta core que realiza dumping em tempo de execução:

```csharp
// Funcionalidade:
- Inicia o HFZ Activator
- Aguarda 35 segundos (tempo de desempacotamento)
- Escaneia memória por PE headers (MZ signature)
- Identifica assemblies .NET (CLR headers)
- Extrai métodos com IL decrypado
```

**Uso:**
```bash
dotnet build src/hfzdec
bin/hfzdec.exe
# Outputs: extracted/* com assemblies descriptografadas
```

**O que encontra:**
- GClass0, GClass1, GClass12 (métodos desencriptados)
- LZMA decompressor (GClass13)
- Strings decriptadas em memória

---

### 2. **Decompiler (ICSharpCode.Decompiler)**
**Localização:** `src/decompiler/Program.cs`

Descompilador em lote de assemblies .NET:

```csharp
// Workflow:
- Recebe diretório com *.exe / *.dll
- Para cada tipo: CSharpDecompiler.DecompileTypeAsString()
- Salva como C# em análise/decompiled/
```

**Uso:**
```bash
dotnet run --project src/decompiler -- C:\path\extracted C:\output
# Outputs: C#\*.cs files com código completo
```

**Gera:**
- Classes obfuscadas com corpos de método
- Estruturas de dados (PE structs, LZMA range decoder)
- Identificação de classes helper (GClass4-GClass13)

---

### 3. **ClrMD Inspect (Runtime Debugging)**
**Localização:** `src/clrmd_inspect/Program.cs`

Inspetor de tipos em runtime via Microsoft.Diagnostics.Runtime:

```csharp
// Propósito:
- Query ClrMD 3.x para API reference
- Usado em desenvolvimento de ferramentas de dump
- Não crítico para análise final
```

**Nota:** Referência rápida, não essencial para análise completa.

---

## 📜 Scripts de Análise

### Dumping de Memória

#### `dump-managed.ps1` | `dump-memory.ps1`
```powershell
# Objetivo: Capturar snapshot do processo HFZ em memória

Opção 1 - MiniDumpWriteDump (nativo)
  → Menos intrusivo, cria .dmp via dbghelp.dll
  → Compatível com dnSpy
  
Opção 2 - ProcDump (Sysinternals)
  → Full memory dump (-ma flag)
  → Maior arquivo, mais dados
  → Requer ProcDump.exe em C:\tools\procdump\
```

**Fluxo:**
1. Inicia HFZ.exe
2. Aguarda 15-35 segundos (desempacotamento)
3. Captura dump do processo
4. Salva em `analysis/dumps/HFZ_TIMESTAMP.dmp`

**Carregamento em dnSpy:**
```
File → Open → [dump.dmp] → Module Explorer
```

---

#### `run-dump.ps1` (Orquestrador Principal)
```powershell
# Fluxo completo com privilégios admin:
1. Requer UAC elevation
2. Valida hfzdec.exe, procdump.exe
3. Inicia HFZ
4. Executa dump
5. Registra tamanho e caminho

# Use este para automatizar a análise
```

---

### Monitoramento de Rede

#### `monitor_net.ps1` | `monitor_net.bat`
```powershell
# Objetivo: Capturar conexões TCP em tempo real

Loop de monitoramento:
  - Get-NetTCPConnection -OwningProcess [PID]
  - Detecta conexões NOVAS apenas
  - Resolve IP → hostname via DNS
  - Salva em analysis/connections_TIMESTAMP.txt

Exemplo de output:
  127.0.0.1:2772 → 127.0.0.1:27015  (idevicetunnel)
  192.168.1.100:54321 → gs.apple.com:443  (expected com device iOS)
```

---

#### `run_netcap.bat` (TCPView Automated)
```batch
# Objetivo: Capture CSV com tcpview/tcpvcon
- Inicia tcpvcon64.exe em background
- Launches HFZ
- Aguarda 40 segundos
- Mata tcpvcon, salva CSV

Output: analysis/connections.csv (Excel-friendly)
```

---

### Extração de Strings

#### `run_strings.bat`
```batch
# Objetivo: Extrair strings decriptadas de libruntime.dll
- Script PowerShell helper
- Procura encrypted segments (.dRz)
- Executa desencriptação
- Salva strings.txt

Strings esperadas:
  - PFXImportCertStore (cert handling)
  - NCryptVerifySignature (crypto)
  - WS2_32.dll (sockets)
  - "mrUSB", "tss;de" (USB/signing)
```

---

## 🛠️ Ferramentas Necessárias

### Instalação

| Ferramenta | Propósito | Local |
|-----------|----------|-------|
| **dnSpy** | Decompilador .NET (manual) | C:\tools\dnSpy\ |
| **ProcDump** | Memory dumping | C:\tools\procdump\ |
| **TCPView / tcpvcon** | Network capture | C:\tools\tcpview\ |
| **Radare2** | Análise de native code | PATH ou scripts/analysis/ |
| **Python 3** | r2_analyze.py | (requer r2pipe module) |
| **.NET 6/8 SDK** | Build das ferramentas | C:\Program Files\dotnet\ |

### Download

```powershell
# dnSpy (manual)
# https://github.com/dnSpy/dnSpy/releases

# ProcDump (Sysinternals)
# https://learn.microsoft.com/en-us/sysinternals/downloads/procdump

# TCPView (Sysinternals)
# https://learn.microsoft.com/en-us/sysinternals/downloads/tcpview

# Radare2
# https://rada.re/n/download.html
```

---

## 🚀 Como Usar

### Quick Start - Análise Completa

```bash
# 1. Clone o repositório
git clone https://github.com/anymousdark/hfz_work.git
cd hfz_work

# 2. Compile as ferramentas
dotnet build src/hfzdec
dotnet build src/decompiler

# 3. Coloque o HFZ.exe em local conhecido
# (Atualizar paths em scripts se necessário)

# 4. Execute o dump automatizado
powershell -ExecutionPolicy Bypass -File scripts/run-dump.ps1

# 5. Descompile os assemblies extraídos
dotnet run --project src/decompiler -- `
  C:\path\extracted `
  C:\path\analysis\decompiled

# 6. Abra no dnSpy
# File → Open → analysis/dumps/HFZ_*.dmp
```

### Análise Gradual

#### Fase 1: Memory Dump
```powershell
scripts/dump-memory.ps1
# Aguarde ~40 segundos
# Resultado: analysis/dumps/HFZ_TIMESTAMP.dmp (300-500 MB)
```

#### Fase 2: Descompilação
```bash
dotnet run --project src/decompiler -- C:\dumped C:\decompiled
# Resultado: C# sources com métodos descriptografados
```

#### Fase 3: Análise de Rede
```powershell
scripts/monitor_net.ps1 -WaitSeconds 120
# Com device iOS conectado:
# Resultado: Endpoints, DNS, caminho de attack
```

#### Fase 4: Análise de Strings
```batch
scripts/run_strings.bat
# Resultado: analysis/strings.txt com credenciais, URLs, etc.
```

---

## 📊 Detalhes Técnicos

### Arquitetura de Malware

```
┌─────────────────────────────────────────────────────┐
│  HFZ Activator.exe (8 MB, x86 .NET)                │
│  GusActivatorPRO namespace                         │
│                                                     │
│  GForm0 (UI - Guna2 WinForms)                      │
│    ↓ chama métodos extern                          │
│  GClass0.A2290D0F (WebClient customizado)         │
│    ↓ configura proxy/certs                        │
│  GClass2.smethod_0 (InternetSetOption)            │
│    ↓ comunica com                                  │
│  libruntime.dll (20 MB, native x86)                │
│                                                     │
│  [Exports: SetCallback, Action]                    │
│  [.dRz section: 19.7 MB encrypted payload]        │
│  [Unpacker: decrypts → LZMA decompresses → exec]  │
└─────────────────────────────────────────────────────┘
```

### Obfuscação & Criptografia

| Camada | Técnica | Detalhes |
|--------|---------|----------|
| **String** | AES-like (GClass4) | uint[] round keys, 4x4 state |
| **Payload** | LZMA (GClass13) | LC=3, window dynamic, entropy decode |
| **Native** | Custom packer | .dRz (encrypted) → .text (unpacked) |
| **Anti-Debug** | NtQueryVirtualMemory | Valida MEM_EXECUTE flags |

### Classes .NET (Decompiladas)

| Classe | Tipo | Função |
|--------|------|--------|
| **GClass4** | Crypto engine | AES-like rounds |
| **GClass5** | Ring buffer | LZMA streaming |
| **GClass9** | CRC32 | Obfuscado, controle de fluxo |
| **GClass13** | LZMA decompressor | Completo, 493 linhas |
| **CF9A9A86** | Range decoder | Entropy (LZMA) |
| **FDAAAF93** | Bit tree decoder | Probabilidades reversa/forward |
| **B7316602** | PE parser | NtQueryVirtualMemory, anti-debug |

### Network (Expected)

Com device iOS conectado:

```
HFZ (127.0.0.1:random)
  ↓
gs.apple.com:443 (MDM/Activation)
  ↓
gs-hfz-api.com:443 (License validation)
  ↓
payload-download.hfz.com:443 (Exploit binary)
```

**Sem device:** Apenas `127.0.0.1:2772 → 127.0.0.1:27015` (idevicetunnel local).

---

## 📈 Fluxo de Análise Recomendado

```
┌─ Estaticamente ─────────────────────────┐
│ 1. Strings (run_strings.bat)            │
│ 2. PE structure (r2_analyze.py)         │
│ 3. Imports (LE view em HxD)             │
└─────────────────────────────────────────┘
           ↓
┌─ Dinamicamente ─────────────────────────┐
│ 1. Memory dump (dump-memory.ps1)        │
│ 2. Carrega no dnSpy                     │
│ 3. Inspeta métodos extern, GClass*     │
│ 4. Trace execução (breakpoints)        │
└─────────────────────────────────────────┘
           ↓
┌─ Networking ────────────────────────────┐
│ 1. Monitor com Fiddler/mitmproxy       │
│ 2. Capture com monitor_net.ps1         │
│ 3. Analisa endpoints em REPORT.md      │
└─────────────────────────────────────────┘
           ↓
┌─ Resultado ─────────────────────────────┐
│ → analysis/REPORT.md (completo)         │
│ → Vulnerabilidades iOS mapeadas         │
│ → Exploits documentados                 │
└─────────────────────────────────────────┘
```

---

## 📝 Relatório Técnico

Veja `analysis/REPORT.md` para:

- **Arquitetura completa** (8 seções)
- **Mapa de classes .NET** (30+ classes)
- **Algoritmo LZMA** (decodificação completa)
- **Anti-debug** (NtQueryVirtualMemory breakdown)
- **Estrutura PE de libruntime.dll** (seções, entry point)
- **Exploits hipotéticos** (A12+, SEP, TSS, checkra1n)
- **Next steps** para análise com device iOS

---

## 🔒 Privacidade & Segurança

⚠️ **AVISO IMPORTANTE:**

Este repositório contém análise de **malware ativo**. Use apenas:

✅ **Em ambiente isolado** (VM, rede segregada)  
✅ **Para fins de pesquisa/educação**  
✅ **Com autorização das vítimas potenciais**  
❌ **Nunca execute binários em produção**  
❌ **Nunca distribua exploits**

Todos os arquivos incluem:
- Caminho "Griffith" sanitizado (referência original removida)
- Binários maliciosos **não incluídos** (substitua localmente)
- Apenas análise técnica & ferramentas de extração

---

## 🎓 Aprendizado & Contribuições

Se usar este projeto:

1. **Cite este repositório** em relatórios
2. **Documente novos achados** em issues
3. **Contribua scripts** via PR
4. **Reporte vulnerabilidades** responsavelmente a Apple

---

## 📞 Suporte & Feedback

- **Issues:** Reporte erros / sugestões de ferramentas
- **Discussions:** Perguntas técnicas
- **Security:** Vulnerabilidades → responsibly

---

## 📄 Licença

**GPLv3** - Este trabalho de análise é de código aberto para fins educacionais.

```
Copyright (C) 2026 - Analysis Repository
This program is free software licensed under GPLv3
```

---

## 🔗 Referências

- [dnSpy GitHub](https://github.com/dnSpy/dnSpy)
- [Microsoft.Diagnostics.Runtime](https://github.com/microsoft/clrmd)
- [ICSharpCode.Decompiler](https://github.com/icsharpcode/ILSpy)
- [Radare2 Docs](https://book.rada.re/)
- [Sysinternals Suite](https://learn.microsoft.com/en-us/sysinternals/)

---

**Última atualização:** 2026-06-15  
**Versão:** 1.0 (Análise Completa)  
**Status:** 🟢 Ativo

