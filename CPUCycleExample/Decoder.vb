Module Decoder

    Public Sub DecodeCIR()

        Form1.Label_Decoder.BackColor = Color.Green
        Form1.Refresh()

        Dim CurrentInstruction = CIRV.Value,
            Operand = SharedCode.CutString(CurrentInstruction, 5, Len(CurrentInstruction)),
            OpCode = SharedCode.CutString(CurrentInstruction, 1, 4)

        If OpCode = "0001" Then ' Add num in Accumulator to Operand
#Region "Animation"
            'MAR
            Form1.Label_MAR.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MAR_Binary.Text = Operand
            Form1.Refresh()

            'RAM
            Form1.Panel_Bus_Address.BackColor = Color.Green
            Form1.Panel_Bus_Data.BackColor = Color.Green
            Form1.Label_MBR.BackColor = Color.Green
            Dim AddressContent = RamController.GetVal(Operand)
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Panel_Bus_Address.BackColor = Color.Gray
            Form1.Panel_Bus_Data.BackColor = Color.Gray
            Form1.Label_MAR.BackColor = Color.OrangeRed
            Form1.Label_MBR_Binary.Text = AddressContent
            Form1.Refresh()

            'ALU ACC
            Form1.Label_ACC.BackColor = Color.Green
            Form1.Label_ALU.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MBR.BackColor = Color.OrangeRed
            Form1.Label_ACC.BackColor = Color.OrangeRed
            Form1.Label_ALU.BackColor = Color.DeepSkyBlue
#End Region
            Form1.Label_ACC_Binary.Text = SharedCode.BinaryV.BinaryMath(AddressContent, Form1.Label_ACC_Binary.Text, "+")
            Form1.Refresh()

        ElseIf OpCode = "0010" Then ' Subtract num in Operand from Accumulator
#Region "Animation"
            'MAR
            Form1.Label_MAR.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MAR_Binary.Text = Operand
            Form1.Refresh()

            'RAM
            Form1.Panel_Bus_Address.BackColor = Color.Green
            Form1.Panel_Bus_Data.BackColor = Color.Green
            Form1.Label_MBR.BackColor = Color.Green
            Dim AddressContent = RamController.GetVal(Operand)
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Panel_Bus_Address.BackColor = Color.Gray
            Form1.Panel_Bus_Data.BackColor = Color.Gray
            Form1.Label_MAR.BackColor = Color.OrangeRed
            Form1.Label_MBR_Binary.Text = AddressContent
            Form1.Refresh()

            'ALU ACC
            Form1.Label_ACC.BackColor = Color.Green
            Form1.Label_ALU.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MBR.BackColor = Color.OrangeRed
            Form1.Label_ACC.BackColor = Color.OrangeRed
            Form1.Label_ALU.BackColor = Color.DeepSkyBlue
#End Region
            Form1.Label_ACC_Binary.Text = SharedCode.BinaryV.BinaryMath(Form1.Label_ACC_Binary.Text, AddressContent, "-")
            Form1.Refresh()

        ElseIf OpCode = "0100" Then ' Replace Value in accumulator
#Region "Animation"
            'MAR
            Form1.Label_MAR.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MAR_Binary.Text = Operand
            Form1.Refresh()

            'RAM
            Form1.Panel_Bus_Address.BackColor = Color.Green
            Form1.Panel_Bus_Data.BackColor = Color.Green
            Form1.Label_MBR.BackColor = Color.Green
            Dim AddressContent = RamController.GetVal(Operand)
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Panel_Bus_Address.BackColor = Color.Gray
            Form1.Panel_Bus_Data.BackColor = Color.Gray
            Form1.Label_MAR.BackColor = Color.OrangeRed
            Form1.Label_MBR_Binary.Text = AddressContent
            Form1.Refresh()
            'ACC
            Form1.Label_ACC.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MBR.BackColor = Color.OrangeRed
            Form1.Label_ACC.BackColor = Color.OrangeRed
#End Region
            Form1.Label_ACC_Binary.Text = AddressContent
            Form1.Refresh()

        ElseIf OpCode = "0101" Then ' Store Accumulator into ram and clear
#Region "Animation"
            'MAR
            Form1.Label_MAR.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MAR_Binary.Text = Operand
            Form1.Refresh()

            'ACC
            Form1.Label_ACC.BackColor = Color.Green
            Form1.Label_MBR.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_ACC.BackColor = Color.OrangeRed
            Form1.Label_MBR_Binary.Text = Form1.Label_ACC_Binary.Text

            'RAM
            Form1.Panel_Bus_Address.BackColor = Color.Green
            Form1.Panel_Bus_Data.BackColor = Color.Green
            Form1.Panel_Bus_Control.BackColor = Color.Green
            Form1.Label_MBR.BackColor = Color.Green
            RamController.WriteVal(Operand, Form1.Label_MBR_Binary.Text)
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MAR.BackColor = Color.OrangeRed
            Form1.Panel_Bus_Address.BackColor = Color.Gray
            Form1.Panel_Bus_Data.BackColor = Color.Gray
            Form1.Panel_Bus_Control.BackColor = Color.Gray
            Form1.Label_MBR.BackColor = Color.OrangeRed

#End Region


        ElseIf OpCode = "0000" Then ' Reset Program Counter
#Region "Animation"
            Form1.Label_PC.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_PC.BackColor = Color.OrangeRed
#End Region
            Form1.Label_PC_Binary.Text = "0000"
            PCV.Counter = "0000"
            Form1.Refresh()

        End If

        SharedCode.Wait(Form1.Delay)
        Form1.Label_Decoder.BackColor = Color.OrangeRed
        Form1.Refresh()

    End Sub

End Module
