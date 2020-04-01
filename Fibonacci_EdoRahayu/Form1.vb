Public Class Form1

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        Dim x As Integer
        Dim z As Integer = 1
        Dim fib As Integer
        Dim int As Integer
        If TextBox1.Text = "" OrElse TextBox1.Text <= 0 Then
            MsgBox("Masukkan Nilai Batas")
        ElseIf TextBox1.Text >= 18 Then
            MsgBox("Hasil Tidak Boleh Melebihi 1000")
        Else
            int = TextBox1.Text
        End If
        txtHasil.Text = ""
        If int > 0 Then
            txtHasil.Text = txtHasil.Text + x.ToString + ", "
            If int > 1 Then
                txtHasil.Text = txtHasil.Text + z.ToString + ", "
            End If
        End If
        int = int - 2
        While int > 0
            fib = x + z
            x = z
            z = fib
            txtHasil.Text = txtHasil.Text + fib.ToString + ", "
            int = int - 1
        End While
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Enter And Keys.Back) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            btnHasil_Click(Me, EventArgs.Empty)
        End If
    End Sub

End Class
