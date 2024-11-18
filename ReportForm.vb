Public Class ReportForm
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load student data into the DataGridView (for demonstration purposes)
        dgvAttendance.Columns.Add("StudentNo", "Student Number")
        dgvAttendance.Columns.Add("RegNo", "Registration Number")
        dgvAttendance.Columns.Add("FullName", "Full Name")
        dgvAttendance.Columns.Add("Course", "Course")
        dgvAttendance.Columns.Add("Year", "Year")

        ' Sample data for demonstration
        dgvAttendance.Rows.Add("S001", "REG123", "John Doe", "BSc Computer Science", "Year 1")
        dgvAttendance.Rows.Add("S002", "REG456", "Jane Smith", "BSc Software Engineering", "Year 2")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Go back to the Registration Form
        Dim registrationForm As New RegistrationForm
        registrationForm.Show()
        Me.Hide()
    End Sub
End Class
