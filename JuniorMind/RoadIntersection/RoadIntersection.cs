using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RoadIntersection
{
    [TestClass]
    public class RoadIntersection
    {

        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        [TestMethod]
        public void ChecksIfRoadMovementWorks()
        {
            Point a = new Point(3, 0);
            RoadMovement('U', ref a);
            RoadMovement('D', ref a);
            RoadMovement('L', ref a);
            RoadMovement('U', ref a);
            Assert.AreEqual(new Point(4, -1), a);
        }

        public void RoadMovement(char direction, ref Point piece)
        {
            switch (direction)
            {
                case 'U':
                    piece = new Point(piece.x + 1, piece.y);
                    break;

                case 'D':
                    piece = new Point(piece.x - 1, piece.y);
                    break;

                case 'L':
                    piece = new Point(piece.x, piece.y - 1);
                    break;

                case 'R':
                    piece = new Point(piece.x, piece.y + 1);
                    break;
            }

        }

        public Point ReturnsTheIntersectionPoint(string road)
        {
            Point origin = new Point(0, 0);
            Point[] segment = { origin };
            Point movement = segment[segment.Length - 1];

            for (int i = 0; i < road.Length; i++)
            {
                RoadMovement(road[i], ref movement);
                if (CheckCrossroads(ref movement, ref segment))
                {
                    return movement;
                }
                else
                {
                    Array.Resize(ref segment, segment.Length + 1);
                    segment[segment.Length - 1] = movement;
                }
            }
            return origin;
        }

        [TestMethod]
        public void ChecksIfTheTheCheckerWorks()
        {
            Point a = new Point(2, 3);
            Point b = new Point(4, 5);
            Point[] c = { a, b };
            Assert.IsTrue(CheckCrossroads(ref a, ref c));
        }

        bool CheckCrossroads(ref Point movement, ref Point[] segment)
        {
            for (int i = 0; i < segment.Length; i++)
            {
                if (movement.x == segment[i].x && movement.y == segment[i].y)
                    return true;
            }
            return false;
        }
    }
}
