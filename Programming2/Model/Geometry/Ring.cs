using System;

/// <summary>
/// ������������ ������.
/// </summary>
class Ring
{

    /// <summary>
    /// ����� ������.
    /// </summary>
    public Point2D Center { get; }
    double _internalRadius;
    double _externalRadius;

    /// <summary>
    /// ���������� ������ ������.
    /// </summary>
    public double InternalRadius
    {
        get { return _internalRadius; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            if (value > _externalRadius) throw new ArgumentException("The inner radius cannot be larger than the outer radius.");
            _internalRadius = value;
        }
    }

    /// <summary>
    /// ������� ������ ������.
    /// </summary>
    public double ExternalRadius
    {
        get { return _externalRadius; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            if (value < _internalRadius) throw new ArgumentException("The external radius cannot be smaller than the inner radius.");
            _externalRadius = value;
        }
    }

    /// <summary>
    /// ������� ������.
    /// </summary>
    public double Area => Math.PI * Math.Pow(_externalRadius, 2) - Math.PI * Math.Pow(_internalRadius, 2);

    /// <summary>
    /// �������������� ����� ��������� ������ Ring � ���������� ���������.
    /// </summary>
    /// <param name="internalRadius">���������� ������ ������.</param>
    /// <param name="externalRadius">������� ������ ������.</param>
    public Ring(double internalRadius, double externalRadius)
    {
        InternalRadius = internalRadius;
        ExternalRadius = externalRadius;
        Center = new Point2D(InternalRadius / 2, ExternalRadius / 2);
    }
}