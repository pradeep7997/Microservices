@Model WebApplication2.Order

@{
    ViewBag.Title = "Details";
}

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New { id = Model.OrderId }) |
    @Html.ActionLink("Back to List", "Index")
</p>