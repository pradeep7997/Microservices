@Model WebApplication2.Order

@{
    ViewBag.Title = "Edit";
}

<h2>Edit</h2>


@            Using (Html.BeginForm())
{
@Html.AntiForgeryToken()

<div Class="form-horizontal">
<h4> Order</h4>
<hr />
@Html.ValidationSummary(true, "", New { @class = "text-danger" })
@Html.HiddenFor(model => model.OrderId)

        <div Class="form-group">
@Html.LabelFor(model => model.Customer_name, htmlAttributes New { @class = "control-label col-md-2" })
            <div Class="col-md-10">
@Html.EditorFor(model => model.Customer_name, New { htmlAttributes = New { @class = "form-control" } })
@Html.ValidationMessageFor(model => model.Customer_name, "", new { @class = "text-danger" })
            </div>
        </div>

        <div Class="form-group">
@Html.LabelFor(model => model.Order_date, htmlAttributes New { @class = "control-label col-md-2" })
            <div Class="col-md-10">
@Html.EditorFor(model => model.Order_date, New { htmlAttributes = New { @class = "form-control" } })
@Html.ValidationMessageFor(model => model.Order_date, "", new { @class = "text-danger" })
            </div>
        </div>

        <div Class="form-group">
@Html.LabelFor(model => model.Order_amount, htmlAttributes New { @class = "control-label col-md-2" })
            <div Class="col-md-10">
@Html.EditorFor(model => model.Order_amount, New { htmlAttributes = New { @class = "form-control" } })
@Html.ValidationMessageFor(model => model.Order_amount, "", new { @class = "text-danger" })
            </div>
        </div>

        <div Class="form-group">
            <div Class="col-md-offset-2 col-md-10">
                <input type = "submit" value="Save" Class="btn btn-default" />
            </div>
        </div>
    </div>
}

<div>
@Html.ActionLink("Back to List", "Index")
</div>

@section Scripts {
    @Scripts.Render("~/bundles/jqueryval")
    }