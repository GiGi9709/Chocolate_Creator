@ModelType Czekolada2.Rozmiar_tabliczki
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Usuń rozmiar</h2>


<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Rozmiar tabliczki
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rozmiar_tabliczki1)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" onclick="return confirm('Czy na pewno chcesz usunąć ten rozmiar')" value="Usuń" class="btn btn-default" /> |
            @Html.ActionLink("Powrót", "Index")
        </div>
    End Using
</div>
