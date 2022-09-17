// ---------------------------------------------------------------------
//                                 Задача 43(+)
// * Найдите площадь треугольника образованного пересечением 3 прямых
// ---------------------------------------------------------------------

// Чтение данных из консоли
double ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    double number = double.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Поиск точки пересечения двух прямых
double[] PointFind(double k1, double b1, double k2, double b2)
{
    double[] outtArr = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    outtArr[0] = x;
    outtArr[1] = y;
    return outtArr;
}

// Нахождение длины отрезка по двум точкам
double Segment(double[] pointA, double[] pointB)
{
    return Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2));
}

// Нахождение площади треугольника
double SquareTriangle(double AB, double BC, double CA)
{
    double p = (AB + BC + CA) / 2;
    return Math.Round(Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA)), 2);
}

// Нахождение площади треугольника по кординатам вершин
double SquareTriangleWithPoint(double[] pointA, double[] pointB, double[] pointC)
{
    return Math.Abs((pointB[0] - pointA[0]) * (pointC[1] - pointA[1]) - (pointC[0] - pointA[0]) * (pointB[1] - pointA[1])) / 2;
}

double k1 = ReadData("Введите k1: ");
double b1 = ReadData("Введите b1: ");
double k2 = ReadData("Введите k2: ");
double b2 = ReadData("Введите b2: ");
double k3 = ReadData("Введите k3: ");
double b3 = ReadData("Введите b3: ");

double[] pointA = PointFind(k1, b1, k2, b2);
double[] pointB = PointFind(k1, b1, k3, b3);
double[] pointC = PointFind(k3, b3, k2, b2);

double AB = Segment(pointA, pointB);
double BC = Segment(pointC, pointB);
double CA = Segment(pointA, pointC);
// PrintResult("AB ", AB.ToString());
// PrintResult("BC ", BC.ToString());
// PrintResult("CA ", CA.ToString());

double square = SquareTriangle(AB, BC, CA);
double squarePoint = SquareTriangleWithPoint(pointA, pointB, pointC);

PrintResult("Площадь треугольника равна: ", square.ToString());
PrintResult("Площадь треугольника равна (Второй вариант): ", squarePoint.ToString());