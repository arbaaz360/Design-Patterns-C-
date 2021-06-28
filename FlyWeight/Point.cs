using System;
using System.Collections.Generic;

namespace FlyWeight
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public PointIcon icon {get;set;}

        public Point(int x, int y, PointIcon icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
        }

        public  void draw()
        {
            Console.WriteLine(x+y+Convert.ToString(icon));
        }
    }

    public class PointIcon
    {
        public PointIconEnum iconType { get; set; }
        public byte[] icon { get; set; }

        public PointIcon(PointIconEnum iconType)
        {
            this.iconType = iconType;
        }
    }

    public class PointFactory
    {
        private PointIconEnum iconType;

       public PointIcon getPointIcon(PointIconEnum iconType)
        {
            if (iconType == PointIconEnum.Gym) return null;
            else return null;
        }
    }
    public class PointService
    {
        private PointFactory iconFactory { get; set; }

        public PointService(PointFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> getPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, iconFactory.getPointIcon(PointIconEnum.Gym));
            points.Add(point);
            return points;
        }
    }
    public enum PointIconEnum
    {
        House,
        Office,
        Gym,
        Library
    }
}
