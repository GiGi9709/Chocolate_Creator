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
    Public Class OrzechController
        Inherits System.Web.Mvc.Controller

        Private db As New CzekoladaEntities

        ' GET: Orzech
        Function Index() As ActionResult
            Return View(db.Orzech.ToList())
        End Function

        ' GET: Orzech/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim orzech As Orzech = db.Orzech.Find(id)
            If IsNothing(orzech) Then
                Return HttpNotFound()
            End If
            Return View(orzech)
        End Function

        ' GET: Orzech/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Orzech/Create
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_orzech,rodzaj_orzecha")> ByVal orzech As Orzech) As ActionResult
            If ModelState.IsValid Then
                db.Orzech.Add(orzech)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(orzech)
        End Function

        ' GET: Orzech/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim orzech As Orzech = db.Orzech.Find(id)
            If IsNothing(orzech) Then
                Return HttpNotFound()
            End If
            Return View(orzech)
        End Function

        ' POST: Orzech/Edit/5
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_orzech,rodzaj_orzecha")> ByVal orzech As Orzech) As ActionResult
            If ModelState.IsValid Then
                db.Entry(orzech).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(orzech)
        End Function

        ' GET: Orzech/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim orzech As Orzech = db.Orzech.Find(id)
            If IsNothing(orzech) Then
                Return HttpNotFound()
            End If
            Return View(orzech)
        End Function

        ' POST: Orzech/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim orzech As Orzech = db.Orzech.Find(id)
            db.Orzech.Remove(orzech)
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
