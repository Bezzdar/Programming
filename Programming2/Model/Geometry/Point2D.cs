
/// <summary>
/// Представляет двумерную точку.
/// </summary>
class Point2D
{
    double _x;
    public double _y;

    /// <summary>
    /// Координата X точки.
    /// </summary>
    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _x = value;
        }
    }

    /// <summary>
    /// Координата Y точки.
    /// </summary>
    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _y = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Point2D с указанными координатами.
    /// </summary>
    /// <param name="x">Координата X точки.</param>
    /// <param name="y">Координата Y точки.</param>
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
}