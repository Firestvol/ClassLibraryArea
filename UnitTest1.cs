using ClassLibraryArea;
using System.Diagnostics;

namespace TestProject1
{
    public class GeometryTests
    {
        [Fact]
        public void CircleArea_1_314()
        {
            double r = 1;
            double expected = 3.141592653589793;
            double actual = Geometry.CircleArea(r);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CircleArea_2_125()
        {
            double r = 2;
            double expected = 12.566370614359172;
            double actual = Geometry.CircleArea(r);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleArea_3_3_3_389()
        {
            double a = 3;
            double b = 3;
            double c = 3;
            double expected = 3.897114317029974;
            double actual = Geometry.TriangleArea(a,b,c);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TriangleArea_1_20_1_error()
        {
            double a = 1;
            double b = 20;
            double c = 1;
            double expected = -1;
            double actual = Geometry.TriangleArea(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SquareTypeOrNot_3_3_3_false()
        {
            double a = 3;
            double b = 3;
            double c = 3;
            bool expected = false;
            bool actual = Geometry.SquareTypeOrNot(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SquareTypeOrNot_3_4_5_true()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            bool actual = Geometry.SquareTypeOrNot(a, b, c);
            Assert.Equal(expected, actual);
        }

    }
}