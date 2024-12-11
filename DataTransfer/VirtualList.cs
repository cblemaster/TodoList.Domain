
using TodoList.Domain.DataTransfer.Enumerations;

namespace TodoList.Domain.DataTransfer;

public class VirtualList
{
    public VirtualListType ListType { get; set; }
    public ICollection<TodoSummary> Todos { get; set; } = [];
}
