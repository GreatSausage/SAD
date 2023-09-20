Module MdlFunctions
    Public Sub RoundCorners(obj As Form)

        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    Public Sub EmptyTextbox()
        MessageBox.Show("Please fill up the necessary fields to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub AntiSymbolsInput(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Public Sub AntiCopyPasteInput(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso (e.KeyCode = Keys.V OrElse e.KeyCode = Keys.C) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Public Sub BilognaPictureBox(pbox As PictureBox)
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, pbox.Width, pbox.Height)
        Dim region As New Region(path)
        pbox.Region = region
    End Sub

End Module
