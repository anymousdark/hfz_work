#!/usr/bin/env python3
"""
r2_analyze.py - Radare2 headless script to analyze decrypted libruntime.dll
Usage after memory dump: r2 -q -i r2_analyze.py -A libruntime_decrypted.dll
"""

import r2pipe
import sys

def analyze(path):
    r2 = r2pipe.open(path, flags=['-e', 'bin.relocs.apply=true', '-e', 'bin.cache=true'])
    
    # Analyze all
    r2.cmd('aaaa')
    
    # Get functions
    functions = r2.cmd('afl')
    
    # Find crypto-related functions
    crypto_funcs = []
    for line in functions.strip().split('\n'):
        if line:
            parts = line.split()
            if len(parts) >= 3:
                addr = parts[0]
                name = parts[-1] if len(parts) > 3 else ''
                # Look for patterns
                if any(kw in name.lower() for kw in ['crypt', 'aes', 'decrypt', 'encrypt', 'key', 
                                                       'round', 'sbox', 'tea', 'xor', 'cipher']):
                    crypto_funcs.append((addr, name))
    
    print(f'Functions found: {len(functions)}')
    print(f'Crypto-related: {len(crypto_funcs)}')
    for addr, name in crypto_funcs:
        print(f'  {addr}: {name}')
    
    # Look for XREFs to key constants
    print('\n=== Looking for round constants / SBOX ===')
    r2.cmd('/x 63-7c-77-7b')  # AES SBOX start
    r2.cmd('/x 01-02-04-08')  # Rcon start
    
    # Disassemble SetCallback and Action exports
    print('\n=== SetCallback ===')
    print(r2.cmd('s sym.SetCallback; pd 50'))
    
    print('\n=== Action ===')
    print(r2.cmd('s sym.Action; pd 50'))
    
    r2.quit()

if __name__ == '__main__':
    analyze(sys.argv[1])
