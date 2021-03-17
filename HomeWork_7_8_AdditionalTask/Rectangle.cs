using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_7_8;

namespace HomeWork_7_8
{
    //Создать класс с несколькими свойствами. Реализовать перегрузку операторов ==, != и Equals.
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }

        public int area;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
            area = width * height;
            if (width == 0 || height == 0)
            {
                throw new Exception("сторона прямоугольника не может быть равна нулю");
            }
        }

        public static bool operator ==(Rectangle obj1, Rectangle obj2)
        {
            return (obj1.width == obj2.width && obj1.height == obj2.height);
        }

        public static bool operator !=(Rectangle obj1, Rectangle obj2)
        {
            return (obj1.width != obj2.width || obj1.height != obj2.height);
        }

        public override bool Equals(Object obj)
        {
            Rectangle rect = (Rectangle)obj;
            return (rect.area == this.area);
        }




    }
}
