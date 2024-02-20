using System;
using NUnit.Framework;
using TestTaskMindbox;
using TestTaskMindbox.Primitives;

namespace TestTaskUnitTest;

public class ShapeTest
{
    private Shape _circleShape;
    private Shape _triangleShape;
    [SetUp]
    public void Setup()
    {
        _circleShape = new Circle(1);
        _triangleShape = new Triangle(10, 10, 12);
    }

    [Test]
    public void Test_CircleAreaCorrect()
    {
        Assert.AreEqual(Math.PI, _circleShape.GetArea());
    }

    [Test]
    public void Test_TriangleAreaCorrect()
    {
        Assert.AreEqual(48, _triangleShape.GetArea());
    }
}