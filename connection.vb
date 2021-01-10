
Imports System.Data.Odbc
Module connection
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public query As OdbcCommand
    Public ds As DataSet
    Public reader As OdbcDataReader
    Private Declare Function timeGetTime Lib "winmm.dll" () As Long
    Public lngStartTime As Long
    Public command, username, loginEntitityID, level, totalPayment As String
    Public DGVDeleteColumnButton, DGVEditColumnButton As New DataGridViewButtonColumn
    Public Sub dbconnection()
        Dim teks As String = "Dsn=imart;server=127.0.0.1;uid=root;password=L0c4lDB;database=imart;port=3306"
        conn = New OdbcConnection(teks)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Function generateInvoiceNumber() As String
        Dim newInvoiceNumber As String
        Dim uTime As Double
        Dim currentTime = Format(Now, "ddMMyyyy")
        dbconnection()
        'invoiceNumber = reader.Item("invoice_number")
        'no = Val(Microsoft.VisualBasic.Right(invoiceNumber, 3))
        'no += 1
        uTime = (DateTime.Now - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds
        newInvoiceNumber = "VAR" + currentTime + loginEntitityID + Format(uTime, "0000000000")
        Return newInvoiceNumber
    End Function

    Public Sub delay(msdelay As Long)
        lngStartTime = timeGetTime()
        Do Until (timeGetTime() - lngStartTime) > msdelay
        Loop
    End Sub
End Module