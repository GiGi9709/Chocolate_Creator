@ModelType Czekolada2.Rodzaj_czekolady
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Usuń rodzaj</h2>

<div>
   
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Rodzaj czekolady
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rodzaj_czekolady1)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" onclick="return confirm('Czy na pewno chcesz usunąć ten rodzaj czekolady')" value="Usuń" class="btn btn-default" /> |
            @Html.ActionLink("Powrót", "Index")
        </div>
    End Using
</div>
