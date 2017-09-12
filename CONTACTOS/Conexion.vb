Imports System.Data.OleDb
Imports System.IO

Module Conexion
    Public direcciones() As String
    Public strBD As String = My.Settings.strDB1 '"C:\Contactos\Contactos.accdb"
    Public conn As OleDbConnection
    Public borrado As Boolean = False
    Public cmTEMP As String
    'Llama a un OpenFileDialog para cojer la dirección de la BD
    Public Sub direccion()
        Dim files As New OpenFileDialog
        Try
            files.Title = "Selecciona archivo"
            files.Filter = "Elige archivo|*.*"
            files.Multiselect = True
            If (files.ShowDialog() = 1) Then
                direcciones = files.FileNames
            End If
        Catch
            MessageBox.Show("Problema al cargar la dirección de la base de datos")
        End Try

    End Sub

    'Método donde se coje la dirección de la BD
    Private Sub pathBD()
        MessageBox.Show("No se pudo encontrar la Base de Datos. Especifica su ubicación.")
        direccion()
        strBD = direcciones(0)
        My.Settings.strDB1 = direcciones(0)
    End Sub

    Public Function abrir()
        'Mientras no exista el archivo que le pasamos pide uno.
        'Se utiliza para cojer la dirección correcta de la base de datos
        Try
            While (Not File.Exists(strBD))
                pathBD()
            End While
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & strBD)
            conn.Open()
        Catch
            MessageBox.Show("Problemas al abrir la base de datos.")
        End Try
        Return strBD
    End Function

    Public Sub cerrar()
        conn.Close()
    End Sub

End Module
