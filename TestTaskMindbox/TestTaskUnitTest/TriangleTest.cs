using NUnit.Framework;
using TestTaskMindbox.Exceptions;
using TestTaskMindbox.Primitives;

namespace TestTaskUnitTest;

public class TriangleTest
{
    private Triangle _randomTriangle;
    private Triangle _rightTriangle;
    
    [SetUp]
    public void Setup()
    {
        _randomTriangle = new Triangle(10, 10, 12);
        _rightTriangle = new Triangle(5, 12, 13);
    }

    [Test]
    public void Test_TriangleAreaCorrect()
    {
        Assert.AreEqual(48, _randomTriangle.GetArea());
    }

    [Test]
    public void Test_TriangleRightCorrect()
    {
        Assert.AreEqual(true, _rightTriangle.IsRight());
    }

    [Test]
    public void Test_TriangleRightIncorrect()
    {
        Assert.AreEqual(false, _randomTriangle.IsRight());
    }

    [Test]
    public void Test_TriangleSideIncorrect()
    {
        Assert.Throws<IncorrectTriangleDataException>(() =>
        {
            var wrongTriangle = new Triangle(-1, -1, -1);
        });
        
        Assert.Throws<IncorrectTriangleDataException>(() =>
        {
            var wrongTriangle = new Triangle(-1, 1, 1);
        });
        
        Assert.Throws<IncorrectTriangleDataException>(() =>
        {
            var wrongTriangle = new Triangle(1, -1, 1);
        });
        
        Assert.Throws<IncorrectTriangleDataException>(() =>
        {
            var wrongTriangle = new Triangle(1, 1, -1);
        });
    }
}