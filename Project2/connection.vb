Module connection
    Public ds As New DataSet
    Public cmd As New OleDb.OleDbCommand
    Public da As New OleDb.OleDbDataAdapter
    Public con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\koopsystem.accdb")
    Public dataReader As OleDb.OleDbDataReader
End Module
