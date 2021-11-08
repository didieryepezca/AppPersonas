<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnKillApp = New System.Windows.Forms.Button()
        Me.dgvPersonas = New System.Windows.Forms.DataGridView()
        Me.IDcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBREcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENTOcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_DOCUMENTOcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTADOcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EDADcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCUMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.btnRefreshData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchDocumento = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKillApp
        '
        Me.btnKillApp.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnKillApp.Location = New System.Drawing.Point(1246, 598)
        Me.btnKillApp.Name = "btnKillApp"
        Me.btnKillApp.Size = New System.Drawing.Size(158, 41)
        Me.btnKillApp.TabIndex = 0
        Me.btnKillApp.Text = "Salir"
        Me.btnKillApp.UseVisualStyleBackColor = True
        '
        'dgvPersonas
        '
        Me.dgvPersonas.AllowUserToAddRows = False
        Me.dgvPersonas.AllowUserToDeleteRows = False
        Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDcol, Me.NOMBREcol, Me.APELLIDOcol, Me.DOCUMENTOcol, Me.TIPO_DOCUMENTOcol, Me.ESTADOcol, Me.EDADcol})
        Me.dgvPersonas.Location = New System.Drawing.Point(14, 91)
        Me.dgvPersonas.Name = "dgvPersonas"
        Me.dgvPersonas.ReadOnly = True
        Me.dgvPersonas.RowHeadersWidth = 51
        Me.dgvPersonas.RowTemplate.Height = 29
        Me.dgvPersonas.Size = New System.Drawing.Size(1390, 486)
        Me.dgvPersonas.TabIndex = 1
        '
        'IDcol
        '
        Me.IDcol.DataPropertyName = "ID"
        Me.IDcol.HeaderText = "ID"
        Me.IDcol.MinimumWidth = 6
        Me.IDcol.Name = "IDcol"
        Me.IDcol.ReadOnly = True
        Me.IDcol.Width = 40
        '
        'NOMBREcol
        '
        Me.NOMBREcol.DataPropertyName = "NOMBRE"
        Me.NOMBREcol.HeaderText = "NOMBRE"
        Me.NOMBREcol.MinimumWidth = 6
        Me.NOMBREcol.Name = "NOMBREcol"
        Me.NOMBREcol.ReadOnly = True
        Me.NOMBREcol.Width = 200
        '
        'APELLIDOcol
        '
        Me.APELLIDOcol.DataPropertyName = "APELLIDO"
        Me.APELLIDOcol.HeaderText = "APELLIDO"
        Me.APELLIDOcol.MinimumWidth = 6
        Me.APELLIDOcol.Name = "APELLIDOcol"
        Me.APELLIDOcol.ReadOnly = True
        Me.APELLIDOcol.Width = 250
        '
        'DOCUMENTOcol
        '
        Me.DOCUMENTOcol.DataPropertyName = "DOCUMENTO"
        Me.DOCUMENTOcol.HeaderText = "DOCUMENTO"
        Me.DOCUMENTOcol.MinimumWidth = 6
        Me.DOCUMENTOcol.Name = "DOCUMENTOcol"
        Me.DOCUMENTOcol.ReadOnly = True
        Me.DOCUMENTOcol.Width = 125
        '
        'TIPO_DOCUMENTOcol
        '
        Me.TIPO_DOCUMENTOcol.DataPropertyName = "TIPO_DOCUMENTO"
        Me.TIPO_DOCUMENTOcol.HeaderText = "TIPO_DOCUMENTO"
        Me.TIPO_DOCUMENTOcol.MinimumWidth = 6
        Me.TIPO_DOCUMENTOcol.Name = "TIPO_DOCUMENTOcol"
        Me.TIPO_DOCUMENTOcol.ReadOnly = True
        Me.TIPO_DOCUMENTOcol.Width = 150
        '
        'ESTADOcol
        '
        Me.ESTADOcol.DataPropertyName = "ESTADO"
        Me.ESTADOcol.HeaderText = "ESTADO"
        Me.ESTADOcol.MinimumWidth = 6
        Me.ESTADOcol.Name = "ESTADOcol"
        Me.ESTADOcol.ReadOnly = True
        Me.ESTADOcol.Width = 125
        '
        'EDADcol
        '
        Me.EDADcol.DataPropertyName = "EDAD"
        Me.EDADcol.HeaderText = "EDAD"
        Me.EDADcol.MinimumWidth = 6
        Me.EDADcol.Name = "EDADcol"
        Me.EDADcol.ReadOnly = True
        Me.EDADcol.Width = 125
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.Width = 125
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.MinimumWidth = 6
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.Width = 125
        '
        'APELLIDO
        '
        Me.APELLIDO.DataPropertyName = "APELLIDO"
        Me.APELLIDO.HeaderText = "APELLIDO"
        Me.APELLIDO.MinimumWidth = 6
        Me.APELLIDO.Name = "APELLIDO"
        Me.APELLIDO.Width = 125
        '
        'DOCUMENTO
        '
        Me.DOCUMENTO.DataPropertyName = "DOCUMENTO"
        Me.DOCUMENTO.HeaderText = "DOCUMENTO"
        Me.DOCUMENTO.MinimumWidth = 6
        Me.DOCUMENTO.Name = "DOCUMENTO"
        Me.DOCUMENTO.Width = 125
        '
        'btnNueva
        '
        Me.btnNueva.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNueva.Location = New System.Drawing.Point(14, 22)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(146, 29)
        Me.btnNueva.TabIndex = 2
        Me.btnNueva.Text = "Nueva"
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'btnRefreshData
        '
        Me.btnRefreshData.BackColor = System.Drawing.SystemColors.Info
        Me.btnRefreshData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRefreshData.Location = New System.Drawing.Point(1268, 22)
        Me.btnRefreshData.Name = "btnRefreshData"
        Me.btnRefreshData.Size = New System.Drawing.Size(136, 30)
        Me.btnRefreshData.TabIndex = 3
        Me.btnRefreshData.Text = "Refrescar Tabla"
        Me.btnRefreshData.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(15, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Para modificar los datos de una Persona, haga click en ella."
        '
        'txtSearchName
        '
        Me.txtSearchName.Location = New System.Drawing.Point(429, 24)
        Me.txtSearchName.Name = "txtSearchName"
        Me.txtSearchName.Size = New System.Drawing.Size(170, 27)
        Me.txtSearchName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(340, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(606, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellidos:"
        '
        'txtSearchApellidos
        '
        Me.txtSearchApellidos.Location = New System.Drawing.Point(690, 25)
        Me.txtSearchApellidos.Name = "txtSearchApellidos"
        Me.txtSearchApellidos.Size = New System.Drawing.Size(188, 27)
        Me.txtSearchApellidos.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(893, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Documento:"
        '
        'txtSearchDocumento
        '
        Me.txtSearchDocumento.Location = New System.Drawing.Point(994, 24)
        Me.txtSearchDocumento.Name = "txtSearchDocumento"
        Me.txtSearchDocumento.Size = New System.Drawing.Size(140, 27)
        Me.txtSearchDocumento.TabIndex = 10
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.Location = New System.Drawing.Point(1140, 22)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(122, 30)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExportExcel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnExportExcel.Location = New System.Drawing.Point(1064, 598)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(173, 41)
        Me.btnExportExcel.TabIndex = 12
        Me.btnExportExcel.Text = "Exportar a Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Enabled = False
        Me.txtPath.Location = New System.Drawing.Point(563, 608)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(486, 27)
        Me.txtPath.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(455, 611)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ruta destino:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1412, 649)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtSearchDocumento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearchApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefreshData)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.dgvPersonas)
        Me.Controls.Add(Me.btnKillApp)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Exámen de Didier Yépez Cabanillas - Bienvenido a Gestión de Personas"
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKillApp As Button
    Friend WithEvents dgvPersonas As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDO As DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENTO As DataGridViewTextBoxColumn
    Friend WithEvents IDcol As DataGridViewTextBoxColumn
    Friend WithEvents NOMBREcol As DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOcol As DataGridViewTextBoxColumn
    Friend WithEvents DOCUMENTOcol As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_DOCUMENTOcol As DataGridViewTextBoxColumn
    Friend WithEvents ESTADOcol As DataGridViewTextBoxColumn
    Friend WithEvents EDADcol As DataGridViewTextBoxColumn
    Friend WithEvents btnNueva As Button
    Friend WithEvents btnRefreshData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearchApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearchDocumento As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label5 As Label
End Class
