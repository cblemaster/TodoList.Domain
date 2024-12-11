
namespace TodoList.Domain.DataTransfer;

public class SeeTodosForList
{
    public IEnumerable<TodoSummary> Todos { get; set; } = [];
    public string ListName { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public Guid ListId { get; set; }
}
