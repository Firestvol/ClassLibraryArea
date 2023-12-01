﻿namespace ClassLibraryArea
{
    public class Geometry
    {

        //Не понял как можно поределить площадь фигуры не зная типа.
        //Если на вход 1 переменная то это радиус для площади круга, если три стороны
        //То это для площади треугольника. Если две то для прямоугольника.
        // Также не понял,что значит легкое добавление фигуры.
        // Класс легко можно дописать и будет еще дополнительная фигура, у которой измеряется площадь.

        public static double CircleArea(double radius)//возвращает площадь круга
        {
            const double PI = 3.1415926535897931;
            double Area = PI * radius * radius;
            return Area;
        }
        public static double TriangleArea(double a, double b, double c) //Возвращает или площадь треугольника или -1, в случае если треугольник не существует
        {
            if ((a + b > c) && (b + c > a) && (a + c > b))//проверка на то существует ли треугольник
            {
                double p = (a + b + c) / 2; // полупериметр
                double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //Формула Герона для нахождения площади треугольника по трем сторонам
                return Area;
            }
            else
            {
                return -1; //Треугольник с такими сторонами не существует
            }

        }

        public static bool SquareTypeOrNot(double a,double b,double c)//возвращает true если прямоугольный и false если нет. Проверки на существование треугольника нет.
        {
            if(a*a + b*b == c * c)//теорема Пифагора. Если суммы квадратов двух сторон равны квадрату третьей стороны, то трегольник прямоугольный
            {
                return true;
            }
            else
            {
                return false;
            }
                       
        }
    }
}