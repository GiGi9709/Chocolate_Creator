<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - moja aplikacja platformy ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <div>
                    <h3><p style="color:lightgrey;">Czekoladoinator &nbsp;</p></h3>
                </div>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("Czekolada", "Index", "Czekolada")</li>
                    <li>@Html.ActionLink("Rodzaj czekolady", "Index", "Rodzaj_czekolady")</li>
                    <li>@Html.ActionLink("Orzech", "Index", "Orzech")</li>
                    <li>@Html.ActionLink("Owoc", "Index", "Owoc")</li>
                    <li>@Html.ActionLink("Rozmiar tabliczki", "Index", "Rozmiar_tabliczki")</li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Moja aplikacja ASP.NET</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
