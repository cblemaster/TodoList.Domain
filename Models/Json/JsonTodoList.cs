
namespace TodoList.Domain.Models.Json;

public class JsonTodoList
{
    public Guid TodoListId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
