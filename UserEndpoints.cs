namespace MinimalAPI.CodeSeparation;

partial class UserEndpoints
{
    public static void MapUserEndPoints(WebApplication app)
    {
        app.MapGet("/GetUser",() => {
            return Results.Ok("All Users");
        });
    }
}