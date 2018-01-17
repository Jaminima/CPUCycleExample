Module RegisterController

    Public PCV As New PC

    Class PC

        Public Counter As String = "0000"

        Sub Iterate()
            Counter = SharedCode.BinaryV.MakeLength(SharedCode.BinaryV.BinaryMath(Counter, "0001"), 4)
            Form1.Label_PC.BackColor = Color.Green
            Form1.Refresh()
            SharedCode.Wait(Form1.Delay)
            Form1.Label_PC.BackColor = Color.OrangeRed
            Form1.Label_PC_Binary.Text = Counter
        End Sub

    End Class

End Module