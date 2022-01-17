@ModelType IEnumerable(Of Czekolada2.Czekolada)
@Code
ViewData("Title") = "Index"
End Code

<h2>Tworzenie twojej wymarzonej czekolady!</h2>

<p>
    @Html.ActionLink("Stwórz tutaj", "Create")
</p>
<table class="table">
    <tr>
        <th>

        </th>
        <th>
            Rodzaj czekolady
        </th>
        <th>
           Kakao %
        </th>
        <th>
            Rozmiar tabliczki
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.id_czekolada)

    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Rodzaj_czekolady.rodzaj_czekolady1)
    </td>
    
    <td>
        @Html.DisplayFor(Function(modelItem) item.Kakao.id_kakao)

    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.Rozmiar_tabliczki.rozmiar_tabliczki1)
    </td>
    <td>
        @Html.ActionLink("Edytuj", "Edit", New With {.id = item.id_czekolada}) |
        @Html.ActionLink("Wybrane dodatki", "Details", New With {.id = item.id_czekolada}) |
        @Html.ActionLink("Usuń", "Delete", New With {.id = item.id_czekolada})
    </td>
</tr>
Next

</table>
