Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions

Public Class ClasesContext
    Inherits DbContext
    Public Sub New()
        MyBase.New("ClasesContext")
    End Sub
    Public Property Estudiantes As DbSet(Of Estudiante)
    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
    End Sub
End Class
