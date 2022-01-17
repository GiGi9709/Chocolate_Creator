@ModelType Czekolada2.Kakao
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Usuń ilość</h2>


<div>
    
    <hr />
    <dl class="dl-horizontal">
    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Usuń" class="btn btn-default" /> |
            @Html.ActionLink("Powrót", "Index")
        </div>
    End Using
</div>
