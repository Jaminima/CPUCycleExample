Module Decoder

    Public Sub DecodeCIR()

        Form1.Label_Decoder.BackColor = Color.Green
        Form1.Refresh()

        Dim CurrentInstruction = CIRV.Value,
            Operand = SharedCode.CutString(CurrentInstruction, 5, Len(CurrentInstruction)),
            OpCode = SharedCode.CutString(CurrentInstruction, 1, 4)
        If OpCode = "0001" Then ' Add num in Accumulator too Operand
            Form1.Label_ACC.BackColor = Color.Green
            Form1.Label_ALU.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_ACC.BackColor = Color.OrangeRed
            Form1.Label_ALU.BackColor = Color.DeepSkyBlue
            Form1.Label_ACC_Binary.Text = SharedCode.BinaryV.BinaryMath(RamController.GetVal(Operand), Form1.Label_ACC_Binary.Text)
            Form1.Refresh()
        ElseIf OpCode = "0010" Then ' Replace Value in accumulator
            Form1.Label_ACC.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_ACC.BackColor = Color.OrangeRed
            Form1.Label_ACC_Binary.Text = RamController.GetVal(Operand)
            Form1.Refresh()
        End If

        SharedCode.Wait(Form1.Delay)
        Form1.Label_Decoder.BackColor = Color.OrangeRed
        Form1.Refresh()

    End Sub

End Module
