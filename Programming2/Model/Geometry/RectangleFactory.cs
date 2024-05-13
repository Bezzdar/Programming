using System.Drawing;
using System;
using Programming2;
using System.Windows.Forms;

/// <summary>
/// Статический класс для создания прямоугольников.
/// </summary>
static class RectangleFactory
{
    static Random _random = new Random();

    /// <summary>
    /// Создает случайный прямоугольник в указанной области панели.
    /// </summary>
    /// <param name="PanelRectangles">Панель, в которой будет создаваться прямоугольник.</param>
    /// <param name="maxHeight">Максимальная высота прямоугольника.</param>
    /// <param name="maxWidth">Максимальная ширина прямоугольника.</param>
    /// <returns>Созданный прямоугольник.</returns>
    static public Rectangle Randomize(Panel PanelRectangles, int maxHeight, int maxWidth)
    {
        int height = _random.Next(15, maxHeight);
        int width = _random.Next(15, maxWidth);
        return new Rectangle(height, width, Colors.Orange, new Point2D(_random.Next(16, PanelRectangles.Size.Width - 16 - maxWidth), _random.Next(16, PanelRectangles.Size.Height - 16 - maxHeight)));
    }
}