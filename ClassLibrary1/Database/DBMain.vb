Module DBMain


    'Dim _conList = GetConnection()
    Dim a As DBManager = New DBManager()
    Sub OpenConection(ByVal ConList As IEnumerable(Of DBManager))

        'a.ConnectionString = "Asd"
        'Dim config As SQLite = New SQLite()
        'config.BasePath = "saf"
        'config.Name = "U01"
        'a.Add(config)
        'Dim user = a.GetDB("asd")
    End Sub



    'Function GetConnection() As IEnumerable(Of DBManager)

    '    Return New List(Of DBManager) From
    '        {
    '        New DBManager("Product", "Config", "SQL"),
    '        New DBManager("User", "Config", "SQL"),
    '        New DBManager("Production", "Config", "Access")
    '        }
    'End Function

End Module
