@ModelType Czekolada2.Owoc
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Usuń owoc</h2>


<div>
    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            Rodzaj owocu
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rodzaj_owocu)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" onclick="return confirm('Czy na pewno chcesz usunąć ten owoc')" value="Usuń" class="btn btn-default" /> |
            @Html.ActionLink("Powrót", "Index")
        </div>
    End Using
</div>
