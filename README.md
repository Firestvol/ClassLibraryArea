// ClassLibraryArea
Документация
В библиотеке присутствует 1 класс Geometry, в котором находится 3 метода для нахождения площади круга, площади трегольника и определения прямоугольный треугольник или нет.
double CircleArea(double radius) - возвращает площадь круга в зависимости от входного радиуса.    
double TriangleArea(double a, double b, double c) - возвращает площадь треугольнка по трем сторонам с помощью формулы Герона, или возвращает -1 в случае,если треугольник с данными сторонами не существует.   
bool SquareTypeOrNot(double a,double b,double c) - возвращает true если прямоугольный и false если нет с помощью теоремы Пифагора. Проверки на существование треугольника нет.
