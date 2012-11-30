Public Class dynamic

    Private picBoxes() As PictureBox
    Private arrSize As Integer = 15

    Private Sub dynamic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ReDim picBoxes(arrSize)

        For i As Integer = 1 To arrSize
            picBoxes(i) = New PictureBox()

            With picBoxes(i)
                .Name = "Picture " & i
                .BorderStyle = BorderStyle.FixedSingle
                .Height = 45
                .Width = 45
                .SizeMode = PictureBoxSizeMode.StretchImage
                .ImageLocation = "D:\Online_Jobs\oDesk\metro rf\source\icons\image_icon1 copy.png"
                .Visible = True
                AddHandler .Click, AddressOf clkMe
            End With

            Me.FlowLayoutPanel1.Controls.Add(picBoxes(i))
        Next

    End Sub

    Public Sub clkMe(ByVal obj As System.Object, ByVal e As System.EventArgs)
        MsgBox("Name: " + obj.Name, MsgBoxStyle.Information, "Confirm Message")

    End Sub
End Class