@Model WebApplication3.Models.Employee

@{
    ViewData["Title"] = "Delete";
}

<h1>Delete</h1>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Employee</h4>
    <hr />
    <dl class="row">
        <dt class="col-sm-2">
            @Html.DisplayNameFor(Model >= Model.EmployeeId)
        </dt>
        <dd class="col-sm-10">
            @Html.DisplayFor(Model >= Model.EmployeeId)
        </dd>
        <dt class="col-sm-2">
            @Html.DisplayNameFor(Model >= Model.EmployeeName)
        </dt>
        <dd class="col-sm-10">
            @Html.DisplayFor(Model >= Model.EmployeeName)
        </dd>
        <dt class="col-sm-2">
            @Html.DisplayNameFor(Model >= Model.EmployeeJob)
        </dt>
        <dd class="col-sm-10">
            @Html.DisplayFor(Model >= Model.EmployeeJob)
        </dd>
        <dt class="col-sm-2">
            @Html.DisplayNameFor(Model >= Model.EmployeeSalary)
        </dt>
        <dd class="col-sm-10">
            @Html.DisplayFor(Model >= Model.EmployeeSalary)
        </dd>
    </dl>

    <form asp-action="Delete">
        <input type="submit" value="Delete" class="btn btn-danger" /> |
        <a asp-action="Index">Back to List</a>
    </form>
</div>