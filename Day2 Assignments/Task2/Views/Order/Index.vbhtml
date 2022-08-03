﻿@model IEnumerable<WebApplication2.Order>

    @{
    ViewBag.Title = "Index";
    }

    <h2>Index</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(model => model.Customer_name)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Order_date)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Order_amount)
            </th>
            <th></th>
        </tr>

        @foreach (var item in Model) {
        <tr>
            <td>
                @Html.DisplayFor(modelItem => item.Customer_name)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Order_date)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Order_amount)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", new { id=item.OrderId }) |
                @Html.ActionLink("Details", "Details", new { id=item.OrderId }) |
                @Html.ActionLink("Delete", "Delete", new { id=item.OrderId })
            </td>
        </tr>
        }

    </table>
