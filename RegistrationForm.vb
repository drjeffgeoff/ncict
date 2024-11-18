Public Class RegistrationForm
    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        ' Open a File Dialog to select an image
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png"
        
        If ofd.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into PictureBox
            picStudentImage.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Save the registration details (for demonstration, using MessageBox)
        MessageBox.Show("Student Registration Successful!" & Environment.NewLine &
                        "Student No: " & txtStudentNo.Text & Environment.NewLine &
                        "Registration No: " & txtRegNo.Text & Environment.NewLine &
                        "Full Name: " & txtFullName.Text & Environment.NewLine &
                        "Course: " & cmbCourse.Text & Environment.NewLine &
                        "Year: " & GetSelectedYear())
    End Sub

    Private Function GetSelectedYear() As String
        ' Get selected year from CheckBoxes
        If chkYear1.Checked Then Return "Year 1"
        If chkYear2.Checked Then Return "Year 2"
        If chkYear3.Checked Then Return "Year 3"
        If chkYear4.Checked Then Return "Year 4"
        Return "Unknown Year"
    End Function

    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        ' Open the ReportForm
        Dim reportForm As New ReportForm
        reportForm.Show()
        Me.Hide() ' Hide the registration form
    End Sub
End Class
