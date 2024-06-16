
namespace MinimalAPI.CodeSeparation;

public class EmployeeEndPoints : IEmployeeEndPoints
{
    public void MapGetEmployees(IEndpointRouteBuilder app)
    {
        app.MapGet("/getemployees",() => {
            return Results.Ok("All Employees");
        }).WithOpenApi();
    }
}
