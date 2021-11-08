Imports System.Data.SqlClient
Imports System.IO
Imports AppPersonas.BusinessLogic
Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Interop.Excel

Public Class Form1

    <STAThread()>
    Shared Sub Main()

        Dim mainFrm As New Form1()
        mainFrm.Show()

        Application.Run(mainFrm)

    End Sub

    Private Sub btnKillApp_Click(sender As Object, e As EventArgs) Handles btnKillApp.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDataGridView()

    End Sub

    Private Sub FillDataGridView()

        Me.dgvPersonas.DataSource = PersonaBL.GetAllPersonas

    End Sub

    Private Sub dgvPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellClick

        '---------------- Detecto datos.
        If e.RowIndex = -1 Then
            Exit Sub
        End If


        Dim fila As DataGridViewRow = Me.dgvPersonas.CurrentRow

        Dim formPersona = New frmPersona()
        formPersona.Show()

        formPersona.txtId.Text = fila.Cells("IDcol").Value
        formPersona.txtName.Text = fila.Cells("NOMBREcol").Value
        formPersona.txtSurname.Text = fila.Cells("APELLIDOcol").Value
        formPersona.txtDocument.Text = fila.Cells("DOCUMENTOcol").Value
        formPersona.cbDocumentType.Text = fila.Cells("TIPO_DOCUMENTOcol").Value
        formPersona.cbStatus.Text = fila.Cells("ESTADOcol").Value
        formPersona.txtAge.Text = fila.Cells("EDADcol").Value

        formPersona.btnGuardar.Text = "Actualizar"
        formPersona.btnEliminar.Visible = True

    End Sub

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click

        Dim formPersona = New frmPersona()
        formPersona.Show()

        formPersona.txtId.Text = "0"
        formPersona.txtName.Clear()
        formPersona.txtSurname.Clear()
        formPersona.txtDocument.Clear()
        formPersona.txtAge.Clear()

    End Sub

    Private Sub btnRefreshData_Click(sender As Object, e As EventArgs) Handles btnRefreshData.Click
        FillDataGridView()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim sName = txtSearchName.Text
        Dim sApellido = txtSearchApellidos.Text
        Dim sDocumento = txtSearchDocumento.Text

        If Len(sName & "") = 0 And Len(sApellido & "") = 0 And Len(sDocumento & "") = 0 Then

            MessageBox.Show("Debes ingresar al menos un criterio para la búsqueda.",
                            "Gestión de Personas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            WriteDataLog("Se realizó una búsqueda", "Aplicando filtros con los valores de Nombre=" & sName & "Apellido=" & sApellido & "Documento=" & sDocumento)
            Me.dgvPersonas.DataSource = PersonaBL.GetPersonaByCriteria(sName, sApellido, sDocumento)

        End If

    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click

        Dim dataAdapter As New SqlClient.SqlDataAdapter()
        Dim dataSet As New DataSet
        Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        Dim connection As New SqlClient.SqlConnection

        connection.ConnectionString = "Data Source = DIDIERYEPEZ; Initial Catalog = PersonasApplication; Integrated Security = true"
        command.Connection = connection
        command.CommandType = CommandType.Text

        command.CommandText = "SELECT * FROM Personas"
        dataAdapter.SelectCommand = command


        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        Try
            If f.ShowDialog() = DialogResult.OK Then

                System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
                Dim oExcel As Excel.Application
                Dim oBook As Excel.Workbook
                Dim oSheet As Excel.Worksheet
                oExcel = CreateObject("Excel.Application")
                oBook = oExcel.Workbooks.Add(Type.Missing)
                oSheet = oBook.Worksheets(1)

                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0


                connection.Open()
                dataAdapter.Fill(datatableMain)
                connection.Close()

                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(1, colIndex) = dc.ColumnName
                Next


                For Each dr In datatableMain.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In datatableMain.Columns
                        colIndex = colIndex + 1
                        oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next

                Dim fileName As String = "\DataPersonas" + ".xls"
                Dim finalPath = f.SelectedPath + fileName
                txtPath.Text = finalPath
                oSheet.Columns.AutoFit()

                oBook.SaveAs(finalPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)


                ReleaseObject(oSheet)
                oBook.Close(False, Type.Missing, Type.Missing)
                ReleaseObject(oBook)
                oExcel.Quit()
                ReleaseObject(oExcel)

                GC.Collect()

                WriteDataLog("Exportado de datos a Excel", "Utilizando el boton de la pantalla principal")
                MessageBox.Show("Se exportó correctamente tu data en Excel !",
                            "Gestión de Personas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch
        Finally
            o = Nothing
        End Try
    End Sub



    Public Shared Function WriteDataLog(ByVal task As String, ByVal how As String)

        'Ruta estática para guardar los logs.
        'Dim path1 As String = "C:\users\public\PersonasAppLog.txt"

        'Ruta dinámica del proyecto donde se correra la aplicación.
        Dim path1 As String = Application.StartupPath & "\PersonasAppLog.txt"

        Dim fullPath As String
        fullPath = Path.GetFullPath(path1)
        Dim fileExists As Boolean = File.Exists(fullPath)

        Try
            Using sw As New StreamWriter(File.Open(fullPath, FileMode.Append))

                sw.WriteLine(vbCrLf) ' linea en blanco de separador
                sw.WriteLine(
            IIf(fileExists,
            "Se realizo la tarea: " & task & " a las (MM/dd/AAAA hh:mm:ss): " & DateTime.Now & "," & how,
            "Se creo nuestro archivo Log"))

            End Using

            MessageBox.Show("Se actualizó el archivo Log en: " & fullPath,
                            "Gestión de Personas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch Ex As Exception

            MessageBox.Show(Ex.Message,
                            "No se pudo crear el archivo de Log",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Function

End Class
