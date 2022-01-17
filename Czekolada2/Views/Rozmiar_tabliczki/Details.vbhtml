@ModelType Czekolada2.Rozmiar_tabliczki
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Rozmiar_tabliczki</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.rozmiar_tabliczki1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rozmiar_tabliczki1)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_rozmiaru }) |
    @Html.ActionLink("Back to List", "Index")
</p>
