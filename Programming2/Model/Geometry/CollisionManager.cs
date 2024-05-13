
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Класс для управления коллизиями.
/// </summary>
class CollisionManager
{

    /// <summary>
    /// Проверяет наличие коллизии между двумя прямоугольниками.
    /// </summary>
    /// <param name="rectangle1">Первый прямоугольник.</param>
    /// <param name="rectangle2">Второй прямоугольник.</param>
    /// <returns>Значение true, если есть коллизия, иначе - false.</returns>
    public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
    {
        double differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
        double halfLatitude = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
        double differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
        double halfLength = Math.Abs(rectangle1.Height + rectangle2.Height) / 2;
        return differenceX < halfLatitude && differenceY < halfLength;
    }

    /// <summary>
    /// Проверяет наличие коллизии между двумя кольцами.
    /// </summary>
    /// <param name="ring1">Первое кольцо.</param>
    /// <param name="ring2">Второе кольцо.</param>
    /// <returns>Значение true, если есть коллизия, иначе - false.</returns>
    public static bool IsCollision(Ring ring1, Ring ring2)
    {
        double hypotenuse = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) + Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));
        double sumOfExternalRadii = ring1.ExternalRadius + ring2.ExternalRadius;
        return hypotenuse < sumOfExternalRadii;
    }
}