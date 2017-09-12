<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPrincipal))
        Me.gbVisualizacion = New System.Windows.Forms.GroupBox()
        Me.dgvPrincVisualizar = New System.Windows.Forms.DataGridView()
        Me.gbPrincFiltrado = New System.Windows.Forms.GroupBox()
        Me.dtpFechaLLamada1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblFiltTotal = New System.Windows.Forms.Label()
        Me.dtpFechaLLam = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btPrincFiltLimpiar = New System.Windows.Forms.Button()
        Me.tbPrincFiltDireccion = New System.Windows.Forms.TextBox()
        Me.tbPrincFiltEmpresa = New System.Windows.Forms.TextBox()
        Me.rtbPrincFiltComentarios = New System.Windows.Forms.RichTextBox()
        Me.tbPrincFiltTelefono = New System.Windows.Forms.TextBox()
        Me.tbPrincFiltNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.gbPrincEdicion = New System.Windows.Forms.GroupBox()
        Me.dtpFechaLLam1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btPrincActualizar = New System.Windows.Forms.Button()
        Me.btPrincCerrar = New System.Windows.Forms.Button()
        Me.btPrincEdLimpiar = New System.Windows.Forms.Button()
        Me.btPrincEdBorrar = New System.Windows.Forms.Button()
        Me.btPrincEdGuardar = New System.Windows.Forms.Button()
        Me.tbPrinEdDireccion = New System.Windows.Forms.TextBox()
        Me.tbPrinEdEmpresa = New System.Windows.Forms.TextBox()
        Me.rtbPrinEdComentarios = New System.Windows.Forms.RichTextBox()
        Me.tbPrinEdTelefono = New System.Windows.Forms.TextBox()
        Me.tbPrinEdNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tsPrincipal = New System.Windows.Forms.ToolStrip()
        Me.btTsPrinInforme = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btPrinCopSeg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.gbVisualizacion.SuspendLayout()
        CType(Me.dgvPrincVisualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPrincFiltrado.SuspendLayout()
        Me.gbPrincEdicion.SuspendLayout()
        Me.tsPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbVisualizacion
        '
        Me.gbVisualizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbVisualizacion.Controls.Add(Me.dgvPrincVisualizar)
        Me.gbVisualizacion.Location = New System.Drawing.Point(12, 35)
        Me.gbVisualizacion.Name = "gbVisualizacion"
        Me.gbVisualizacion.Size = New System.Drawing.Size(785, 259)
        Me.gbVisualizacion.TabIndex = 0
        Me.gbVisualizacion.TabStop = False
        Me.gbVisualizacion.Text = "Visualización"
        '
        'dgvPrincVisualizar
        '
        Me.dgvPrincVisualizar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPrincVisualizar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrincVisualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrincVisualizar.Location = New System.Drawing.Point(11, 17)
        Me.dgvPrincVisualizar.Name = "dgvPrincVisualizar"
        Me.dgvPrincVisualizar.Size = New System.Drawing.Size(764, 231)
        Me.dgvPrincVisualizar.TabIndex = 0
        '
        'gbPrincFiltrado
        '
        Me.gbPrincFiltrado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPrincFiltrado.Controls.Add(Me.dtpFechaLLamada1)
        Me.gbPrincFiltrado.Controls.Add(Me.Label13)
        Me.gbPrincFiltrado.Controls.Add(Me.lblFiltTotal)
        Me.gbPrincFiltrado.Controls.Add(Me.dtpFechaLLam)
        Me.gbPrincFiltrado.Controls.Add(Me.Label10)
        Me.gbPrincFiltrado.Controls.Add(Me.btPrincFiltLimpiar)
        Me.gbPrincFiltrado.Controls.Add(Me.tbPrincFiltDireccion)
        Me.gbPrincFiltrado.Controls.Add(Me.tbPrincFiltEmpresa)
        Me.gbPrincFiltrado.Controls.Add(Me.rtbPrincFiltComentarios)
        Me.gbPrincFiltrado.Controls.Add(Me.tbPrincFiltTelefono)
        Me.gbPrincFiltrado.Controls.Add(Me.tbPrincFiltNombre)
        Me.gbPrincFiltrado.Controls.Add(Me.Label5)
        Me.gbPrincFiltrado.Controls.Add(Me.Label4)
        Me.gbPrincFiltrado.Controls.Add(Me.Label3)
        Me.gbPrincFiltrado.Controls.Add(Me.Label2)
        Me.gbPrincFiltrado.Controls.Add(Me.lblNombre)
        Me.gbPrincFiltrado.Location = New System.Drawing.Point(0, 300)
        Me.gbPrincFiltrado.Name = "gbPrincFiltrado"
        Me.gbPrincFiltrado.Size = New System.Drawing.Size(812, 155)
        Me.gbPrincFiltrado.TabIndex = 1
        Me.gbPrincFiltrado.TabStop = False
        Me.gbPrincFiltrado.Text = "Filtros"
        '
        'dtpFechaLLamada1
        '
        Me.dtpFechaLLamada1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLLamada1.Location = New System.Drawing.Point(222, 108)
        Me.dtpFechaLLamada1.Name = "dtpFechaLLamada1"
        Me.dtpFechaLLamada1.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaLLamada1.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(204, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "y"
        '
        'lblFiltTotal
        '
        Me.lblFiltTotal.AutoSize = True
        Me.lblFiltTotal.Location = New System.Drawing.Point(19, 138)
        Me.lblFiltTotal.Name = "lblFiltTotal"
        Me.lblFiltTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblFiltTotal.TabIndex = 12
        '
        'dtpFechaLLam
        '
        Me.dtpFechaLLam.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLLam.Location = New System.Drawing.Point(114, 107)
        Me.dtpFechaLLam.Name = "dtpFechaLLam"
        Me.dtpFechaLLam.Size = New System.Drawing.Size(84, 20)
        Me.dtpFechaLLam.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Fecha llamada entre"
        '
        'btPrincFiltLimpiar
        '
        Me.btPrincFiltLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btPrincFiltLimpiar.Location = New System.Drawing.Point(354, 130)
        Me.btPrincFiltLimpiar.Name = "btPrincFiltLimpiar"
        Me.btPrincFiltLimpiar.Size = New System.Drawing.Size(136, 21)
        Me.btPrincFiltLimpiar.TabIndex = 10
        Me.btPrincFiltLimpiar.Text = "Limpiar Filtros"
        Me.btPrincFiltLimpiar.UseVisualStyleBackColor = True
        '
        'tbPrincFiltDireccion
        '
        Me.tbPrincFiltDireccion.Location = New System.Drawing.Point(114, 74)
        Me.tbPrincFiltDireccion.Name = "tbPrincFiltDireccion"
        Me.tbPrincFiltDireccion.Size = New System.Drawing.Size(192, 20)
        Me.tbPrincFiltDireccion.TabIndex = 8
        '
        'tbPrincFiltEmpresa
        '
        Me.tbPrincFiltEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPrincFiltEmpresa.Location = New System.Drawing.Point(604, 32)
        Me.tbPrincFiltEmpresa.Name = "tbPrincFiltEmpresa"
        Me.tbPrincFiltEmpresa.Size = New System.Drawing.Size(189, 20)
        Me.tbPrincFiltEmpresa.TabIndex = 7
        '
        'rtbPrincFiltComentarios
        '
        Me.rtbPrincFiltComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPrincFiltComentarios.Location = New System.Drawing.Point(383, 71)
        Me.rtbPrincFiltComentarios.Name = "rtbPrincFiltComentarios"
        Me.rtbPrincFiltComentarios.Size = New System.Drawing.Size(422, 49)
        Me.rtbPrincFiltComentarios.TabIndex = 9
        Me.rtbPrincFiltComentarios.Text = ""
        '
        'tbPrincFiltTelefono
        '
        Me.tbPrincFiltTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPrincFiltTelefono.Location = New System.Drawing.Point(383, 32)
        Me.tbPrincFiltTelefono.Name = "tbPrincFiltTelefono"
        Me.tbPrincFiltTelefono.Size = New System.Drawing.Size(164, 20)
        Me.tbPrincFiltTelefono.TabIndex = 6
        '
        'tbPrincFiltNombre
        '
        Me.tbPrincFiltNombre.Location = New System.Drawing.Point(114, 32)
        Me.tbPrincFiltNombre.Name = "tbPrincFiltNombre"
        Me.tbPrincFiltNombre.Size = New System.Drawing.Size(192, 20)
        Me.tbPrincFiltNombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Comentarios"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(550, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Empresa"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirección"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(54, 35)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'gbPrincEdicion
        '
        Me.gbPrincEdicion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbPrincEdicion.Controls.Add(Me.dtpFechaLLam1)
        Me.gbPrincEdicion.Controls.Add(Me.Label11)
        Me.gbPrincEdicion.Controls.Add(Me.btPrincActualizar)
        Me.gbPrincEdicion.Controls.Add(Me.btPrincCerrar)
        Me.gbPrincEdicion.Controls.Add(Me.btPrincEdLimpiar)
        Me.gbPrincEdicion.Controls.Add(Me.btPrincEdBorrar)
        Me.gbPrincEdicion.Controls.Add(Me.btPrincEdGuardar)
        Me.gbPrincEdicion.Controls.Add(Me.tbPrinEdDireccion)
        Me.gbPrincEdicion.Controls.Add(Me.tbPrinEdEmpresa)
        Me.gbPrincEdicion.Controls.Add(Me.rtbPrinEdComentarios)
        Me.gbPrincEdicion.Controls.Add(Me.tbPrinEdTelefono)
        Me.gbPrincEdicion.Controls.Add(Me.tbPrinEdNombre)
        Me.gbPrincEdicion.Controls.Add(Me.Label1)
        Me.gbPrincEdicion.Controls.Add(Me.Label6)
        Me.gbPrincEdicion.Controls.Add(Me.Label7)
        Me.gbPrincEdicion.Controls.Add(Me.Label8)
        Me.gbPrincEdicion.Controls.Add(Me.Label9)
        Me.gbPrincEdicion.Location = New System.Drawing.Point(0, 461)
        Me.gbPrincEdicion.Name = "gbPrincEdicion"
        Me.gbPrincEdicion.Size = New System.Drawing.Size(819, 162)
        Me.gbPrincEdicion.TabIndex = 2
        Me.gbPrincEdicion.TabStop = False
        Me.gbPrincEdicion.Text = "Edición"
        '
        'dtpFechaLLam1
        '
        Me.dtpFechaLLam1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaLLam1.Location = New System.Drawing.Point(136, 107)
        Me.dtpFechaLLam1.Name = "dtpFechaLLam1"
        Me.dtpFechaLLam1.Size = New System.Drawing.Size(158, 20)
        Me.dtpFechaLLam1.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Fecha llamada"
        '
        'btPrincActualizar
        '
        Me.btPrincActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btPrincActualizar.Location = New System.Drawing.Point(183, 135)
        Me.btPrincActualizar.Name = "btPrincActualizar"
        Me.btPrincActualizar.Size = New System.Drawing.Size(136, 21)
        Me.btPrincActualizar.TabIndex = 14
        Me.btPrincActualizar.Text = "Actualizar Registro"
        Me.btPrincActualizar.UseVisualStyleBackColor = True
        '
        'btPrincCerrar
        '
        Me.btPrincCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btPrincCerrar.Location = New System.Drawing.Point(657, 135)
        Me.btPrincCerrar.Name = "btPrincCerrar"
        Me.btPrincCerrar.Size = New System.Drawing.Size(136, 21)
        Me.btPrincCerrar.TabIndex = 13
        Me.btPrincCerrar.Text = "Cerrar Aplicación"
        Me.btPrincCerrar.UseVisualStyleBackColor = True
        '
        'btPrincEdLimpiar
        '
        Me.btPrincEdLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btPrincEdLimpiar.Location = New System.Drawing.Point(503, 135)
        Me.btPrincEdLimpiar.Name = "btPrincEdLimpiar"
        Me.btPrincEdLimpiar.Size = New System.Drawing.Size(136, 21)
        Me.btPrincEdLimpiar.TabIndex = 12
        Me.btPrincEdLimpiar.Text = "Limpiar Edición"
        Me.btPrincEdLimpiar.UseVisualStyleBackColor = True
        '
        'btPrincEdBorrar
        '
        Me.btPrincEdBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btPrincEdBorrar.Location = New System.Drawing.Point(341, 135)
        Me.btPrincEdBorrar.Name = "btPrincEdBorrar"
        Me.btPrincEdBorrar.Size = New System.Drawing.Size(136, 21)
        Me.btPrincEdBorrar.TabIndex = 11
        Me.btPrincEdBorrar.Text = "Borrar Registro"
        Me.btPrincEdBorrar.UseVisualStyleBackColor = True
        '
        'btPrincEdGuardar
        '
        Me.btPrincEdGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btPrincEdGuardar.Location = New System.Drawing.Point(31, 135)
        Me.btPrincEdGuardar.Name = "btPrincEdGuardar"
        Me.btPrincEdGuardar.Size = New System.Drawing.Size(136, 21)
        Me.btPrincEdGuardar.TabIndex = 10
        Me.btPrincEdGuardar.Text = "Guardar Registro"
        Me.btPrincEdGuardar.UseVisualStyleBackColor = True
        '
        'tbPrinEdDireccion
        '
        Me.tbPrinEdDireccion.Location = New System.Drawing.Point(136, 74)
        Me.tbPrinEdDireccion.Name = "tbPrinEdDireccion"
        Me.tbPrinEdDireccion.Size = New System.Drawing.Size(158, 20)
        Me.tbPrinEdDireccion.TabIndex = 8
        '
        'tbPrinEdEmpresa
        '
        Me.tbPrinEdEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPrinEdEmpresa.Location = New System.Drawing.Point(611, 32)
        Me.tbPrinEdEmpresa.Name = "tbPrinEdEmpresa"
        Me.tbPrinEdEmpresa.Size = New System.Drawing.Size(189, 20)
        Me.tbPrinEdEmpresa.TabIndex = 7
        '
        'rtbPrinEdComentarios
        '
        Me.rtbPrinEdComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbPrinEdComentarios.Location = New System.Drawing.Point(371, 71)
        Me.rtbPrinEdComentarios.Name = "rtbPrinEdComentarios"
        Me.rtbPrinEdComentarios.Size = New System.Drawing.Size(429, 49)
        Me.rtbPrinEdComentarios.TabIndex = 9
        Me.rtbPrinEdComentarios.Text = ""
        '
        'tbPrinEdTelefono
        '
        Me.tbPrinEdTelefono.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPrinEdTelefono.Location = New System.Drawing.Point(372, 32)
        Me.tbPrinEdTelefono.Name = "tbPrinEdTelefono"
        Me.tbPrinEdTelefono.Size = New System.Drawing.Size(171, 20)
        Me.tbPrinEdTelefono.TabIndex = 6
        '
        'tbPrinEdNombre
        '
        Me.tbPrinEdNombre.Location = New System.Drawing.Point(136, 32)
        Me.tbPrinEdNombre.Name = "tbPrinEdNombre"
        Me.tbPrinEdNombre.Size = New System.Drawing.Size(158, 20)
        Me.tbPrinEdNombre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Comentarios"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(557, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Empresa"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Dirección"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre"
        '
        'tsPrincipal
        '
        Me.tsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btTsPrinInforme, Me.ToolStripLabel1, Me.btPrinCopSeg, Me.ToolStripLabel3, Me.ToolStripButton1, Me.ToolStripLabel2})
        Me.tsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tsPrincipal.Name = "tsPrincipal"
        Me.tsPrincipal.Size = New System.Drawing.Size(812, 25)
        Me.tsPrincipal.TabIndex = 3
        Me.tsPrincipal.Text = "ToolStrip1"
        '
        'btTsPrinInforme
        '
        Me.btTsPrinInforme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btTsPrinInforme.Image = CType(resources.GetObject("btTsPrinInforme.Image"), System.Drawing.Image)
        Me.btTsPrinInforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btTsPrinInforme.Name = "btTsPrinInforme"
        Me.btTsPrinInforme.Size = New System.Drawing.Size(23, 22)
        Me.btTsPrinInforme.Text = "Generar infome"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "Generar informe"
        '
        'btPrinCopSeg
        '
        Me.btPrinCopSeg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btPrinCopSeg.Image = CType(resources.GetObject("btPrinCopSeg.Image"), System.Drawing.Image)
        Me.btPrinCopSeg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btPrinCopSeg.Name = "btPrinCopSeg"
        Me.btPrinCopSeg.Size = New System.Drawing.Size(23, 22)
        Me.btPrinCopSeg.Text = "ToolStripButton2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripLabel3.Text = "Copia Seguridad"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripLabel2.Text = "Cerrar Aplicación"
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Location = New System.Drawing.Point(9, 634)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(28, 13)
        Me.lblOperacion.TabIndex = 4
        Me.lblOperacion.Text = " aaa"
        '
        'fPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 656)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.tsPrincipal)
        Me.Controls.Add(Me.gbPrincEdicion)
        Me.Controls.Add(Me.gbPrincFiltrado)
        Me.Controls.Add(Me.gbVisualizacion)
        Me.Name = "fPrincipal"
        Me.Text = "Principal"
        Me.gbVisualizacion.ResumeLayout(False)
        CType(Me.dgvPrincVisualizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPrincFiltrado.ResumeLayout(False)
        Me.gbPrincFiltrado.PerformLayout()
        Me.gbPrincEdicion.ResumeLayout(False)
        Me.gbPrincEdicion.PerformLayout()
        Me.tsPrincipal.ResumeLayout(False)
        Me.tsPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbVisualizacion As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPrincVisualizar As System.Windows.Forms.DataGridView
    Friend WithEvents gbPrincFiltrado As System.Windows.Forms.GroupBox
    Friend WithEvents btPrincFiltLimpiar As System.Windows.Forms.Button
    Friend WithEvents tbPrincFiltDireccion As System.Windows.Forms.TextBox
    Friend WithEvents tbPrincFiltEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents rtbPrincFiltComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents tbPrincFiltTelefono As System.Windows.Forms.TextBox
    Friend WithEvents tbPrincFiltNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents gbPrincEdicion As System.Windows.Forms.GroupBox
    Friend WithEvents btPrincEdGuardar As System.Windows.Forms.Button
    Friend WithEvents tbPrinEdDireccion As System.Windows.Forms.TextBox
    Friend WithEvents tbPrinEdEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents rtbPrinEdComentarios As System.Windows.Forms.RichTextBox
    Friend WithEvents tbPrinEdTelefono As System.Windows.Forms.TextBox
    Friend WithEvents tbPrinEdNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btPrincEdLimpiar As System.Windows.Forms.Button
    Friend WithEvents btPrincEdBorrar As System.Windows.Forms.Button
    Friend WithEvents btPrincCerrar As System.Windows.Forms.Button
    Friend WithEvents btPrincActualizar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaLLam As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFiltTotal As System.Windows.Forms.Label
    Friend WithEvents dtpFechaLLam1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tsPrincipal As System.Windows.Forms.ToolStrip
    Friend WithEvents btTsPrinInforme As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents dtpFechaLLamada1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btPrinCopSeg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblOperacion As System.Windows.Forms.Label

End Class
