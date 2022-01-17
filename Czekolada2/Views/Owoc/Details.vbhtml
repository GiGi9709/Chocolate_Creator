@ModelType Czekolada2.Owoc
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Owoc</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.rodzaj_owocu)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rodzaj_owocu)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_owoc }) |
    @Html.ActionLink("Back to List", "Index")
</p>
