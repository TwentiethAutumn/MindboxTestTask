using TestTaskMindbox.Exceptions;

namespace TestTaskMindbox.Primitives;

public class Triangle : Shape
{
    private readonly double _area;
    private readonly bool _isRight;

    public override double GetArea() => _area;
    public bool IsRight() => _isRight;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0) throw new IncorrectTriangleDataException();
        var hypotenuseSquare = Math.Pow(Math.Max(Math.Max(sideA, sideB), sideC), 2);
        _isRight = Math.Pow(sideA, 2) + Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - hypotenuseSquare == hypotenuseSquare;
        var halfPerimeter = (sideA + sideB + sideC) / 2;
        _area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
    }
}