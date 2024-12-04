
namespace TodoList.Domain.Models;

public class TodoListCollection : List<Entities.TodoList>
{
    public void DeleteList(Entities.TodoList list)
    {
        if (list.IsValidForDelete)
        {
            Remove(list);
        }
    }

    public void MoveTodo(Entities.Todo todo)
    {
        if (todo.IsValidForUpdate)
        {
            Entities.Todo? entity = this.SelectMany(l => l).SingleOrDefault(l => l.Id == todo.Id);
            if (entity is not null)
            {
                if (entity.TodoListId == todo.TodoListId)
                {
                    return;
                }
                else
                {
                    Entities.TodoList? listToRemoveFrom = this.SingleOrDefault(l => l.Id == entity.TodoListId);
                    Entities.TodoList? listToAddTo = this.SingleOrDefault(l => l.Id == todo.TodoListId);
                    if (listToRemoveFrom is not null && listToAddTo is not null)
                    {
                        listToRemoveFrom.Remove(todo);
                        listToAddTo.Add(todo);
                    }
                }
            }
        }
    }
}
