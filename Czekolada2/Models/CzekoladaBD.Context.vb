'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class CzekoladaEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CzekoladaEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Czekolada() As DbSet(Of Czekolada)
    Public Overridable Property Kakao() As DbSet(Of Kakao)
    Public Overridable Property Orzech() As DbSet(Of Orzech)
    Public Overridable Property Owoc() As DbSet(Of Owoc)
    Public Overridable Property Rodzaj_czekolady() As DbSet(Of Rodzaj_czekolady)
    Public Overridable Property Rozmiar_tabliczki() As DbSet(Of Rozmiar_tabliczki)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)

End Class
