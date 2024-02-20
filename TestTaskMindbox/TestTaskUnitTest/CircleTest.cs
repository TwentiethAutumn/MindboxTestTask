using System;
using NUnit.Framework;
using TestTaskMindbox.Exceptions;
using TestTaskMindbox.Primitives;

namespace TestTaskUnitTest;

public class CircleTest
{
    private Circle _correctCircle;
    
    [SetUp]
    public void Setup()
    {
        _correctCircle = new Circle(1);
    }

    [Test]
    public void Test_CircleAreaCorrect()
    {
        Assert.AreEqual(Math.PI, _correctCircle.GetArea());
    }

    [Test]
    public void Test_CircleRadiusIncorrect()
    {
        Assert.Throws<IncorrectCircleRadiusException>(() =>
        {
            var circle = new Circle(-1);
        });
    }
}