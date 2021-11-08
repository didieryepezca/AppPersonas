Imports System.Data.SqlClient
Imports AppPersonas.BusinessLogic
Imports AppPersonas.Entities

Public Class frmPersona
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        '--------------------------------
        If Not ValidarDatos() Then
            Exit Sub
        End If

        '--------------------------------
        Dim objectPersona As New PersonaEntity

        objectPersona.ID = Me.txtId.Text
        objectPersona.NOMBRE = Me.txtName.Text
        objectPersona.APELLIDO = Me.txtSurname.Text
        objectPersona.DOCUMENTO = Me.txtDocument.Text
        objectPersona.TIPO_DOCUMENTO = Me.cbDocumentType.Text
        objectPersona.ESTADO = Me.cbStatus.Text
        objectPersona.EDAD = Me.txtAge.Text

        '--------------------------------

        Dim frmMain = New Form1()
        Try

            Dim result = PersonaBL.Save(objectPersona)

            If (result = 0) Then

                frmMain.WriteDataLog("Se Registro una persona", "Se ingreso el documento N°=" & Me.txtDocument.Text & "Nombres=" & Me.txtName.Text)
                MessageBox.Show("Se guardó la persona.",
                            "Mantenimiento de Persona",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            ElseIf (result = 1) Then
                frmMain.WriteDataLog("Se Detectó una persona ya Registrada", "Se detecto persona existente con el documento N°=" & Me.txtDocument.Text & "Nombres=" & Me.txtName.Text)
                MessageBox.Show("La persona ya está registrada en nuestra base de datos.",
                           "Mantenimiento de Persona",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information)

            ElseIf (result = 3) Then
                frmMain.WriteDataLog("Se Actualizó una persona", "Se actualizó con el documento N°=" & Me.txtDocument.Text & "Nombres=" & Me.txtName.Text)
                MessageBox.Show("Se actualizaron los datos de la Persona.",
                           "Mantenimiento de Persona",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information)
            End If

            Me.txtId.Text = "0"
            Me.txtName.Clear()
            Me.txtSurname.Clear()
            Me.txtDocument.Clear()
            Me.txtAge.Clear()

            Me.Close()

        Catch ex As Exception
            frmMain.WriteDataLog("Hubo un error", ex.Message & " al realizar mant. de Persona con doc. N°=" & Me.txtDocument.Text & "Nombres=" & Me.txtName.Text)
            MessageBox.Show(ex.Message,
                            "Mantenimiento de Persona",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean

        Dim resultado As Boolean = True

        ErrorProvider.Clear()

        If String.IsNullOrEmpty(txtName.Text) Then
            ErrorProvider.SetError(txtName, "El nombre es obligatorio")
            resultado = False

        ElseIf String.IsNullOrEmpty(txtSurname.Text) Then
            ErrorProvider.SetError(txtSurname, "El Apellido es obligatorio")
            resultado = False

        ElseIf String.IsNullOrEmpty(txtDocument.Text) Then
            ErrorProvider.SetError(txtDocument, "El Documento es obligatorio")
            resultado = False

        ElseIf String.IsNullOrEmpty(cbDocumentType.Text) Then
            ErrorProvider.SetError(cbDocumentType, "El Tipo de Documento es obligatorio")
            resultado = False

        ElseIf String.IsNullOrEmpty(cbStatus.Text) Then
            ErrorProvider.SetError(cbStatus, "El Estado es obligatorio")
            resultado = False

        ElseIf Len(txtAge.Text & "") = 0 Then
            ErrorProvider.SetError(txtAge, "La edad es obligatoria")
            resultado = False

        End If

        Return resultado
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtAge_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAge.KeyUp

        Dim isDigit As Boolean = Char.IsDigit(ChrW(e.KeyValue))
        Dim isKeypadNum As Boolean = e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9
        Dim isBackOrSlashOrPeriod As Boolean = (e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.Oem2 Or e.KeyCode = Keys.Back Or e.KeyCode = Keys.OemPeriod)

        If Not (isDigit Or isKeypadNum Or isBackOrSlashOrPeriod) Then
            MessageBox.Show("No has tipeado un número !",
                            "Gestión de Personas ",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            txtAge.Clear()
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim idPersona = txtId.Text
        Dim frmMain = New Form1()

        Try
            PersonaBL.Delete(idPersona)
            frmMain.WriteDataLog("Se elimino una persona", " Se elimino la persona con el Id:" & idPersona)
            MessageBox.Show("Persona eliminada",
                            "Mantenimiento de Persona",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            Me.Close()

        Catch ex As Exception

            frmMain.WriteDataLog("Error al eliminar una persona.", " Se elimino la persona con el Id:" & idPersona)
            MessageBox.Show(ex.Message,
                           "Mantenimiento de Persona",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)

        End Try
    End Sub



End Class