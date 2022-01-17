@ModelType IEnumerable(Of Czekolada2.Orzech)
@Code
ViewData("Title") = "Index"
End Code

<h2>Rodzaje orzechów</h2>

<p>
    @Html.ActionLink("Dodaj orzech", "Create")
</p>
<table class="table">
    <tr>
        <th>
            
        </th>

        <th>
            Wybierz które orzechy chcesz dodać do listy
        </th>
    </tr>

@For Each item In Model
    @<tr>
         <td>
             @Html.DisplayFor(Function(modelItem) item.id_orzech)

         </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rodzaj_orzecha)
        </td>
        <td>
            @Html.ActionLink("Edytuj", "Edit", New With {.id = item.id_orzech}) |
            @Html.ActionLink("Usuń", "Delete", New With {.id = item.id_orzech})
        </td>
    </tr>
Next

</table>
