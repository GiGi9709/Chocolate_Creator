@ModelType IEnumerable(Of Czekolada2.Kakao)
@Code
ViewData("Title") = "Index"
End Code

<h2>Ilość kakaa</h2>

<p>
    @Html.ActionLink("Dodaj ilość ", "Create")
</p>
<table class="table">
    <tr>
        <th>
            Procentowa ilość kakaa w czekoladzie
        </th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.id_kakao)
    </td>
    <td>
        @Html.ActionLink("Usuń", "Delete", New With {.id = item.id_kakao})
    </td>
</tr>
Next

</table>
