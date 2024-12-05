
namespace TodoList.Domain.Models;

public class TodoListCollection : List<Entities.TodoList>
{
    /*public void DeleteList(Entities.TodoList list)
    {
        if (list.CanBeDeleted)
        {
            Remove(list);
        }
    }

    public void MoveTodo(Entities.Todo todo)
    {
        if (todo.CanBeUpdated)
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
                        // todo.UpdateDate = DateTime.Now;  // This won't work due to the private setter on todo.updatedate
                    }
                }
            }
        }
    }*/
}
