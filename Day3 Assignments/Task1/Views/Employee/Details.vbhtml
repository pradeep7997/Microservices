@Model WebApplication3.Models.Employee

@{
    ViewData["Title"] = "Details";
}

<h1>Details</h1>

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
</div>
<div>
    @Html.ActionLink("Edit", "Edit", New { id=Model.EmployeeId}) |
    <a asp-action="Index">Back to List</a>
</div>
