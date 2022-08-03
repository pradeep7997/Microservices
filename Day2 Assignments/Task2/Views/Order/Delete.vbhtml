@Model WebApplication2.Order

@{
    ViewBag.Title = "Delete";
}

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Order</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Model >= Model.Customer_name)
        </dt>

        <dd>
            @Html.DisplayFor(Model >= Model.Customer_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Model >= Model.Order_date)
        </dt>

        <dd>
            @Html.DisplayFor(Model >= Model.Order_date)
        </dd>

        <dt>
            @Html.DisplayNameFor(Model >= Model.Order_amount)
        </dt>

        <dd>
            @Html.DisplayFor(Model >= Model.Order_amount)
        </dd>

    </dl>

    @        Using (Html.BeginForm()) {
@Html.AntiForgeryToken()

    <div Class="form-actions no-color">
    <input type = "submit" value="Delete" Class="btn btn-default" /> |
@Html.ActionLink("Back to List", "Index")
        </div>
    }
</div>
