@ModelType Czekolada2.Kakao
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Kakao</h4>
    <hr />
    <dl class="dl-horizontal">
    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id_kakao }) |
    @Html.ActionLink("Back to List", "Index")
</p>
