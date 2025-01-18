Imports System.Diagnostics
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim psi As New ProcessStartInfo("https://180wsox.github.io/streetlight_contractor_shop/homepage.html")
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Error visiting the 180WSOX Streetlight Contractor Shop: " & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim psi As New ProcessStartInfo("https://180wsox.github.io/180wsox.com/")
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Error visiting the 180WSOX Website: " & ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim psi As New ProcessStartInfo("https://github.com/180wsox/streetlight_contractor_shop")
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Error visiting the 180WSOX Streetlight Contractor Shop GitHub Page: " & ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim psi As New ProcessStartInfo("https://github.com/180wsox/180wsox.com")
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Error visiting the 180WSOX Website GitHub Page: " & ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim psi As New ProcessStartInfo("https://github.com/180wsox")
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Error visiting the 180WSOX GitHub Page: " & ex.Message)
        End Try
    End Sub
End Class
