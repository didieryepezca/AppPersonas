Imports AppPersonas.DataAccess
Imports AppPersonas.Entities

Public Class PersonaBL

    Public Shared Function Save(persona As PersonaEntity)
        If persona.ID = 0 Then
            Return PersonaDA.CreatePersona(persona)
        Else
            Return PersonaDA.UpdatePersona(persona)
        End If
    End Function

    Public Shared Function GetPersonaById(id As Integer) As PersonaEntity

        Return PersonaDA.GetPersonaById(id)

    End Function


    Public Shared Function GetAllPersonas() As List(Of PersonaEntity)

        Return PersonaDA.GetAllPersonas

    End Function

    Public Shared Function GetPersonaByCriteria(nombre As String, apellido As String, documento As String) As List(Of PersonaEntity)

        Return PersonaDA.SearchPersonaByCriteria(nombre, apellido, documento)

    End Function

    Public Shared Function Delete(id As Integer) As Boolean

        Dim deleted As Boolean

        If id > 0 Then

            Return PersonaDA.DeletePersona(id)
            deleted = 1

        End If

        Return deleted

    End Function


End Class
