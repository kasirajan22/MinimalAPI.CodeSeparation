namespace MinimalAPI.CodeSeparation;

public static class ToDoAPIs
{
    public static RouteGroupBuilder MapTodosApi(this RouteGroupBuilder group)
    {
        group.MapPost("/todo", CreateTodo).WithOpenApi();
        return group;
    }

    public static IResult CreateTodo(Todo todo)
    {
        return Results.Ok(todo);
    }
}
