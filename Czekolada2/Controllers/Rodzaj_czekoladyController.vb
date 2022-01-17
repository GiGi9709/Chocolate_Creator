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
    Public Class Rodzaj_czekoladyController
        Inherits System.Web.Mvc.Controller

        Private db As New CzekoladaEntities

        ' GET: Rodzaj_czekolady
        Function Index() As ActionResult
            Return View(db.Rodzaj_czekolady.ToList())
        End Function

        ' GET: Rodzaj_czekolady/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rodzaj_czekolady As Rodzaj_czekolady = db.Rodzaj_czekolady.Find(id)
            If IsNothing(rodzaj_czekolady) Then
                Return HttpNotFound()
            End If
            Return View(rodzaj_czekolady)
        End Function

        ' GET: Rodzaj_czekolady/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Rodzaj_czekolady/Create
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_rodzaju,rodzaj_czekolady1")> ByVal rodzaj_czekolady As Rodzaj_czekolady) As ActionResult
            If ModelState.IsValid Then
                db.Rodzaj_czekolady.Add(rodzaj_czekolady)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rodzaj_czekolady)
        End Function

        ' GET: Rodzaj_czekolady/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rodzaj_czekolady As Rodzaj_czekolady = db.Rodzaj_czekolady.Find(id)
            If IsNothing(rodzaj_czekolady) Then
                Return HttpNotFound()
            End If
            Return View(rodzaj_czekolady)
        End Function

        ' POST: Rodzaj_czekolady/Edit/5
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_rodzaju,rodzaj_czekolady1")> ByVal rodzaj_czekolady As Rodzaj_czekolady) As ActionResult
            If ModelState.IsValid Then
                db.Entry(rodzaj_czekolady).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(rodzaj_czekolady)
        End Function

        ' GET: Rodzaj_czekolady/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim rodzaj_czekolady As Rodzaj_czekolady = db.Rodzaj_czekolady.Find(id)
            If IsNothing(rodzaj_czekolady) Then
                Return HttpNotFound()
            End If
            Return View(rodzaj_czekolady)
        End Function

        ' POST: Rodzaj_czekolady/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim rodzaj_czekolady As Rodzaj_czekolady = db.Rodzaj_czekolady.Find(id)
            db.Rodzaj_czekolady.Remove(rodzaj_czekolady)
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
