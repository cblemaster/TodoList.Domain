
using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain.Primitives;

public readonly record struct TodoListName
    ([Required(AllowEmptyStrings = false,
        ErrorMessage = Constants.ERROR_FOR_TODOLIST_NAME_REQUIRED),
     StringLength(maximumLength: Constants.MAX_LENGTH_FOR_TODOLIST_NAME,
        ErrorMessage = Constants.ERROR_FOR_TODOLIST_NAME_MAX_LENGTH,
        MinimumLength = Constants.MIN_LENGTH_FOR_TODOLIST_NAME),
     RegularExpression(@"[^\s+$]", ErrorMessage = Constants.ERROR_FOR_TODOLIST_NAME_REQUIRED)]
    string Value);