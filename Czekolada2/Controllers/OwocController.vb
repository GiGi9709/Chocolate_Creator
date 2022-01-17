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
    Public Class OwocController
        Inherits System.Web.Mvc.Controller

        Private db As New CzekoladaEntities

        ' GET: Owoc
        Function Index() As ActionResult
            Return View(db.Owoc.ToList())
        End Function

        ' GET: Owoc/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim owoc As Owoc = db.Owoc.Find(id)
            If IsNothing(owoc) Then
                Return HttpNotFound()
            End If
            Return View(owoc)
        End Function

        ' GET: Owoc/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Owoc/Create
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_owoc,rodzaj_owocu")> ByVal owoc As Owoc) As ActionResult
            If ModelState.IsValid Then
                db.Owoc.Add(owoc)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(owoc)
        End Function

        ' GET: Owoc/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim owoc As Owoc = db.Owoc.Find(id)
            If IsNothing(owoc) Then
                Return HttpNotFound()
            End If
            Return View(owoc)
        End Function

        ' POST: Owoc/Edit/5
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_owoc,rodzaj_owocu")> ByVal owoc As Owoc) As ActionResult
            If ModelState.IsValid Then
                db.Entry(owoc).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(owoc)
        End Function

        ' GET: Owoc/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim owoc As Owoc = db.Owoc.Find(id)
            If IsNothing(owoc) Then
                Return HttpNotFound()
            End If
            Return View(owoc)
        End Function

        ' POST: Owoc/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim owoc As Owoc = db.Owoc.Find(id)
            db.Owoc.Remove(owoc)
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
