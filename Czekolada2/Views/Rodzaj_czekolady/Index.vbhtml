@ModelType IEnumerable(Of Czekolada2.Rodzaj_czekolady)
@Code
ViewData("Title") = "Index"
End Code

<h2>Rodzaj czekolady</h2>

<p>
    @Html.ActionLink("Dodaj rodzaj", "Create")
</p>
<table class="table">
    <tr>
        <th>

        </th>
        <th>
            Wybierz rodzaj czekolady
        </th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.id_rodzaju)

    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.rodzaj_czekolady1)
    </td>
    <td>
        @Html.ActionLink("Edytuj", "Edit", New With {.id = item.id_rodzaju}) |

        @Html.ActionLink("Usuń", "Delete", New With {.id = item.id_rodzaju})
    </td>
</tr>
Next

</table>
