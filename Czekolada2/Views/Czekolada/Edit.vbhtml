@ModelType Czekolada2.Czekolada
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edytuj swój wybór</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.id_czekolada)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.id_rodzaj, "Rodzaj czekolady", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("id_rodzaj", Nothing, htmlAttributes:= New With { .class = "form-control" })
                @Html.ValidationMessageFor(Function(model) model.id_rodzaj, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.id_kakao, "Kakao %", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("id_kakao", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.id_kakao, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.id_orzech, "Orzechy", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("id_orzech", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.id_orzech, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.id_owoc, "Owoce", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("id_owoc", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.id_owoc, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.id_rozmiar, "Rozmiar tabliczki", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownList("id_rozmiar", Nothing, htmlAttributes:=New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(model) model.id_rozmiar, "", New With {.class = "text-danger"})
            </div>
        </div>

        

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Zapisz" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Powrót", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
