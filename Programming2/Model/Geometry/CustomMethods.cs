using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


/// <summary>
/// Статический класс с пользовательскими методами.
/// </summary>
static class CustomMethods
{

    /// <summary>
    /// Массив типов моделей.
    /// </summary>
    static public readonly Type[] TypeModel = new Type[6] { typeof(Color), typeof(FormOfEducation),
                                            typeof(Genre), typeof(Manufacturers),
                                            typeof(Seasons), typeof(Weekday) };


    /// <summary>
    /// Массив текстовых полей для прямоугольников классов.
    /// </summary>
    static public TextBox[] TextBoxClassesRectangles { get; set; }

    /// <summary>
    /// Массив текстовых полей для прямоугольников.
    /// </summary>
    static public TextBox[] TextBoxRectangles { get; set; }

    /// <summary>
    /// Пытается получить значение перечисления по его имени.
    /// </summary>
    /// <typeparam name="T">Тип перечисления.</typeparam>
    /// <param name="itemName">Имя элемента перечисления.</param>
    /// <param name="value">Возвращаемое значение.</param>
    /// <returns>Значение true, если получилось получить значение, иначе - false.</returns>
    static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
    {
        if (Enum.TryParse<T>(itemName, true, out value))
        {
            return true;
        }
        value = default;
        return false;
    }
}
