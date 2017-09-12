Imports System.Data.OleDb

Public Class clsContactos

#Region "Variables primitivas"
    Private vsNombre, vsTelefono, vsEmpresa, vsComentarios, vsDireccion As String
    Private vdFecLLam, vdFecLlam1 As Date
#End Region

#Region "Objetos"
    Private comando As OleDbCommand
    Private adapter As OleDbDataAdapter
#End Region

#Region "Propiedades"
    Public Property Nombre As String
        Get
            Nombre = vsNombre
        End Get
        Set(ByVal value As String)
            vsNombre = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Telefono = vsTelefono
        End Get
        Set(ByVal value As String)
            vsTelefono = value
        End Set
    End Property

    Public Property Empresa As String
        Get
            Empresa = vsEmpresa
        End Get
        Set(ByVal value As String)
            vsEmpresa = value
        End Set
    End Property

    Public Property Comentarios As String
        Get
            Comentarios = vsComentarios
        End Get
        Set(ByVal value As String)
            vsComentarios = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Direccion = vsDireccion
        End Get
        Set(ByVal value As String)
            vsDireccion = value
        End Set
    End Property

    Public Property Fecha_Llamada As Date
        Get
            Fecha_Llamada = vdFecLLam.Date.ToString("dd/MM/yyyy")
        End Get
        Set(ByVal value As Date)
            vdFecLLam = value.Date.ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property Fecha_Llamada1 As Date
        Get
            Fecha_Llamada1 = vdFecLlam1
        End Get
        Set(ByVal value As Date)
            vdFecLlam1 = value
        End Set
    End Property


#End Region

    Public Function isRegistro() As Integer
        Dim nReg As Integer
        Dim sqlEsta = "SELECT * FROM contactos WHERE nombre=@nombre and telefono=@telefono"
        Dim comando As OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim datosTab As New DataTable
        If (vsTelefono.Length >= 9) Then
            comando = New OleDbCommand(sqlEsta, conn)
            comando.Parameters.AddWithValue("@nombre", vsNombre)
            comando.Parameters.AddWithValue("@telefono", vsTelefono)
            adapter = New OleDbDataAdapter(comando)
            adapter.Fill(datosTab)
            nReg = datosTab.Rows.Count
        Else
            nReg = -1
        End If

        Return nReg
    End Function

    'Selecciona todos los registros de la tabla contactos de la base de datos.

    Public Function selectAll() As DataTable
        Dim datosTab1 As New DataTable
        Dim sqlSelectAll As String = "SELECT * FROM contactos order by número"
        comando = New OleDbCommand(sqlSelectAll, conn)
        adapter = New OleDbDataAdapter(comando)
        adapter.Fill(datosTab1)
        Return datosTab1
    End Function

    Public Function selectInforme() As DataTable
        Dim sqlSelectInforme As String = "SELECT nombre, telefono, empresa, fecha_llamada, comentarios FROM contactos WHERE 1=1"
        Dim datosTab As New DataTable
        Dim comando As OleDbCommand
        Dim adapter As OleDbDataAdapter
        If (vsComentarios <> vbNullString) Then
            sqlSelectInforme = sqlSelectInforme & " AND comentarios like '%" & vsComentarios & "%'"
        End If
        If (vsEmpresa <> vbNullString) Then
            sqlSelectInforme = sqlSelectInforme & " AND empresa='" & vsEmpresa & "'"
        End If
        If (vdFecLLam <> Nothing) Then
            sqlSelectInforme = sqlSelectInforme & " AND fecha_llamada between #" & vdFecLLam & "# and #" & vdFecLlam1 & "#"
        End If
        comando = New OleDbCommand(sqlSelectInforme, conn)
        adapter = New OleDbDataAdapter(comando)
        adapter.Fill(datosTab)
        Return datosTab
    End Function
    'Selecciona los registros en funcion de los valores que le pasemos de los campos
    Public Function selectCustom() As DataTable
        Dim datosTab1 As New DataTable
        Dim sqlSelectCustom As String = "SELECT * FROM contactos WHERE 1=1 "
        If (vsNombre <> vbNullString) Then
            sqlSelectCustom = sqlSelectCustom & "and nombre like '%" & vsNombre & "%'"
        End If
        If (vsTelefono <> vbNullString) Then
            sqlSelectCustom = sqlSelectCustom & " and telefono like '%" & vsTelefono & "%'"
        End If

        If (vsEmpresa <> vbNullString) Then
            sqlSelectCustom = sqlSelectCustom & " and empresa like '%" & vsEmpresa & "%'"
        End If

        If (vsComentarios <> vbNullString) Then
            sqlSelectCustom = sqlSelectCustom & " and comentarios like '%" & vsComentarios & "%'"
        End If
        If (vdFecLLam <> Nothing) Then
            sqlSelectCustom = sqlSelectCustom & " and fecha_llamada between #" & vdFecLLam.Date.ToString("MM/dd/yyyy") & "# AND #" & vdFecLlam1.Date.ToString("MM/dd/yyyy") & "#"
        End If
        sqlSelectCustom = sqlSelectCustom & " order by número"
        comando = New OleDbCommand(sqlSelectCustom, conn)
        adapter = New OleDbDataAdapter(comando)

        adapter.Fill(datosTab1)
        Return datosTab1
    End Function

    'Inserta un nuevo registro
    Public Function insert() As Integer
        Dim sqlInsert As String = "INSERT INTO contactos (nombre,telefono,direccion,empresa,comentarios,fecha_llamada) values (@nombre,@telefono,@direccion,@empresa,@comentarios,@fecha_llamada)"
        Dim cant As Integer = 0

        Try
           
            Select Case isRegistro()
                Case Is > 0
                    cant = -2
                Case Is = -1
                    cant = -1
                Case Else
                    comando = New OleDbCommand(sqlInsert, conn)
                    comando.Parameters.AddWithValue("@nombre", vsNombre)
                    comando.Parameters.AddWithValue("@telefono", vsTelefono)
                    comando.Parameters.AddWithValue("@direccion", vsDireccion)
                    comando.Parameters.AddWithValue("@empresa", vsEmpresa)
                    comando.Parameters.AddWithValue("@comentarios", vsComentarios)
                    comando.Parameters.AddWithValue("@fecha_llamada", vdFecLLam)
                    cant = comando.ExecuteNonQuery
            End Select
        Catch
            cant = 0
        End Try
        Return cant
    End Function

    'Borra un nuevo resgistro
    Public Function delete() As Integer
        Dim sqlDelete = "DELETE FROM contactos WHERE nombre=@nombre and telefono=@telefono"
        Dim n As Integer
        comando = New OleDbCommand(sqlDelete, conn)
        Try
            comando.Parameters.AddWithValue("@nombre", vsNombre)
            comando.Parameters.AddWithValue("@telefono", vsTelefono)
            n = comando.ExecuteNonQuery
        Catch

        End Try

        Return n
    End Function

    'Actualiza un registro con los valores que le pasemos
    Public Function update() As Integer
        Dim sqlUpdate As String = "UPDATE contactos SET nombre=@nombre, telefono=@telefono, empresa=@empresa, direccion=@direccion, comentarios=@comentarios, fecha_llamada=@fechLLam WHERE nombre=@nombre and telefono=@telefono"
        Dim n As Integer
        comando = New OleDbCommand(sqlUpdate, conn)
        comando.Parameters.AddWithValue("@nombre", vsNombre)
        comando.Parameters.AddWithValue("@telefono", vsTelefono)
        comando.Parameters.AddWithValue("@empresa", vsEmpresa)
        comando.Parameters.AddWithValue("@direccion", vsDireccion)
        comando.Parameters.AddWithValue("@comentarios", vsComentarios)
        comando.Parameters.AddWithValue("@fechLLam", vdFecLLam)
        n = comando.ExecuteNonQuery()
        Return n
    End Function
End Class
