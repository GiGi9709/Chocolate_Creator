@ModelType IEnumerable(Of Czekolada2.Rozmiar_tabliczki)
@Code
ViewData("Title") = "Index"
End Code

<h2>Rozmiar tabliczki</h2>

<p>
    @Html.ActionLink("Dodaj rozmiar", "Create")
</p>
<table class="table">
    <tr>
        <th>

        </th>
        <th>
            Dodaj nowy rozmiar tabliczki czekolady do listy
        </th>
        
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.id_rozmiaru)

    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.rozmiar_tabliczki1)
    </td>
    <td>
        @Html.ActionLink("Edytuj", "Edit", New With {.id = item.id_rozmiaru}) |

        @Html.ActionLink("Usuń", "Delete", New With {.id = item.id_rozmiaru})
    </td>
</tr>
Next

</table>
