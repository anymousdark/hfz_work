# HFZ Activator A12+ Premium V1.2 - Complete Analysis Report

## 1. Architecture Overview

```
┌─────────────────────────────────────────────────────────────┐
│  HFZ Activator A12+ Premium.exe (8MB .NET / x86)           │
│  Namespace: GusActivatorPRO                                 │
│                                                             │
│  ┌─────────────────────────────────────────────────────┐   │
│  │ GForm0 (Main UI) - Guna2 WinForms                   │   │
│  │ Methods: all extern (provided by blob at runtime)   │   │
│  │ Controls: buttons, labels, checkboxes, panels       │   │
│  └──────────────────────┬──────────────────────────────┘   │
│                         │                                   │
│  ┌──────────────────────▼──────────────────────────────┐   │
│  │ GClass0.A2290D0F : WebClient (custom X509 cert)     │   │
│  │ GClass1 - String decryption (extern)                 │   │
│  │ GClass2 - InternetSetOption (wininet.dll proxy)      │   │
│  │ GClass3 - Query string parser → Dictionary           │   │
│  └──────────────────────┬──────────────────────────────┘   │
│                         │                                   │
│  ┌──────────────────────▼──────────────────────────────┐   │
│  │ BAA7FFAC (bridge to libruntime.dll)                  │   │
│  │  [DllImport] SetCallback(int, IntPtr) → bool        │   │
│  │  [DllImport] Action(int, int, int) → bool           │   │
│  └──────────────────────┬──────────────────────────────┘   │
└─────────────────────────┼───────────────────────────────────┘
                          │
┌─────────────────────────▼──────────────────────────────────┐
│  utils/libruntime.dll (20MB native, x86)                    │
│  ┌──────────────────────────────────────────────────────┐   │
│  │ ENTRY POINT: RVA 0x00557000 (empty .rdata section)  │   │
│  │ Sections: .text/.rdata/.data/.pdata/.MG| (rawSize=0)│   │
│  │                                                    │   │
│  │ .Su. (304B) → Export table (SetCallback, Action)   │   │
│  │ .dRz (20MB) → CRYPTED payload (high entropy)       │   │
│  │                                                    │   │
│  │ UNPACKER: Custom runtime decrypts .dRz → .text     │   │
│  │           Then jumps to real entry point            │   │
│  └──────────────────────────────────────────────────────┘   │
│  Decrypted strings found:                                   │
│  - PFXImportCertStore (certificate import)                  │
│  - NCryptVerifySignature (CNG signature verify)             │
│  - BCryptVerifySignature (BCrypt signature verify)          │
│  - WS2_32.dll (Winsock raw sockets)                        │
│  - IPHLPAPI.DLL (network interface enumeration)            │
│  - CRYPT32.dll / bcrypt.dll / ncrypt.dll (crypto)          │
│  - "mrUSB" (USB device access)                             │
│  - "tss;de" (TSS/Tatsu signing service)                    │
│  Dependencies:                                              │
│  - libimobiledevice-1.0.dll (iOS device communication)      │
│  - libusbmuxd-2.0.dll (USB multiplexing)                   │
│  - libplist-2.0.dll (Apple plist parsing)                  │
│  - libtatsu.dll (Tatsu signing)                             │
│  - libcrypto-3.dll / libssl-3.dll (OpenSSL)                │
│  - idevicetunnel.exe (USB tunnel daemon, port 27015)       │
│  - MobileDevice/*.dll (Apple framework DLLs)               │
└────────────────────────────────────────────────────────────┘
```

## 2. Decompiled Class Map (.NET C#)

### Core Engine (all extern - provided by libruntime at runtime)
| Class | Methods | Extern |
|-------|---------|--------|
| GClass0 | smethod_0(string, dict) → byte[] | YES |
| GClass0.A2290D0F | GetWebRequest() override | YES |
| GClass1 | smethod_0, E48431BD (string decrypt) | YES |
| GClass2 | smethod_0-5, InternetSetOption | YES |
| GClass3 | smethod_0(string) → Dictionary | YES |
| GClass12 | method_1344(object, int) → object | YES |

### Decompiled Internals (have actual method bodies)
| Class | Size | Purpose |
|-------|------|---------|
| GClass4 | 46 lines | AES-like crypto engine (uint[] round keys) |
| GClass5 | 127 lines | Ring buffer (LZMA streaming buffer) |
| GClass9 | 151 lines | CRC32 with control flow obfuscation |
| GClass13 | 493 lines | **LZMA decompressor** (complete) |
| GClass10 | 15 lines | Second init: calls GClass12(4643335) |
| B7316602 | 520 lines | PE parser + NtQueryVirtualMemory anti-debug |

### Helper Classes (all with method bodies)
| Class | Type | Purpose |
|-------|------|---------|
| CF9A9A86 | class | **Range decoder** (LZMA entropy decoder) |
| D13BA20B | struct | **Bit decoder** (single probability, 1024 initial) |
| FDAAAF93 | struct | **Bit tree decoder** (reverse + forward) |
| BE32229B | static | PE structs (IMAGE_SECTION_HEADER, etc.) |
| GClass6 | class | AssemblyResolve handler (extends C49DAC3A) |
| GClass7 | class | Native memory buffer (read/write byte/uint/ulong) |
| GClass8 | class | Dictionary<uint,uint> cache |
| GClass11 | static | AD385214 delegate: cdecl(int, int[]) callback |

### UI Layer (Form1)
| Class | Lines | Purpose |
|-------|-------|---------|
| GForm0 | 833 | Main form, Guna2 controls, 55+ extern methods |
| GForm0.Delegate0 | 1 | unmanaged callback (int,int,int,string,string) |
| Class1-6 | nested | Compiler-generated async state machines |

### Obfuscation System
| Component | Key | Description |
|-----------|-----|-------------|
| GClass12 | 5123662 | Universal decryptor called from Module.cctor |
| GClass10 | 4643335 | Second decrypt call (different key) |
| F11CA1A4 | 7625771 | DebuggerDisplay string decrypt |
| GClass4 | - | AES-like: uint[?] round keys, 4x4 state |
| GClass13 | - | LZMA decompress after decrypt |
| GClass6 | - | Assembly.Load from decrypted buffer |
| B7316602 | - | NtQueryVirtualMemory anti-tamper check |

## 3. Network Architecture

```
HFZ App (GClass0.A2290D0F : WebClient)
  ├── Custom X509Certificate2 (self-signed/mitm cert)
  └── GetWebRequest override (custom timeout/headers)
  
GClass2
  └── InternetSetOption(wininet.dll) → proxy config
  
libruntime.dll (native)
  ├── WS2_32.dll → raw TCP/UDP sockets
  ├── IPHLPAPI.DLL → GetNetworkParams, GetAddrInfoW
  ├── PFXImportCertStore → cert import for HTTPS
  └── NCryptVerifySignature / BCryptVerifySignature

Observed connection (with no iOS device):
  127.0.0.1:2772 → 127.0.0.1:27015 (idevicetunnel.exe)
  
Expected connections (with iOS device):
  → gs.apple.com (activation servers)
  → API servers (license validation, exploit download)
```

## 4. Crypto Engine (GClass4 - AES-like)

```
Fields:
  uint[] uint_0       → round keys
  uint[] F886B79F     → expanded key schedule
  byte[] AF8DC382     → 16-byte state matrix
  long F9881D0D       → counter/iteration
  int int_0           → rounds

Methods:
  CBA6E1A6(uint[], int, int) → load key
  AFA7B615(uint)             → single uint operation
  FB33B787(byte[], int, int) → process data block
  AE008F17() → byte[]        → get result
```

## 5. LZMA Decompressor (GClass13 - complete)

```
Configuration:
  Literal context bits:   12 (LC=3, LP=0)
  Position bits:         4  
  Distance bits:         6 (FDAAAF93)
  Window size:           variable (1U << level)
  Buffer min:            4096 bytes
  
Decoding Pipeline:
  CF9A9A86 (RangeDecoder: uint range + code)
    → D13BA20B (BitDecoder: probability 1024, adapt shift 5)
      → FDAAAF93 (BitTreeDecoder: reverse + forward, N bits)
        → LZMA matches/distances/literals
          → GClass5 (RingBuffer → output Stream)

Header format (5 bytes):
  byte[0]: mode = (mode % 9) + ((mode / 9 % 5) * 5) + ...
  byte[1-4]: uint32 uncompressed size (little-endian)
```

## 6. Anti-Debug (B7316602)

```
Technique: NtQueryVirtualMemory
  → Checks MEMORY_BASIC_INFORMATION.State/MEM_EXECUTE
  → Ensures code is running from legitimately executable memory

Implementation:
  B7316602.Struct20 = MEMORY_BASIC_INFORMATION (32-bit)
  B7316602.Struct21 = MEMORY_BASIC_INFORMATION (64-bit)
  → Allocates memory, reads protection flags
  → Validates MEM_EXECUTE (0x1000000) flag
  
Also:
  - Parses PE headers/relocations (BE32229B structs)
  - smethod_0(uint) = RVA → file offset conversion
  - smethod_1() = module base address (via fixed pointer)
```

## 7. PE Structure of libruntime.dll

```
File size: 20,648,448 bytes (19.7 MB)
Arch: x86 (PE32)
Subsystem: Windows DLL

Sections:
  .text     RVA=0x1000   VSize=5.3MB  RawSize=0  (runtime fill)
  .rdata    RVA=0x557000 VSize=3.6MB  RawSize=0  (runtime fill)
  .data     RVA=0x8F4000 VSize=1.6MB  RawSize=0  (runtime fill)
  .pdata    RVA=0xA93000 VSize=396KB  RawSize=0  (runtime fill)
  .MG|      RVA=0xAF7000 VSize=8.8MB  RawSize=0  (runtime fill)
  .Su.      RVA=0x13C5000 VSize=304B  RawSize=512B (export table)
  .dRz      RVA=0x13C6000 VSize=19.7MB RawSize=19.7MB (ENCRYPTED)
  .rsrc     RVA=0x2776000 VSize=812B  RawSize=1KB
  .reloc    RVA=0x2777000 VSize=2KB   RawSize=2.5KB

Entry Point: RVA 0x00557000 (in .rdata, rawSize=0 → must be unpacked)
Exports: SetCallback (ordinal 1), Action (ordinal 2) at RVA 0x13C5000 (.Su.)

Custom unpacker design:
  1. DLL mapped by Windows Loader (all sections reserved in virtual memory)
  2. Unpacker stub (likely in .dRz entry or TLS callback):
     a. Reads encrypted payload from .dRz section
     b. Decrypts using embedded key (tea? aes? xor?)
     c. Decompresses (LZMA from GClass13?) 
     d. Writes decompressed code to .text/.rdata/.data/.pdata/.MG|
     e. Resolves IAT
     f. Jumps to real entry point (RVA 0x557000)
```

## 8. Network Observations

### With no iOS device connected:
```
Local: 127.0.0.1:2772 → Remote: 127.0.0.1:27015 (idevicetunnel)
State: Established
```

### Expected with iOS device:
- Connection to Apple activation servers (gs.apple.com)
- HFZ license validation server (if any)
- Exploit payload download

## 9. What Remains (Requires iOS Device)

1. **Run HFZ with iPhone/iPad connected**
2. **TCPView** → capture endpoint URLs:
   - gs.apple.com endpoints
   - License/API server
   - Exploit download URLs
3. **Fiddler/mitmproxy** → intercept HTTPS traffic
   - GClass0 uses X509Certificate2 (custom cert validation)
   - Need to install Fiddler root cert or patch validation
4. **Memory dump** (Task Manager → Create dump file) → 32-bit .NET dump
5. **Load dump in dnSpy** → find decrypted method bodies:
   - GClass0.smethod_0 → actual HTTP request URLs
   - GForm0 methods → exploit UI logic
   - GClass1 → string decryption keys
6. **Decrypt .dRz section** → reverse custom packer in libruntime.dll
7. **Document specific exploits** for Apple security report

## 10. Exploit Categories (Hypothesized)

Based on tool name "HFZ Activator A12+ Premium":
- **A12+** = iPhone XS/XR and newer (A12-A18 chips)
- **Activation Bypass** = iCloud/activation lock removal
- **SEP bypass** = Secure Enclave Processor manipulation
- **Baseband unlock** = carrier unlock via baseband patching
- **TSS signing** = Downgrade/restore with custom tickets
- **Checkra1n/palera1n** = checkm8 bootrom exploit integration

---
Generated: 2026-06-15
