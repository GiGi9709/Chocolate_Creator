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
    Public Class CzekoladaController
        Inherits System.Web.Mvc.Controller

        Private db As New CzekoladaEntities

        ' GET: Czekolada
        Function Index() As ActionResult
            Dim czekolada = db.Czekolada.Include(Function(c) c.Kakao).Include(Function(c) c.Orzech).Include(Function(c) c.Owoc).Include(Function(c) c.Rodzaj_czekolady).Include(Function(c) c.Rozmiar_tabliczki)
            Return View(czekolada.ToList())
        End Function

        ' GET: Czekolada/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim czekolada As Czekolada = db.Czekolada.Find(id)
            If IsNothing(czekolada) Then
                Return HttpNotFound()
            End If
            Return View(czekolada)
        End Function

        ' GET: Czekolada/Create
        Function Create() As ActionResult
            ViewBag.id_kakao = New SelectList(db.Kakao, "id_kakao", "id_kakao")
            ViewBag.id_orzech = New SelectList(db.Orzech, "id_orzech", "rodzaj_orzecha")
            ViewBag.id_owoc = New SelectList(db.Owoc, "id_owoc", "rodzaj_owocu")
            ViewBag.id_rodzaj = New SelectList(db.Rodzaj_czekolady, "id_rodzaju", "rodzaj_czekolady1")
            ViewBag.id_rozmiar = New SelectList(db.Rozmiar_tabliczki, "id_rozmiaru", "rozmiar_tabliczki1")
            Return View()
        End Function

        ' POST: Czekolada/Create
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id_czekolada,id_rodzaj,id_orzech,id_owoc,id_rozmiar,id_kakao")> ByVal czekolada As Czekolada) As ActionResult
            If ModelState.IsValid Then
                db.Czekolada.Add(czekolada)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.id_kakao = New SelectList(db.Kakao, "id_kakao", "id_kakao", czekolada.id_kakao)
            ViewBag.id_orzech = New SelectList(db.Orzech, "id_orzech", "rodzaj_orzecha", czekolada.id_orzech)
            ViewBag.id_owoc = New SelectList(db.Owoc, "id_owoc", "rodzaj_owocu", czekolada.id_owoc)
            ViewBag.id_rodzaj = New SelectList(db.Rodzaj_czekolady, "id_rodzaju", "rodzaj_czekolady1", czekolada.id_rodzaj)
            ViewBag.id_rozmiar = New SelectList(db.Rozmiar_tabliczki, "id_rozmiaru", "rozmiar_tabliczki1", czekolada.id_rozmiar)
            Return View(czekolada)
        End Function

        ' GET: Czekolada/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim czekolada As Czekolada = db.Czekolada.Find(id)
            If IsNothing(czekolada) Then
                Return HttpNotFound()
            End If
            ViewBag.id_kakao = New SelectList(db.Kakao, "id_kakao", "id_kakao", czekolada.id_kakao)
            ViewBag.id_orzech = New SelectList(db.Orzech, "id_orzech", "rodzaj_orzecha", czekolada.id_orzech)
            ViewBag.id_owoc = New SelectList(db.Owoc, "id_owoc", "rodzaj_owocu", czekolada.id_owoc)
            ViewBag.id_rodzaj = New SelectList(db.Rodzaj_czekolady, "id_rodzaju", "rodzaj_czekolady1", czekolada.id_rodzaj)
            ViewBag.id_rozmiar = New SelectList(db.Rozmiar_tabliczki, "id_rozmiaru", "rozmiar_tabliczki1", czekolada.id_rozmiar)
            Return View(czekolada)
        End Function

        ' POST: Czekolada/Edit/5
        'Aby zapewnić ochronę przed atakami polegającymi na przesyłaniu dodatkowych danych, włącz określone właściwości, z którymi chcesz utworzyć powiązania.
        'Aby uzyskać więcej szczegółów, zobacz https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id_czekolada,id_rodzaj,id_orzech,id_owoc,id_rozmiar,id_kakao")> ByVal czekolada As Czekolada) As ActionResult
            If ModelState.IsValid Then
                db.Entry(czekolada).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.id_kakao = New SelectList(db.Kakao, "id_kakao", "id_kakao", czekolada.id_kakao)
            ViewBag.id_orzech = New SelectList(db.Orzech, "id_orzech", "rodzaj_orzecha", czekolada.id_orzech)
            ViewBag.id_owoc = New SelectList(db.Owoc, "id_owoc", "rodzaj_owocu", czekolada.id_owoc)
            ViewBag.id_rodzaj = New SelectList(db.Rodzaj_czekolady, "id_rodzaju", "rodzaj_czekolady1", czekolada.id_rodzaj)
            ViewBag.id_rozmiar = New SelectList(db.Rozmiar_tabliczki, "id_rozmiaru", "rozmiar_tabliczki1", czekolada.id_rozmiar)
            Return View(czekolada)
        End Function

        ' GET: Czekolada/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim czekolada As Czekolada = db.Czekolada.Find(id)
            If IsNothing(czekolada) Then
                Return HttpNotFound()
            End If
            Return View(czekolada)
        End Function

        ' POST: Czekolada/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim czekolada As Czekolada = db.Czekolada.Find(id)
            db.Czekolada.Remove(czekolada)
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
