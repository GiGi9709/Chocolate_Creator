@ModelType Czekolada2.Orzech
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Orzech</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.rodzaj_orzecha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rodzaj_orzecha)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_orzech }) |
    @Html.ActionLink("Back to List", "Index")
</p>
