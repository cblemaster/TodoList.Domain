namespace TodoList.Domain;

internal static class Constants
{
    internal const int MAX_LENGTH_FOR_TODOLIST_NAME = 255;
    internal const int MIN_LENGTH_FOR_TODOLIST_NAME = 1;

    internal const int MAX_LENGTH_FOR_TODO_DESC = 255;
    internal const int MIN_LENGTH_FOR_TODO_DESC = 1;

    internal const string ERROR_FOR_TODOLIST_NAME_MAX_LENGTH = "Todo list name must be 255 characters or fewer.";
    internal const string ERROR_FOR_TODOLIST_NAME_REQUIRED = "Todo list name is required.";

    internal const string ERROR_FOR_TODO_DESC_MAX_LENGTH = "Todo description must be 255 characters or fewer.";
    internal const string ERROR_FOR_TODO_DESC_REQUIRED = "Todo description is required.";
}
