
using TodoList.Domain.DataTransfer.Enumerations;

namespace TodoList.Domain.DataTransfer;

public class VirtualList
{
    public ICollection<TodoSummary> Todos { get; set; } = [];
    public VirtualListType ListType { get; set; }    
}
