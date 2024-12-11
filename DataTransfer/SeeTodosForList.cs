
namespace TodoList.Domain.DataTransfer;

public class SeeTodosForList
{
    public Guid ListId { get; set; }
    public string ListName { get; set; } = string.Empty;
    public IEnumerable<TodoSummary> Todos { get; set; } = [];
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
}
