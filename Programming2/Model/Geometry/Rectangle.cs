using System.Drawing;

class Rectangle
{
    int _height;
    int _width;

    public Colors Color { get; set; }

    static int _allRectanglesCount;
    readonly int _id;

    public int Height
    {
        get { return _height; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _height = value;
        }
    }
    public int Width
    {
        get { return _width; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;
        }
    }
    public Point2D Center => new Point2D(Width / 2, Height / 2);

    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    public int Id
    {
        get { return _id; }
    }

    public Rectangle()
    {
        Height = 15;
        Width = 30;
        Color = Colors.Green;
        _id = ++_allRectanglesCount;
    }
    public Rectangle(int height, int width, Colors color)
    {
        Height = height;
        Width = width;
        Color = color;
        _id = ++_allRectanglesCount;
    }

    public override string ToString()
    {
        return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Height})";
    }
}
