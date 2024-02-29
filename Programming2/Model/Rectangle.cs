using System;

class Rectangle
{
    int _length;
    int _width;

    public Colors Color { get; set; }   

    public int Length
    {
        get { return _length; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _length = value;
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

    public Rectangle()
    {
        Length = 15;
        Width = 30;
        Color = Colors.Green;
    }

    public Rectangle(int length, int width, Colors color)
    {
        Length = length;
        Width = width;
        Color = color;
    }

    public override string ToString()
    {
        return $"Rectangle {Length}x{Width}";
    }
}
