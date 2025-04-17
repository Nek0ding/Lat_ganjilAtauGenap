Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim angka = input_angka.Text
        Dim cekInt As Integer
        If IsNumeric(angka) Then
            If Integer.TryParse(angka, cekInt) Then
                If angka Mod 2 = 0 Then
                    hasil.Text = "Angka " + angka + " adalah bilangan genap"
                Else
                    hasil.Text = "Angka " + angka + " Bilangan Ganjil"
                End If
            Else
                MsgBox("Masukkan bilangan bulat!")
                input_angka.Clear()
                input_angka.Focus()
            End If
        Else
            MsgBox("Masukkan angka!")
            input_angka.Clear()
            input_angka.Focus()
        End If
    End Sub
End Class
