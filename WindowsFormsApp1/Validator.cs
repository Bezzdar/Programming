public static class Validator
{
    /// <summary>
    /// Validates the product name.
    /// </summary>
    /// <param name="name">The name of the song.</param>
    /// <returns>True if valid, otherwise false.</returns>
    public static bool ValidateName(string name, out string errorMessage)
    {
        errorMessage = string.Empty;
        if (string.IsNullOrWhiteSpace(name))
        {
            errorMessage = "Название песни не должно быть пустым.";
            return false;
        }
        if (name.Length > 50)
        {
            errorMessage = "Название песни должно быть не длиннее 50 символов.";
            return false;
        }
        return true;
    }

    /// <summary>
    /// Validates the manufacturer name.
    /// </summary>
    /// <param name="Singer">The name of the Artist.</param>
    /// <returns>True if valid, otherwise false.</returns>
    public static bool ValidateSinger(string Singer, out string errorMessage)
    {
        errorMessage = string.Empty;
        if (string.IsNullOrWhiteSpace(Singer))
        {
            errorMessage = "Имя исполнителя не должно быть пустым.";
            return false;
        }
        if (Singer.Length > 50)
        {
            errorMessage = "Имя исполнителя должно быть не длиннее 50 символов.";
            return false;
        }
        return true;
    }
}
