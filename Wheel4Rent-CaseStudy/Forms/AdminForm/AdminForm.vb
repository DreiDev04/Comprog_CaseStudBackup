Imports System.IO

Public Class AdminForm
    Dim db As New Database()
    Dim auth As New AuthManager()
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUserDB()
        InitializeVehicleDB()
        InitializeRentalDB()
    End Sub

    Private Sub InitializeUserDB()
        Dim dt As New DataTable()

        Using reader As New StreamReader(db.get_UserCsvFile)
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split("~"c)
                If isFirstLine Then
                    For Each field In fields
                        dt.Columns.Add(New DataColumn(field.Trim(), GetType(String)))
                    Next
                    isFirstLine = False
                Else
                    Dim row As DataRow = dt.NewRow()
                    For i As Integer = 0 To fields.Length - 1
                        row(i) = fields(i).Trim()
                    Next
                    dt.Rows.Add(row)
                End If
            End While
        End Using

        dgv_user.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_user.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_user.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv_user.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_user.RowHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_user.RowHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv_user.DefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_user.DefaultCellStyle.ForeColor = Color.White
        dgv_user.DefaultCellStyle.Font = New Font("Segoe UI", 10)


        dgv_user.DataSource = dt

        For Each column As DataGridViewColumn In dgv_user.Columns
            ' Example: Set column width
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub InitializeVehicleDB()
        Dim dt As New DataTable()

        Using reader As New StreamReader(db.get_VehicleCsvFile)
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split("~"c)
                If isFirstLine Then
                    For Each field In fields
                        dt.Columns.Add(New DataColumn(field.Trim(), GetType(String)))
                    Next
                    isFirstLine = False
                Else
                    Dim row As DataRow = dt.NewRow()
                    For i As Integer = 0 To Math.Min(fields.Length - 1, dt.Columns.Count - 1)
                        row(i) = fields(i).Trim()
                    Next
                    dt.Rows.Add(row)
                End If
            End While
        End Using

        dgv_vehicle.DataSource = dt

        dgv_vehicle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_vehicle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_vehicle.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv_vehicle.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_vehicle.RowHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_vehicle.RowHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv_vehicle.DefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_vehicle.DefaultCellStyle.ForeColor = Color.White
        dgv_vehicle.DefaultCellStyle.Font = New Font("Segoe UI", 10)

        For Each column As DataGridViewColumn In dgv_vehicle.Columns
            ' Example: Set column width
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Public Sub InitializeRentalDB()
        Dim dt As New DataTable()
        Using reader As New StreamReader(db.get_RentalCsvFile)
            Dim isFirstLine As Boolean = True
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim fields As String() = line.Split("~"c)
                If isFirstLine Then
                    For Each field In fields
                        dt.Columns.Add(New DataColumn(field.Trim(), GetType(String)))
                    Next
                    isFirstLine = False
                Else
                    Dim row As DataRow = dt.NewRow()
                    For i As Integer = 0 To Math.Min(fields.Length - 1, dt.Columns.Count - 1)
                        row(i) = fields(i).Trim()
                    Next
                    dt.Rows.Add(row)
                End If
            End While
        End Using

        dgv_rental.DataSource = dt

        dgv_rental.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_rental.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_rental.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv_rental.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_rental.RowHeadersDefaultCellStyle.ForeColor = Color.White
        dgv_rental.RowHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv_rental.DefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dgv_rental.DefaultCellStyle.ForeColor = Color.White
        dgv_rental.DefaultCellStyle.Font = New Font("Segoe UI", 10)

        For Each column As DataGridViewColumn In dgv_rental.Columns
            ' Example: Set column width
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SplashScreenV2.Close()
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        LoginAdmin.Show()
    End Sub

    Private Sub btn_UdEdit_Click(sender As Object, e As EventArgs) Handles btn_UdEdit.Click
        If dgv_user.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = dgv_user.SelectedCells(0).RowIndex
            Dim columnIndex As Integer = dgv_user.SelectedCells(0).ColumnIndex

            Dim newValue As String = InputBox("Enter the new value:", "Edit Cell", dgv_user.Rows(rowIndex).Cells(columnIndex).Value.ToString())

            If Not String.IsNullOrEmpty(newValue) Then
                dgv_user.Rows(rowIndex).Cells(columnIndex).Value = newValue

                Dim fileToEdit As String = db.get_UserCsvFile()

                If Not String.IsNullOrEmpty(fileToEdit) AndAlso File.Exists(fileToEdit) Then
                    ' Update the cell value in the CSV file
                    EditCellValue(rowIndex, columnIndex, fileToEdit)
                    MessageBox.Show("Cell value updated and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("CSV file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a cell to edit.", "No Cell Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub EditCellValue(rowIndex As Integer, columnIndex As Integer, fileToEdit As String)
        Dim lines As List(Of String) = File.ReadAllLines(fileToEdit).ToList()

        Dim dataRowIndex As Integer = rowIndex + 1
        If dataRowIndex < lines.Count Then
            Dim line As String() = lines(dataRowIndex).Split("~")
            Dim newLine As String = ""

            For i As Integer = 0 To line.Length - 1
                If i = columnIndex Then
                    Dim newCell As String = dgv_user.Rows(rowIndex).Cells(columnIndex).Value.ToString()
                    newLine += newCell
                Else
                    newLine += line(i)
                End If

                If i < line.Length - 1 Then
                    newLine += "~"
                End If
            Next

            lines(dataRowIndex) = newLine
            File.WriteAllLines(fileToEdit, lines)
        Else
            MessageBox.Show("Invalid row index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_UaddRow_Click(sender As Object, e As EventArgs) Handles btn_UaddRow.Click

        Dim name As String = InputBox("Enter the name:", "Name")
        Dim age As Integer
        Dim birthday As Date
        Dim sex As String = InputBox("Enter the sex:", "Sex")
        Dim address As String = InputBox("Enter the address:", "Address")
        Dim username As String = InputBox("Enter the username:", "Username")
        Dim password As String = InputBox("Enter the password:", "Password")
        Dim email As String = InputBox("Enter the email:", "Email")

        Dim ageInput As String = InputBox("Enter the age:", "Age")
        If Not Integer.TryParse(ageInput, age) Then
            MessageBox.Show("Invalid age. Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim birthdayInput As String = InputBox("Enter the birthday:", "Birthday")
        If Not Date.TryParse(birthdayInput, birthday) Then
            MessageBox.Show("Invalid birthday. Please enter a valid date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        auth.SignUp(name, age, birthday, sex, address, username, password, email)
        InitializeUserDB()
    End Sub

    Private Sub btn_UdeleteByUsername_Click(sender As Object, e As EventArgs) Handles btn_UdeleteByUsername.Click
        Dim UID As String = InputBox("Enter the UID:", "UID")
        db.DeleteUser(UID)
        InitializeUserDB()
    End Sub


End Class