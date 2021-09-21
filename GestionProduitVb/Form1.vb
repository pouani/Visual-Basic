Public Class Form1
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtmail.Text = ""
        txtPsw.Text = ""
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim con As New Connectdb
        con.ConnectionOpen()

        Dim LP As New ListeProduits
        LP.Show()
    End Sub
End Class
