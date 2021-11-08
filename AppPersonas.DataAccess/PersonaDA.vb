Imports System.Data
Imports System.Data.SqlClient
Imports AppPersonas.Entities

Public Class PersonaDA
    Inherits BaseDA

    Public Shared Function CreatePersona(persona As PersonaEntity) As Integer

        Dim existe As Integer

        Using conexion As New SqlConnection(connectionString)

            conexion.Open()

            Dim sqlCheckDuplicate As String = "SELECT COUNT(DOCUMENTO) FROM Personas WHERE DOCUMENTO = @doc"
            Using comandoCheck As New SqlCommand(sqlCheckDuplicate, conexion)
                comandoCheck.Parameters.AddWithValue("@doc", persona.DOCUMENTO)

                Dim checkResult As String = CStr(comandoCheck.ExecuteScalar)

                If CDbl(checkResult) = 0 Then

                    Dim sqlInsertPersona As String = "INSERT INTO Personas(NOMBRE, APELLIDO, DOCUMENTO, TIPO_DOCUMENTO, ESTADO, EDAD) VALUES(@nombre, @apellido, @documento, @tipo_documento, @estado, @edad) SELECT SCOPE_IDENTITY()"
                    Dim comando As New SqlCommand(sqlInsertPersona, conexion)

                    comando.Parameters.AddWithValue("@nombre", persona.NOMBRE)
                    comando.Parameters.AddWithValue("@apellido", persona.APELLIDO)
                    comando.Parameters.AddWithValue("@documento", persona.DOCUMENTO)
                    comando.Parameters.AddWithValue("@tipo_documento", persona.TIPO_DOCUMENTO)
                    comando.Parameters.AddWithValue("@estado", persona.ESTADO)
                    comando.Parameters.AddWithValue("@edad", persona.EDAD)

                    persona.ID = comando.ExecuteScalar()

                    If (persona.ID > 0) Then

                        existe = 0

                    End If

                Else

                    existe = 1

                End If
            End Using

        End Using

        Return existe

    End Function


    Public Shared Function UpdatePersona(persona As PersonaEntity) As Integer

        Dim actualizado As Integer

        Using conexion As New SqlConnection(connectionString)

            conexion.Open()

            Dim sqlUpdatePersona As String = "UPDATE Personas " &
                                            "SET NOMBRE=@nombre, APELLIDO = @apellido, DOCUMENTO = @documento," &
                                            "TIPO_DOCUMENTO = @tipo_documento, ESTADO = @estado, EDAD = @edad " &
                                            "WHERE ID = @id"
            Dim comando As New SqlCommand(sqlUpdatePersona, conexion)

            comando.Parameters.AddWithValue("@nombre", persona.NOMBRE)
            comando.Parameters.AddWithValue("@apellido", persona.APELLIDO)
            comando.Parameters.AddWithValue("@documento", persona.DOCUMENTO)
            comando.Parameters.AddWithValue("@tipo_documento", persona.TIPO_DOCUMENTO)
            comando.Parameters.AddWithValue("@estado", persona.ESTADO)
            comando.Parameters.AddWithValue("@edad", persona.EDAD)
            comando.Parameters.AddWithValue("@id", persona.ID)

            comando.ExecuteNonQuery()

            actualizado = 3

        End Using

        Return actualizado

    End Function


    Public Shared Function GetPersonaById(id As Integer) As PersonaEntity

        Dim persona As PersonaEntity = Nothing

        Using conexion As New SqlConnection(connectionString)

            conexion.Open()

            Dim sqlSearchPersonaByName As String = "SELECT * FROM Personas" &
                                            "WHERE ID=@id"
            Dim comando As New SqlCommand(sqlSearchPersonaByName, conexion)
            comando.Parameters.AddWithValue("@id", id)
            Dim lector As SqlDataReader = comando.ExecuteReader()
            If lector.Read() Then
                persona = ConvertToObject(lector)
            End If

        End Using
        Return persona
    End Function

    Public Shared Function GetAllPersonas() As List(Of PersonaEntity)

        Dim lista As New List(Of PersonaEntity)

        Using conexion As New SqlConnection(connectionString)

            conexion.Open()

            Dim sqlGetAll As String = "SELECT * FROM Personas ORDER BY NOMBRE"
            Dim comando As New SqlCommand(sqlGetAll, conexion)
            Dim lector As SqlDataReader = comando.ExecuteReader()
            While lector.Read()
                lista.Add(ConvertToObject(lector))
            End While
        End Using

        Return lista

    End Function

    Public Shared Function SearchPersonaByCriteria(nombre As String, apellido As String, documento As String) As List(Of PersonaEntity)

        Dim lista As New List(Of PersonaEntity)

        Using conexion As New SqlConnection(connectionString)

            conexion.Open()

            Dim sqlSearchPersonaByName As String = "SELECT * FROM Personas " &
                                            "WHERE NOMBRE LIKE '" & nombre & "' OR APELLIDO LIKE '" & apellido & "' OR DOCUMENTO LIKE '" & documento & "' ORDER BY NOMBRE"
            Dim comando As New SqlCommand(sqlSearchPersonaByName, conexion)

            Dim lector As SqlDataReader = comando.ExecuteReader()
            While lector.Read()
                lista.Add(ConvertToObject(lector))
            End While
        End Using

        Return lista
    End Function


    Private Shared Function ConvertToObject(lector As IDataReader) As PersonaEntity

        Dim persona As New PersonaEntity()

        persona.ID = lector("ID")
        persona.NOMBRE = lector("NOMBRE")
        persona.APELLIDO = lector("APELLIDO")
        persona.DOCUMENTO = lector("DOCUMENTO")
        persona.TIPO_DOCUMENTO = lector("TIPO_DOCUMENTO")
        persona.ESTADO = lector("ESTADO")
        persona.EDAD = lector("EDAD")

        Return persona

    End Function



    Public Shared Function DeletePersona(id As Integer) As Boolean

        Dim isDeleted As Boolean

        Using conexion As New SqlConnection(connectionString)

            conexion.Open()

            Dim sqlDeletePersona = "DELETE FROM Personas WHERE ID = @id"
            Dim comando As New SqlCommand(sqlDeletePersona, conexion)
            comando.Parameters.AddWithValue("@id", id)

            isDeleted = comando.ExecuteNonQuery() > 0

        End Using

        Return isDeleted

    End Function


End Class
