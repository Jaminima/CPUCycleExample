Module RamController

    Public Function GetVal(Address As String)
        If Address = "1100" Then
            PCV.Counter = "0000"
            Form1.Label_PC_Binary.Text = PCV.Counter
        End If
        For Each Control In Form1.Table_Ram.Controls
            If Control.Name = ("TxtBox_Ram_" & Address) Then
                Control.BackColor = Color.Green
                Form1.Refresh()
                SharedCode.Wait(Form1.Delay)
                Control.BackColor = Color.White
                Form1.Panel_Bus_Address.BackColor = Color.Gray
                Return Control.Text
            End If
        Next
        Return "Er1"
    End Function

End Module
