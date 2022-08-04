@Model IEnumerable<WebApplication3.Models.Employee>

    @{
    ViewData["Title"] = "Index";
    }

    <h1>Index</h1>

    <p>
        <a asp-action="Create">Create New</a>
    </p>
    <table class="table">
        <thead>
            <tr>
                <th>
                    @Html.DisplayNameFor(Model >= Model.EmployeeId)
                </th>
                <th>
                    @Html.DisplayNameFor(Model >= Model.EmployeeName)
                </th>
                <th>
                    @Html.DisplayNameFor(Model >= Model.EmployeeJob)
                </th>
                <th>
                    @Html.DisplayNameFor(Model >= Model.EmployeeSalary)
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @foreach (var item in Model) {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem >= item.EmployeeId)
                </td>
                <td>
                    @Html.DisplayFor(modelItem >= item.EmployeeName)
                </td>
                <td>
                    @Html.DisplayFor(modelItem >= item.EmployeeJob)
                </td>
                <td>
                    @Html.DisplayFor(modelItem >= item.EmployeeSalary)
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New {id=item.EmployeeId }) |
                    @Html.ActionLink("Details", "Details", New { id=item.EmployeeId }) |
                    @Html.ActionLink("Delete", "Delete", New { id=item.EmployeeId })
                </td>
            </tr>
            }
        </tbody>
    </table>
