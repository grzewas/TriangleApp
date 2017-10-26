using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleMath
{
    class Point
    {
        public double coordinateX;
        public double coordinateY;

        public Point()
        {
            coordinateX = 1;
            coordinateY = 1;
        }

        public Point(double coordinateX, double coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }
    }

    class Triangle
    {
        double edgeOne;
        double edgeTwo;
        double edgeThree;
        
        public Triangle()
        {
            edgeOne = 1;
            edgeTwo = 2;
            edgeThree = 3;
        }

        public Triangle(double edgeOne, double edgeTwo, double edgeThree)
        {
            this.edgeOne = edgeOne;
            this.edgeTwo = edgeTwo;
            this.edgeThree = edgeThree;
        }

        public Triangle(Triangle T)
        {
            this.edgeOne = T.edgeOne;
            this.edgeTwo = T.edgeTwo;
            this.edgeThree = T.edgeThree;
        }

        public Triangle(Point vertexOne, Point vertexTwo, Point vertexThree)
        {
            this.edgeOne = Math.Sqrt((vertexOne.coordinateX - vertexTwo.coordinateX) * (vertexOne.coordinateX - vertexTwo.coordinateX) + (vertexOne.coordinateY - vertexTwo.coordinateY) * (vertexOne.coordinateY - vertexTwo.coordinateY));
            this.edgeTwo = Math.Sqrt((vertexThree.coordinateX - vertexTwo.coordinateX) * (vertexThree.coordinateX - vertexTwo.coordinateX) + (vertexThree.coordinateY - vertexTwo.coordinateY) * (vertexThree.coordinateY - vertexTwo.coordinateY));
            this.edgeThree = Math.Sqrt((vertexOne.coordinateX - vertexThree.coordinateX) * (vertexOne.coordinateX - vertexThree.coordinateX) + (vertexOne.coordinateY - vertexThree.coordinateY) * (vertexOne.coordinateY - vertexThree.coordinateY));
        }

        public double TrianglePerimeter()
        {
            double perimeter = edgeOne + edgeTwo + edgeThree;
            return perimeter;
        }

        public double TriangleArea()
        {
            double p = (edgeOne + edgeTwo + edgeThree) / 2.0;
            double area = Math.Sqrt(p * (p - edgeOne) * (p - edgeTwo) * (p - edgeThree));
            return area;
        }
    }
}
