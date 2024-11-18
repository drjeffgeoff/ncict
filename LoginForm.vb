Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Basic user authentication for demonstration purposes
        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            ' If login is successful, open RegistrationForm
            Dim registrationForm As New RegistrationForm
            registrationForm.Show()
            Me.Hide() ' Hide the login form
        Else
            MessageBox.Show("Invalid Username or Password. Please try again.")
        End If
    End Sub
End Class
