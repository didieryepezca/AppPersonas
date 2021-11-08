<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtDocument = New System.Windows.Forms.TextBox()
        Me.cbDocumentType = New System.Windows.Forms.ComboBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(173, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(100, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(94, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(59, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOCUMENTO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TIPO DOCUMENTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(110, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ESTADO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(132, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "EDAD:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(210, 31)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(67, 27)
        Me.txtId.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(210, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(289, 27)
        Me.txtName.TabIndex = 8
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(210, 105)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(289, 27)
        Me.txtSurname.TabIndex = 9
        '
        'txtDocument
        '
        Me.txtDocument.Location = New System.Drawing.Point(210, 148)
        Me.txtDocument.Name = "txtDocument"
        Me.txtDocument.Size = New System.Drawing.Size(289, 27)
        Me.txtDocument.TabIndex = 10
        '
        'cbDocumentType
        '
        Me.cbDocumentType.DisplayMember = "Seleccione"
        Me.cbDocumentType.FormattingEnabled = True
        Me.cbDocumentType.Items.AddRange(New Object() {"DNI", "PASAPORTE", "BREVETE"})
        Me.cbDocumentType.Location = New System.Drawing.Point(211, 193)
        Me.cbDocumentType.Name = "cbDocumentType"
        Me.cbDocumentType.Size = New System.Drawing.Size(288, 28)
        Me.cbDocumentType.TabIndex = 11
        Me.cbDocumentType.Tag = ""
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"ACTIVO", "INACTIVO"})
        Me.cbStatus.Location = New System.Drawing.Point(210, 232)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(288, 28)
        Me.cbStatus.TabIndex = 12
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(210, 277)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(125, 27)
        Me.txtAge.TabIndex = 13
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.Location = New System.Drawing.Point(210, 330)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(83, 39)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(384, 330)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 39)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(300, 330)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(78, 39)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'frmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 391)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.cbDocumentType)
        Me.Controls.Add(Me.txtDocument)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersona"
        Me.Text = "Mantenimiento de Persona"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtDocument As TextBox
    Friend WithEvents cbDocumentType As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
End Class
