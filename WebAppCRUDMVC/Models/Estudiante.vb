Imports System.ComponentModel.DataAnnotations.Schema

Public Enum cursos
    DAM
    DAW
    SMIR
    ASIR
End Enum
Public Class Estudiante
    Public Property ID As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Curso As cursos
    Public Property FechaInicio As DateTime
End Class
