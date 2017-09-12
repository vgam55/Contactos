Imports Microsoft.Office.Interop


Public Class fPrincipal
    Private contactos As New clsContactos
    'Acciones que se realizan cuando se carga el formulario
    Private Sub fPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        abrir()
        dgvPrincVisualizar.DataSource = contactos.selectAll
        dtpFechaLLam.Value = "01/01/2014"
        '    dtpFechLLam1.Value = "01/01/2014"
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
        dgvPrincVisualizar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    'Logica para vaciar de contenido los controles de la zona de Edición
    Private Sub limpiarPrinEd()
        tbPrinEdDireccion.Text = ""
        tbPrinEdEmpresa.Text = ""
        tbPrinEdNombre.Text = ""
        tbPrinEdTelefono.Text = ""
        rtbPrinEdComentarios.Text = ""
    End Sub

    'Logica para vaciar de contenido los controles de la zona de Filtro
    Private Sub limpiarPrincFilt()
        tbPrincFiltDireccion.Text = ""
        tbPrincFiltEmpresa.Text = ""
        tbPrincFiltNombre.Text = ""
        tbPrincFiltTelefono.Text = ""
        rtbPrincFiltComentarios.Text = ""
        dtpFechaLLam.Value = "01/01/2014"
    End Sub

    'Limpia la zona de edición cuando se pincha en el botón de Limpiar Edición.
    Private Sub btPrincEdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrincEdLimpiar.Click
        limpiarPrinEd()
        cogerDatosEd()
    End Sub

    'Limpia la zona de filtrado cuando se pincha en el botón Limpiar Filtros
    Private Sub btPrincFiltLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrincFiltLimpiar.Click
        limpiarPrincFilt()
        cogerDatosFilt()
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    'Manda los datos de la zona de edición al objeto Contactos
    Private Sub cogerDatosEd()
        contactos.Direccion = tbPrinEdDireccion.Text()
        contactos.Empresa = tbPrinEdEmpresa.Text
        contactos.Nombre = tbPrinEdNombre.Text
        contactos.Telefono = tbPrinEdTelefono.Text
        contactos.Comentarios = rtbPrinEdComentarios.Text
        contactos.Fecha_Llamada = dtpFechaLLam1.Value
    End Sub

    'Coge los datos de la zona de filtrado
    Private Sub cogerDatosFilt()
        contactos.Nombre = tbPrincFiltNombre.Text
        contactos.Telefono = tbPrincFiltTelefono.Text
        contactos.Empresa = tbPrincFiltEmpresa.Text
        contactos.Direccion = tbPrincFiltDireccion.Text
        contactos.Comentarios = rtbPrincFiltComentarios.Text
        contactos.Fecha_Llamada = dtpFechaLLam.Value
        contactos.Fecha_Llamada1 = dtpFechaLLamada1.Value
    End Sub

    'Guarda los un nuevo registro en la base de datos
    Private Sub btPrincEdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrincEdGuardar.Click
        If (btPrincEdGuardar.Text = "Guardar Registro") Then
            cogerDatosEd()
            Select Case contactos.insert()
                Case -2
                    lblOperacion.Text = "Ya has introducido alguien con ese nombre y ese telefono"
                Case -1
                    lblOperacion.Text = "Le faltaban digitos al número de telefono."
                Case 0
                    lblOperacion.Text = "El registro no se pudo guardar"
                Case Else
                    lblOperacion.Text = "Registro guardado con exito"
                    dgvPrincVisualizar.DataSource = contactos.selectAll
                    lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
                    limpiarPrinEd()
            End Select
        End If
    End Sub

    'Cierra la conexión a la BD y la aplicación cuando le damos al botón cerrar aplicación
    Private Sub btPrincCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrincCerrar.Click
        cerrar()
        Me.Close()
    End Sub

    'Sirve para filtrar los registros
    Private Sub tbPrincFiltNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrincFiltNombre.TextChanged
        cogerDatosFilt()
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    Private Sub tbPrincFiltTelefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrincFiltTelefono.TextChanged
        cogerDatosFilt()
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    Private Sub tbPrincFiltEmpresa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrincFiltEmpresa.TextChanged
        cogerDatosFilt()
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    Private Sub tbPrincFiltDireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrincFiltDireccion.TextChanged
        cogerDatosFilt()
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    Private Sub rtbPrincFiltComentarios_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbPrincFiltComentarios.TextChanged
        cogerDatosFilt()
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    Private Sub dtpFechaLLam_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaLLam.CloseUp
        contactos.Fecha_Llamada = dtpFechaLLam.Value
        contactos.Fecha_Llamada1 = dtpFechaLLamada1.Value
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    Private Sub dtpFechaLLamada1_CloseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaLLamada1.CloseUp
        contactos.Fecha_Llamada = dtpFechaLLam.Value
        contactos.Fecha_Llamada1 = dtpFechaLLamada1.Value
        dgvPrincVisualizar.DataSource = contactos.selectCustom
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    'Evento que genera el borrado de un registro que hemos pasado a la zona de edición.
    Private Sub btPrincEdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrincEdBorrar.Click
        contactos.Nombre = tbPrinEdNombre.Text
        contactos.Telefono = tbPrinEdTelefono.Text
        lblOperacion.Text = "Se han borrado " & contactos.delete & " registros"
        limpiarPrinEd()
        dgvPrincVisualizar.DataSource = contactos.selectAll
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    'Pasa la información del datagrid a los textbox.
    Private Sub dgvPrincVisualizar_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvPrincVisualizar.DoubleClick
        If (Not dgvPrincVisualizar.CurrentRow.Cells("Empresa").Value.Equals(DBNull.Value)) Then
            tbPrinEdEmpresa.Text = dgvPrincVisualizar.CurrentRow.Cells("Empresa").Value
        End If
        tbPrinEdNombre.Text = dgvPrincVisualizar.CurrentRow.Cells("Nombre").Value
        tbPrinEdTelefono.Text = dgvPrincVisualizar.CurrentRow.Cells("Telefono").Value

        If (Not dgvPrincVisualizar.CurrentRow.Cells("Direccion").Value.Equals(DBNull.Value)) Then
            tbPrinEdDireccion.Text = dgvPrincVisualizar.CurrentRow.Cells("Direccion").Value
        End If

        If (Not dgvPrincVisualizar.CurrentRow.Cells("Nombre").Value.Equals(DBNull.Value)) Then
            rtbPrinEdComentarios.Text = dgvPrincVisualizar.CurrentRow.Cells("Comentarios").Value
        End If
        dtpFechaLLam1.Value = dgvPrincVisualizar.CurrentRow.Cells("Fecha_LLamada").Value
    End Sub

    'Actualiza los datos de un registro que hayamos pasado a la zona de edición
    Private Sub btPrincActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrincActualizar.Click
        'contactos.Nombre = tbPrinEdNombre.Text
        cogerDatosEd()
        lblOperacion.Text = "Se han actualizado " & contactos.update & "registro/s"
        dgvPrincVisualizar.DataSource = contactos.selectAll
        limpiarPrinEd()
        lblFiltTotal.Text = "Número total de registros: " & dgvPrincVisualizar.Rows.Count
    End Sub

    'Cierra la aplicación al hacer clic en el botón "Cerrar aplicación" del menu que hay en la parte superior del formulario
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        cerrar()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Function pedirRuta() As String
        Dim direccion As New SaveFileDialog
        Dim direcc As String 'Coge la ruta elegida para devolverla
        direccion.Filter = "Elige un archivo|*.xls"
        direccion.Title = "Elige destino"
        direccion.FilterIndex = 2
        direccion.RestoreDirectory = True
        If (direccion.ShowDialog = DialogResult.OK) Then
            direcc = direccion.FileName
        Else
            direcc = "No se eligio direccion"
        End If
        Return direcc
    End Function

    Private Sub btTsPrinInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTsPrinInforme.Click
        Dim datosTab As New System.Data.DataTable
        Dim direccion As String
        Dim cabecera() As String = {"NOMBRE", "TELEFONO", "EMPRESA", "FECHA", "COMENTARIOS"}
        Dim excelApp As Excel.Application
        Dim libroExcel As Excel.Workbook
        Dim hoja As Excel.Worksheet
        Dim fila, columna As Integer
        cogerDatosFilt()
        direccion = pedirRuta()
        datosTab = contactos.selectInforme
        excelApp = CreateObject("Excel.Application")
        libroExcel = excelApp.Workbooks.Add
        hoja = CType(libroExcel.Sheets("Hoja1"), Excel.Worksheet)
        hoja.Range("A1").Resize(1, cabecera.Length).Value = cabecera
        For fila = 0 To datosTab.Rows.Count - 1
            For columna = 0 To datosTab.Columns.Count - 1
                hoja.Cells(fila + 2, columna + 1).value = datosTab.Rows(fila).Item(columna)
            Next
        Next
        With hoja.Range("A1:E" & fila + 1)
            .Font.Bold = True
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .ColumnWidth = 30
            .RowHeight = 40
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .WrapText = True
        End With
        excelApp.Application.DisplayAlerts = False
        libroExcel.SaveAs(direccion)
        libroExcel.Close()
        excelApp.Workbooks.Close()
        excelApp.Quit()
        'Cierra el procesos Excel que le indiquemos
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub


    Private Sub btPrinCopSeg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPrinCopSeg.Click
        Dim datosTab As New System.Data.DataTable
        Dim direccion As String
        Dim cabecera() As String = {"NOMBRE", "TELEFONO", "EMPRESA", "FECHA", "COMENTARIOS"}
        Dim excelApp As Excel.Application
        Dim libroExcel As Excel.Workbook
        Dim hoja As Excel.Worksheet
        Dim fila, columna As Integer
        direccion = pedirRuta()
        datosTab = contactos.selectInforme
        excelApp = CreateObject("Excel.Application")
        libroExcel = excelApp.Workbooks.Add
        hoja = CType(libroExcel.Sheets("Hoja1"), Excel.Worksheet)
        hoja.Range("A1").Resize(1, cabecera.Length).Value = cabecera
        For fila = 0 To datosTab.Rows.Count - 1
            For columna = 0 To datosTab.Columns.Count - 1
                hoja.Cells(fila + 2, columna + 1).value = datosTab.Rows(fila).Item(columna)
            Next
        Next
        With hoja.Range("A1:E" & fila)
            .Font.Bold = True
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .ColumnWidth = 30
            .RowHeight = 40
            .Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            .WrapText = True
        End With
        excelApp.Application.DisplayAlerts = False
        libroExcel.SaveAs(direccion)
        libroExcel.Close()
        excelApp.Workbooks.Close()
        excelApp.Quit()
        'Cierra el procesos Excel que le indiquemos
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
    End Sub
End Class
