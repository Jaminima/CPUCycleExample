Module RegisterController

    Public PCV As New PC,
        MARV As New MAR,
        MBRV As New MBR,
        CIRV As New CIR

    Class PC

        Public Counter As String = "0000"

        Sub Iterate()
            Counter = SharedCode.BinaryV.MakeLength(SharedCode.BinaryV.BinaryMath(Counter, "0001", "+"), 4)
            Form1.Label_PC.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_PC.BackColor = Color.OrangeRed
            Form1.Label_PC_Binary.Text = Counter
            If Len(Counter) > 4 Then
                MessageBox.Show("Program Counter Overflowed", "OVERFLOW DETECTED", MessageBoxButtons.OK)
                Form1.Label_PC.BackColor = Color.Red
                Form1.BtnCycle.Hide()
            End If
        End Sub

    End Class

    Class MAR

        Public Value As String = "0000"

        Public Sub ReadFromPC()
            Form1.Label_MAR.BackColor = Color.Green
            Form1.Panel_Bus_Address.BackColor = Color.Green
            Form1.Refresh()
            Value = PCV.Counter
            SharedCode.Wait(Form1.Delay)
            Form1.Label_MAR_Binary.Text = Value
            Form1.Label_MAR.BackColor = Color.OrangeRed
        End Sub

    End Class

    Class MBR

        Public Value As String = "0000"

        Public Sub ReadFromRam()
            Form1.Label_MBR.BackColor = Color.Green
            Form1.Panel_Bus_Data.BackColor = Color.Green
            Form1.Refresh()

            SharedCode.Wait(Form1.Delay)
            Value = RamController.GetVal(RegisterController.MARV.Value)

            Form1.Label_MBR_Binary.Text = Value
            Form1.Label_MBR.BackColor = Color.OrangeRed
            Form1.Panel_Bus_Data.BackColor = Color.Gray
        End Sub

    End Class

    Class CIR

        Public Value As String = "00000000"

        Public Sub ReadFromMBR()
            Form1.Label_CIR.BackColor = Color.Green
            Form1.Refresh()

            SharedCode.Wait(Form1.Delay)
            Value = MBRV.Value

            Form1.Label_CIR_Binary.Text = Value
            Form1.Label_CIR.BackColor = Color.OrangeRed
        End Sub

    End Class

End Module