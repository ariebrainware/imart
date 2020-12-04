
Imports System.Data.Odbc
Module connection
    Public conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public query As OdbcCommand
    Public ds As DataSet
    Public reader As OdbcDataReader
    Public command, username As String
    Public Sub dbconnection()
        Dim teks As String = "Dsn=imart;server=127.0.0.1;uid=root;password=L0c4lDB;database=imart;port=3306"
        conn = New OdbcConnection(teks)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module