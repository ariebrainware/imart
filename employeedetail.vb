Imports System.Data.Odbc
Public Class employeedetail
    Dim gender As String
    Sub clearField()
        EmployeeIDTextBox.Text = ""
        NameTextBox.Text = ""
        MaleRadioButton.Checked = True
        PlaceOfBirthTextBox.Text = ""
        DateOfBirthDateTimePicker.Value = Now
        PhoneTextBox.Text = ""
        AddressTextBox.Text = ""
    End Sub
    Function validateIfExist(setfield As Boolean) As Boolean
        dbconnection()
        command = "SELECT * FROM employee WHERE id='" & EmployeeIDTextBox.Text & "'"
        query = New OdbcCommand(command, conn)
        reader = query.ExecuteReader()
        If setfield = True Then
            If reader.HasRows Then
                NameTextBox.Text = reader.Item("name")
                gender = reader.Item("gender")
                If gender = "female" Then
                    FemaleRadioButton.Checked = True
                Else
                    MaleRadioButton.Checked = True
                End If
                PlaceOfBirthTextBox.Text = reader.Item("place_of_birth")
                DateOfBirthDateTimePicker.Value = reader.Item("date_of_birth")
                PhoneTextBox.Text = reader.Item("phone")
                AddressTextBox.Text = reader.Item("address")
                Return True
            Else
                Return False
            End If
        End If
        conn.Close()
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Handle update employee data
        If SaveButton.Text = "Update" Then
            dbconnection()
            If FemaleRadioButton.Checked = True Then
                gender = "female"
            Else
                gender = "male"
            End If
            command = "UPDATE employee SET name='" & NameTextBox.Text & "', 
gender='" & gender & "',place_of_birth='" & PlaceOfBirthTextBox.Text & "',date_of_birth='" & DateOfBirthDateTimePicker.Value & "',phone='" & PhoneTextBox.Text & "',address='" & AddressTextBox.Text & "' WHERE id='" & EmployeeIDTextBox.Text & "'"
            query = New OdbcCommand(command, conn)
            query.ExecuteNonQuery()
            If MessageBox.Show("Employee information updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                employee.showData()
            End If
            conn.Close()
            Return
        End If

        dbconnection()
        Dim exist = validateIfExist(True)
        If exist Then
            MessageBox.Show("Employee based on this employee id already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            clearField()
            Return
        End If

        If FemaleRadioButton.Checked = True Then
            gender = "female"
        Else
            gender = "male"
        End If

        command = "INSERT INTO employee (id,name,gender,place_of_birth,date_of_birth,phone,address) VALUES('" & EmployeeIDTextBox.Text & "','" & NameTextBox.Text & "',
'" & gender & "','" & PlaceOfBirthTextBox.Text & "','" & DateOfBirthDateTimePicker.Value & "',
'" & PhoneTextBox.Text & "', '" & AddressTextBox.Text & "')"
        query = New OdbcCommand(command, conn)
        query.ExecuteNonQuery()

        If MessageBox.Show("Employee Added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
            clearField()
            employee.showData()
        End If
    End Sub

    Private Sub addemployee_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        employee.Show()
    End Sub

    Private Sub EmployeeIDTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles EmployeeIDTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim exist = validateIfExist(True)
                If exist Then
                    If MessageBox.Show("Employee based on this employee id already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                        clearField()
                    End If
                End If
        End Select
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        clearField()
        Me.Dispose()
        employee.Show()
    End Sub

    Private Sub addemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearField()
    End Sub
End Class