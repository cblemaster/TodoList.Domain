
namespace TodoList.Domain.Models.Json;

public class JsonTodo
{
    public Guid TodoId { get; set; }
    public Guid TodoListId { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime? DueDate { get; set; }
    public bool IsImportant { get; set; }
    public bool IsComplete { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
