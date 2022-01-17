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
    Public Class KakaoController
        Inherits System.Web.Mvc.Controller

        Private db As New CzekoladaEntities

        ' GET: Kakao
        Function Index() As ActionResult
            Return View(db.Kakao.ToList())
        End Function

        ' GET: Kakao/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim kakao As Kakao = db.Kakao.Find(id)
            If IsNothing(kakao) Then
                Return HttpNotFound()
            End If
            Return View(kakao)
        End Function

        ' GET: Kakao/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Kakao/Create
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_kakao")> ByVal kakao As Kakao) As ActionResult
            If ModelState.IsValid Then
                db.Kakao.Add(kakao)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(kakao)
        End Function

        ' GET: Kakao/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim kakao As Kakao = db.Kakao.Find(id)
            If IsNothing(kakao) Then
                Return HttpNotFound()
            End If
            Return View(kakao)
        End Function

        ' POST: Kakao/Edit/5
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_kakao")> ByVal kakao As Kakao) As ActionResult
            If ModelState.IsValid Then
                db.Entry(kakao).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(kakao)
        End Function

        ' GET: Kakao/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim kakao As Kakao = db.Kakao.Find(id)
            If IsNothing(kakao) Then
                Return HttpNotFound()
            End If
            Return View(kakao)
        End Function

        ' POST: Kakao/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim kakao As Kakao = db.Kakao.Find(id)
            db.Kakao.Remove(kakao)
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
