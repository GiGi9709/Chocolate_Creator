@ModelType Czekolada2.Czekolada
@Code
    ViewData("Title") = "Details"
End Code

<h2>Wybrane dodatki w czekoladzie</h2>

<div>
    
    <hr />
    <dl class="dl-horizontal">
        
        <dt>
            <h4><b> Rodzaj orzechów </b></h4>
        </dt>

        <dd>
            <h4> @Html.DisplayFor(Function(model) model.Orzech.rodzaj_orzecha)</h4>
        </dd>

        <dt>
            <h4><b> Rodzaj owocu </b></h4>
        </dt>

        <dd>
            <h4> @Html.DisplayFor(Function(model) model.Owoc.rodzaj_owocu)</h4>
        </dd>
        


        

    </dl>
</div>
<p>
    @Html.ActionLink("Edytuj", "Edit", New With {.id = Model.id_czekolada}) |
    @Html.ActionLink("Powrót", "Index")
</p>
