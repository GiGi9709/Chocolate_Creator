@ModelType IEnumerable(Of Czekolada2.Owoc)
@Code
ViewData("Title") = "Index"
End Code

<h2>Rodzaje owoców</h2>

<p>
    @Html.ActionLink("Dodaj owoc", "Create")
</p>
<table class="table">
    <tr>
        <th>

        </th>
        <th>
            Wybierz jaki rodzaj owoców chcesz dodać do listy
        </th>

    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.id_owoc)

    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.rodzaj_owocu)
    </td>
    <td>
        @Html.ActionLink("Edytuj", "Edit", New With {.id = item.id_owoc}) |

        @Html.ActionLink("Usuń", "Delete", New With {.id = item.id_owoc})
    </td>
</tr>
Next

</table>
