# CPU Fetch-Execute Cycle Demonstration

### Cycle Steps ###
1. Copy Value from Program Counter -> Memory Address Register
2. Increment Program Counter by 1
3. Copy Address content into the Memory Buffer Register
4. Copy MBR content into Current Instruction Register
5. Decode instruction by:
    * Split content into Opcode and Operand
    * Perform Opcode</br>
    __or__
    * Set Memory Address Register to Operand
    * Copy Address content into Memmory Buffer Register
    * Perform Opcode on MBR and Acumulator</br>
    __or__
    * Set Memory Address register to Operand
    * Copy Accumulator content to Memory Buffer Register
    * Move MBR content into targeted Address
    
### Download .EXE ###
<a href="https://github.com/Jaminima/CPUCycleExample/blob/master/CPUCycleExample.exe?raw=true">Download From Github</a>
