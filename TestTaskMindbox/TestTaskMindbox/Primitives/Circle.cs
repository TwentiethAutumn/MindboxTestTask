using TestTaskMindbox.Exceptions;

namespace TestTaskMindbox.Primitives;

public class Circle : Shape
{
    private readonly double _area;

    public Circle(int radius)
    {
        if (radius < 0) throw new IncorrectCircleRadiusException();
        _area = Math.PI * Math.Pow(radius, 2);
    }

    public override double GetArea() => _area;
}