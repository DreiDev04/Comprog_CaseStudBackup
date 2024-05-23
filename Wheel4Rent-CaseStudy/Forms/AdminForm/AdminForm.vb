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
        InitializeDataGrid(dgv_user, db.get_UserCsvFile())
    End Sub

    Private Sub InitializeVehicleDB()
        InitializeDataGrid(dgv_vehicle, db.get_VehicleCsvFile())
    End Sub

    Private Sub InitializeRentalDB()
        InitializeDataGrid(dgv_rental, db.get_RentalCsvFile())
    End Sub

    Private Sub InitializeDataGrid(dataGridView As DataGridView, csvFilePath As String)
        Dim dt As New DataTable()

        Using reader As New StreamReader(csvFilePath)
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

        CustomizeDataGridView(dataGridView)
        dataGridView.DataSource = dt
    End Sub

    Private Sub CustomizeDataGridView(dataGridView As DataGridView)
        dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White
        dataGridView.RowHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(53, 59, 72)
        dataGridView.DefaultCellStyle.ForeColor = Color.White
        dataGridView.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub AdminForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SplashScreenV2.Close()
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        LoginAdmin.Show()
    End Sub

    Private Sub btn_UdEdit_Click(sender As Object, e As EventArgs) Handles btn_UdEdit.Click
        EditDataGridViewCell(dgv_user, db.get_UserCsvFile(), AddressOf UEditCellValue)
    End Sub

    Private Sub btn_Redit_Click(sender As Object, e As EventArgs) Handles btn_Redit.Click
        EditDataGridViewCell(dgv_rental, db.get_RentalCsvFile(), AddressOf REditCellValue)
    End Sub

    Private Sub btn_Vedit_Click(sender As Object, e As EventArgs) Handles btn_Vedit.Click
        EditDataGridViewCell(dgv_vehicle, db.get_VehicleCsvFile(), AddressOf VEditCellValue)
    End Sub

    Private Sub EditDataGridViewCell(dataGridView As DataGridView, csvFilePath As String, editCellValueMethod As Action(Of Integer, Integer, String))
        If dataGridView.SelectedCells.Count > 0 Then
            Dim rowIndex As Integer = dataGridView.SelectedCells(0).RowIndex
            Dim columnIndex As Integer = dataGridView.SelectedCells(0).ColumnIndex

            Dim newValue As String = InputBox("Enter the new value:", "Edit Cell", dataGridView.Rows(rowIndex).Cells(columnIndex).Value.ToString())

            If Not String.IsNullOrEmpty(newValue) Then
                dataGridView.Rows(rowIndex).Cells(columnIndex).Value = newValue

                If Not String.IsNullOrEmpty(csvFilePath) AndAlso File.Exists(csvFilePath) Then
                    editCellValueMethod(rowIndex, columnIndex, csvFilePath)
                    MessageBox.Show("Cell value updated and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("CSV file not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a cell to edit.", "No Cell Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub UEditCellValue(rowIndex As Integer, columnIndex As Integer, fileToEdit As String)
        EditCellValue(dgv_user, rowIndex, columnIndex, fileToEdit)
    End Sub

    Public Sub REditCellValue(rowIndex As Integer, columnIndex As Integer, fileToEdit As String)
        EditCellValue(dgv_rental, rowIndex, columnIndex, fileToEdit)
    End Sub

    Public Sub VEditCellValue(rowIndex As Integer, columnIndex As Integer, fileToEdit As String)
        EditCellValue(dgv_vehicle, rowIndex, columnIndex, fileToEdit)
    End Sub

    Private Sub EditCellValue(dataGridView As DataGridView, rowIndex As Integer, columnIndex As Integer, fileToEdit As String)
        Dim lines As List(Of String) = File.ReadAllLines(fileToEdit).ToList()
        Dim dataRowIndex As Integer = rowIndex + 1

        If dataRowIndex < lines.Count Then
            Dim line As String() = lines(dataRowIndex).Split("~"c)
            line(columnIndex) = dataGridView.Rows(rowIndex).Cells(columnIndex).Value.ToString()
            lines(dataRowIndex) = String.Join("~", line)
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

    Private Sub btn_Vdel_Click(sender As Object, e As EventArgs) Handles btn_Vdel.Click
        Dim UID As String = InputBox("Enter the Car ID:", "Car ID")
        db.DeleteCar(UID)
        InitializeVehicleDB()
    End Sub

    Private Sub btn_VaddRow_Click(sender As Object, e As EventArgs) Handles btn_VaddRow.Click
        Dim carID As String = InputBox("Enter the Car ID:", "Car ID")
        Dim modelName As String = InputBox("Enter the Model:", "Model")
        Dim plateNumber As String = InputBox("Enter the Plate Number:", "Plate Number")
        Dim color As String = InputBox("Enter the Color:", "Color")
        Dim type As String = InputBox("Enter the Type:", "Type")
        Dim capacity As Integer = InputBox("Enter the Capacity:", "Capacity")
        Dim bodyNumber As String = InputBox("Enter the Body Number:", "Body Number")
        Dim isAvailable As String = InputBox("Enter the Availability:", "Availability")
        Dim dailyPrice As Double = InputBox("Enter the Daily Price:", "Daily Price")
        Dim posterPath As String = InputBox("Enter the Poster Path:", "Poster Path")
        Dim description As String = InputBox("Enter the Description:", "Description")

        Dim vehicle As New VehicleDetails(carID, modelName, plateNumber, color, type, capacity, bodyNumber, isAvailable, dailyPrice, posterPath, description)
        db.AddCarToDB(vehicle)
        InitializeVehicleDB()
    End Sub


End Class
