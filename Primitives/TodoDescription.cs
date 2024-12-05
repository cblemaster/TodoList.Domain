
using System.ComponentModel.DataAnnotations;

namespace TodoList.Domain.Primitives;

public readonly record struct TodoDescription
    ([Required(AllowEmptyStrings = false,
        ErrorMessage = Constants.ERROR_FOR_TODO_DESC_REQUIRED),
     StringLength(maximumLength: Constants.MAX_LENGTH_FOR_TODO_DESC,
        ErrorMessage = Constants.ERROR_FOR_TODO_DESC_MAX_LENGTH,
        MinimumLength = Constants.MIN_LENGTH_FOR_TODO_DESC),
     RegularExpression(@"[^\s+$]", ErrorMessage = Constants.ERROR_FOR_TODO_DESC_REQUIRED)]
    string Value);
