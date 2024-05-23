Imports System.IO

Public Class AdminForm
    Dim db As New Database()
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
            ' Get the row and column index of the selected cell
            Dim rowIndex As Integer = dgv_user.SelectedCells(0).RowIndex
            Dim columnIndex As Integer = dgv_user.SelectedCells(0).ColumnIndex

            ' Prompt the user for input
            Dim newValue As String = InputBox("Enter the new value:", "Edit Cell", dgv_user.Rows(rowIndex).Cells(columnIndex).Value.ToString())

            ' Check if the user entered a value
            If Not String.IsNullOrEmpty(newValue) Then
                ' Update the DataGridView cell
                dgv_user.Rows(rowIndex).Cells(columnIndex).Value = newValue

                ' Update the corresponding cell in the CSV file
                Dim fileToEdit As String = db.get_UserCsvFile
                EditCellValue(rowIndex, columnIndex, fileToEdit)
            End If
        Else
            MessageBox.Show("Please select a cell to edit.", "No Cell Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub EditCellValue(rowIndex As Integer, columnIndex As Integer, fileToEdit As String)
        Dim lines As List(Of String) = File.ReadAllLines(fileToEdit).ToList()
        Dim line As String() = lines(rowIndex).Split("~")
        Dim newLine As String = ""
        For i As Integer = 0 To line.Length - 1
            If i = columnIndex Then
                Dim newCell As String = dgv_user.Rows(rowIndex).Cells(columnIndex).Value.ToString()
                newLine += newCell
                If i < line.Length - 1 Then
                    newLine += "~"
                End If
            Else
                newLine += line(i)
                If i < line.Length - 1 Then
                    newLine += "~"
                End If
            End If
        Next
        lines(rowIndex) = newLine
        File.WriteAllLines(fileToEdit, lines)
    End Sub
End Class