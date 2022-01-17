@ModelType Czekolada2.Czekolada
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Usuń czekoldę</h2>


<div>
    
    <hr />
    <dl class="dl-horizontal">

        <dt>
            Rodzaj czekolady
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Rodzaj_czekolady.rodzaj_czekolady1)
        </dd>

        <dt>
            Kakao %
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Kakao.id_kakao)
        </dd>

        <dt>
            Orzechy
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Orzech.rodzaj_orzecha)
        </dd>

        <dt>
            Owoce
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Owoc.rodzaj_owocu)
        </dd>

        <dt>
            Rozmiar tabliczki
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Rozmiar_tabliczki.rozmiar_tabliczki1)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" onclick="return confirm('Czy na pewno chcesz usunąć tą czekoladę?')" value="Usuń" class="btn btn-default" /> |
            @Html.ActionLink("Powrót", "Index")
        </div>
    End Using
</div>
