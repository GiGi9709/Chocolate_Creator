@ModelType Czekolada2.Orzech
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Usuń orzech</h2>

<div>
   
    <hr />
    <dl class="dl-horizontal">
        <dt>
           Rodzaj orzecha
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rodzaj_orzecha)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" onclick="return confirm('Czy na pewno chcesz usunąć ten orzech')" value="Usuń" class="btn btn-default" /> |
            @Html.ActionLink("Powrót", "Index")
        </div>
    End Using
</div>
