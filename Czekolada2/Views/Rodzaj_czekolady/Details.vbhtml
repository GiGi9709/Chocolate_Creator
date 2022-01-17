@ModelType Czekolada2.Rodzaj_czekolady
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Rodzaj_czekolady</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.rodzaj_czekolady1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rodzaj_czekolady1)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_rodzaju }) |
    @Html.ActionLink("Back to List", "Index")
</p>
