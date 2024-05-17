using NUnit.Framework;
using MatrixCalculator;

[TestFixture]
public class SquareMatrixTests
{
    [Test]
    public void TestAddition()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);
        SquareMatrix result = sm1 + sm2;

        int[,] expected = { { 6, 8 }, { 10, 12 } };
        Assert.AreEqual(expected, (int[,])result);
    }

    [Test]
    public void TestMultiplication()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);
        SquareMatrix result = sm1 * sm2;

        int[,] expected = { { 19, 22 }, { 43, 50 } };
        Assert.AreEqual(expected, (int[,])result);
    }

    [Test]
    public void TestDeterminant()
    {
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm = new SquareMatrix(matrix);
        double result = sm.Determinant();

        Assert.AreEqual(-2, result);
    }

    [Test]
    public void TestInverse()
    {
        int[,] matrix = { { 2, -1 }, { -1, 1 } };
        SquareMatrix sm = new SquareMatrix(matrix);
        SquareMatrix result = sm.Inverse();

        int[,] expected = { { 1, 1 }, { 1, 2 } };
        Assert.AreEqual(expected, (int[,])result);
    }

    [Test]
    public void TestGreaterThan()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 1, 1 }, { 1, 1 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.IsTrue(sm1 > sm2);
    }

    [Test]
    public void TestLessThan()
    {
        int[,] matrix1 = { { 1, 1 }, { 1, 1 } };
        int[,] matrix2 = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.IsTrue(sm1 < sm2);
    }

    [Test]
    public void TestGreaterOrEqual()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.IsTrue(sm1 >= sm2);
    }

    [Test]
    public void TestLessOrEqual()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.IsTrue(sm1 <= sm2);
    }

    [Test]
    public void TestEquality()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.IsTrue(sm1 == sm2);
    }

    [Test]
    public void TestInequality()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 1, 2 }, { 3, 5 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.IsTrue(sm1 != sm2);
    }

    [Test]
    public void TestToString()
    {
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm = new SquareMatrix(matrix);
        string result = sm.ToString();

        string expected = "1 2 \n3 4 \n";
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestCompareTo()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 1, 1 }, { 1, 1 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.AreEqual(1, sm1.CompareTo(sm2));
    }

    [Test]
    public void TestEquals()
    {
        int[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        int[,] matrix2 = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm1 = new SquareMatrix(matrix1);
        SquareMatrix sm2 = new SquareMatrix(matrix2);

        Assert.IsTrue(sm1.Equals(sm2));
    }

    [Test]
    public void TestGetHashCode()
    {
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm = new SquareMatrix(matrix);
        int result = sm.GetHashCode();

        Assert.IsTrue(result >= 0);
    }

    [Test]
    public void TestDeepClone()
    {
        int[,] matrix = { { 1, 2 }, { 3, 4 } };
        SquareMatrix sm = new SquareMatrix(matrix);
        SquareMatrix clone = sm.DeepClone();

        Assert.AreEqual(sm, clone);
        Assert.AreNotSame(sm, clone);
    }