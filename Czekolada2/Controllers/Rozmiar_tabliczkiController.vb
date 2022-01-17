Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Czekolada2

Namespace Controllers
    Public Class Rozmiar_tabliczkiController
        Inherits System.Web.Mvc.Controller

        Private db As New CzekoladaEntities

        ' GET: Rozmiar_tabliczki
        Function Index() As ActionResult
            Return View(db.Rozmiar_tabliczki.ToList())
        End Function

        ' GET: Rozmiar_tabliczki/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rozmiar_tabliczki As Rozmiar_tabliczki = db.Rozmiar_tabliczki.Find(id)
            If IsNothing(rozmiar_tabliczki) Then
                Return HttpNotFound()
            End If
            Return View(rozmiar_tabliczki)
        End Function

        ' GET: Rozmiar_tabliczki/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Rozmiar_tabliczki/Create
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_rozmiaru,rozmiar_tabliczki1")> ByVal rozmiar_tabliczki As Rozmiar_tabliczki) As ActionResult
            If ModelState.IsValid Then
                db.Rozmiar_tabliczki.Add(rozmiar_tabliczki)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rozmiar_tabliczki)
        End Function

        ' GET: Rozmiar_tabliczki/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rozmiar_tabliczki As Rozmiar_tabliczki = db.Rozmiar_tabliczki.Find(id)
            If IsNothing(rozmiar_tabliczki) Then
                Return HttpNotFound()
            End If
            Return View(rozmiar_tabliczki)
        End Function

        ' POST: Rozmiar_tabliczki/Edit/5
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_rozmiaru,rozmiar_tabliczki1")> ByVal rozmiar_tabliczki As Rozmiar_tabliczki) As ActionResult
            If ModelState.IsValid Then
                db.Entry(rozmiar_tabliczki).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rozmiar_tabliczki)
        End Function

        ' GET: Rozmiar_tabliczki/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rozmiar_tabliczki As Rozmiar_tabliczki = db.Rozmiar_tabliczki.Find(id)
            If IsNothing(rozmiar_tabliczki) Then
                Return HttpNotFound()
            End If
            Return View(rozmiar_tabliczki)
        End Function

        ' POST: Rozmiar_tabliczki/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim rozmiar_tabliczki As Rozmiar_tabliczki = db.Rozmiar_tabliczki.Find(id)
            db.Rozmiar_tabliczki.Remove(rozmiar_tabliczki)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
