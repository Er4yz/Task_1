using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Блок 1: Консольный ввод-вывод и базовые вычисления.

            Console.WriteLine("//1. Напишите программу, которая запрашивает у пользователя фамилию, имя и отчество по отдельности, а затем выводит их одной строкой в формате: Фамилия И. О..");

            Console.Write("Введите Фамилию: ");
            string surname = Convert.ToString(Console.ReadLine());

            Console.Write("Введите имя: ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите Отчество: ");
            string patronymic = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"{surname}. {name[0]}. {patronymic[0]}.\n");

            Console.WriteLine("//2. Запросите у пользователя два целых числа. Выведите их сумму, разность, произведение, а также целочисленное частное и остаток от деления.");

            Console.Write("Первое целое: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Второе целое: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int summ = number1 + number2;
            int diff = number1 - number2;
            int mult = number1 * number2;
            int div = number1 / number2;
            int rest = number1 % number2;
            Console.WriteLine($"Сумма: {summ}. Разность: {diff}. Произведение: {mult}. Целочисленное частное: {div}. Остаток от деления: {rest}.\n");

            Console.WriteLine("//3.Пользователь вводит температуру в градусах Цельсия. Переведите ее в градусы Фаренгейта по формуле: F=C×95+32.");

            Console.Write("Введите температуру в градусах цельсия: ");
            int C = Convert.ToInt32(Console.ReadLine());

            int F = C * 95 + 32;
            Console.WriteLine($"Температура в градусах Фаренгейта: {F}.\n");

            Console.WriteLine("//4. Запросите длину ребра куба. Рассчитайте объем куба и площадь его полной поверхности.");

            Console.Write("Введите длину ребра куба: ");
            double l = Convert.ToDouble(Console.ReadLine());

            double V = l * l * l;
            double S = 6 * l * l;

            Console.WriteLine($"Объем куба: {V}. Площадь его полной поверхности: {S}.\n");

            Console.WriteLine("//5. Запросите у пользователя количество секунд. Переведите это значение в часы, минуты и секунды (например, 3665 сек -> 1 ч, 1 мин, 5 сек).");

            Console.Write("Введите количество секунд: ");
            int Sec = Convert.ToInt32(Console.ReadLine());
            int hour = Sec / 3600;
            int minute = Sec / 3600 / 60;
            int sec = Sec % 60;
            Console.WriteLine($"{Sec} сек -> {hour} ч, {minute} мин, {sec} сек.\n");

            Console.WriteLine("//6. Реализуйте обмен значениями двух целочисленных переменных a и b, введенных с клавиатуры, сначала с использованием третьей переменной, затем без нее (арифметическим способом).");

            Console.Write("Введите целочисленную переменную a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целочисленную переменную b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            //Console.WriteLine($"Обмен с помощью третьей переменной: Переменная a: {a}. Переменная {b}.");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Обмен арифметическим способом: Переменная a: {a}. Переменная {b}.\n");

            Console.WriteLine("//7. Запросите три вещественных числа. Вычислите и выведите их среднее арифметическое с округлением до двух знаков после запятой.");

            Console.Write("Первое вещественное число: ");
            double one = Convert.ToDouble(Console.ReadLine());

            Console.Write("Второе вещественное число: ");
            double two = Convert.ToDouble(Console.ReadLine());

            Console.Write("Третье вещественное число: ");
            double three = Convert.ToDouble(Console.ReadLine());

            double arithmeticmean = (one + two + three) / 3;
            double roundarithmeticmean = Math.Round(arithmeticmean, 2);
            Console.WriteLine($"Среднее арифметическое: {roundarithmeticmean}.\n");

            Console.WriteLine("//8. Считайте расстояние в метрах и время в секундах. Рассчитайте и выведите скорость движения в км/ч.");

            Console.Write("Введите расстояние в метрах: ");
            double Skm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите время в секундах: ");
            double timesec = Convert.ToDouble(Console.ReadLine());

            double v = Skm / timesec;

            Console.WriteLine($"Скорость движения в км/ч: {v}\n");

            Console.WriteLine("//9. Запросите стоимость товара и процент скидки (от 0 до 100). Вычислите сумму скидки и итоговую цену товара с помощью типа decimal.");

            Console.Write("Введите стоимость товара: ");
            decimal priceproduct = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите процент скидки (от 0 до 100): ");
            decimal discount = Convert.ToDecimal(Console.ReadLine());

            decimal summdiscount = priceproduct * discount / 100;
            decimal resultpriceproduct = priceproduct - discount;

            Console.WriteLine($"Сумма скидки: {summdiscount}. Итоговая цена товара: {resultpriceproduct}.\n");

            Console.WriteLine("//10. Пользователь вводит баланс мобильного телефона и стоимость одной минуты разговора. Вычислите, сколько полных минут разговора доступно абоненту.");

            Console.Write("Введите баланс мобильного телефона: ");
            int balancephone = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите стоимость одной минуты разговора: ");
            int price1minutetalk = Convert.ToInt32(Console.ReadLine());

            int resultbalanceminute = balancephone / price1minutetalk;
            Console.WriteLine($"Абоненту доступно {resultbalanceminute} минут разговора.\n");
            #endregion

            #region Блок 2: Работа с типами данных и размером памяти.
            Console.WriteLine("//11. Напишите программу, которая с помощью оператора sizeof определяет и выводит размеры в байтах для типов: sbyte, short, int, long, float, double, decimal, char, bool. ");
            Console.WriteLine($"Размеры в байтах для: sbyte - {sizeof(sbyte)}. short - {sizeof(short)}. int - {sizeof(int)}. long - {sizeof(long)}. float - {sizeof(float)}. double - {sizeof(double)}. decimal - {sizeof(decimal)}. char - {sizeof(char)}. bool - {sizeof(bool)}.\n");

            Console.WriteLine("//12. Выведите на консоль минимальные и максимальные значения всех целочисленных типов, используя поля MinValue и MaxValue.");
            Console.WriteLine($"Минимальные и максимальные значения всех целочисленных: byte - min[{byte.MinValue}], max[{byte.MaxValue}]. sbyte - min[{sbyte.MinValue}], max[{sbyte.MaxValue}]. short - min[{short.MinValue}], max[{short.MaxValue}]. ushort - min[{ushort.MinValue}], max[{ushort.MaxValue}]. int - min[{int.MinValue}], max[{int.MaxValue}]. uint - min[{uint.MinValue}], max[{uint.MaxValue}]. loing - min[{long.MinValue}], max[{long.MaxValue}]. ulong - min[{ulong.MinValue}], max[{ulong.MaxValue}].\n");

            Console.WriteLine("//13. Продемонстрируйте эффект циклического переполнения (overflow): увеличьте значение переменной типа byte, равное 255, на 1 внутри блока unchecked и внутри блока checked.");
            byte bytenumber = 255;
            Console.WriteLine($"Исходное значение: {bytenumber}");
            unchecked
            {
                bytenumber = (byte)(bytenumber + 1);
            }
            Console.WriteLine($"Значение после unchecked: {bytenumber}");
            checked
            {
                bytenumber = (byte)(bytenumber + 1);
            }
            Console.WriteLine($"Значение после checked: {bytenumber}.\n");

            Console.WriteLine("//14. Считайте с клавиатуры строку, содержащую один символ. Определите код этого символа в кодировке Unicode и следующий за ним символ в таблице.");
            Console.Write("Введите один символ: ");
            string symbol = Convert.ToString(Console.ReadLine());
            char onesymbolinstring = symbol[0];
            int symbolint = (int)onesymbolinstring;
            char nextstring = (char)(symbolint + 1);
            Console.WriteLine($"Код символа: {symbolint}. Следующий символ: {nextstring}.\n");

            Console.WriteLine("//15. Напишите программу, которая запрашивает логическое значение (true/false) с клавиатуры с помощью bool.Parse и инвертирует его.");
            Console.Write("Введите true или false: ");
            string text = Convert.ToString(Console.ReadLine());
            bool booltext = bool.Parse(text);
            bool inverted = !booltext;
            Console.WriteLine($"Инвентированное значение: {inverted}.\n");

            Console.WriteLine("//16. Напишите программу, которая запрашивает число с плавающей запятой и выводит отдельно его целую и дробную части.");
            Console.Write("Введите число с плавающей запятой: ");
            double number = Convert.ToDouble(Console.ReadLine());
            int numbertoint = (int)number;
            double numberaftercomma = number - numbertoint;
            Console.WriteLine($"Целая часть числа: {numbertoint}. Дробная часть числа: {numberaftercomma}");

            Console.WriteLine("//17. Создайте переменные типов float и double, присвойте им значение 1.0/3.0 и выведите на экран с максимальным количеством знаков, чтобы показать разницу в точности.");
            float variable1 = 1.0f / 3.0f;
            double variable2 = 1.0 / 3.0;
            Console.WriteLine($"Float: {variable1.ToString("R")}. Double: {variable2.ToString("R")}.\n"); //В формате string удобнее на всё это посмотреть. "R" - показывает всё.

            Console.WriteLine("//18. Напишите программу, которая вычисляет разницу между операциями сложения над double и над decimal (сложите 0.1 десять раз и сравните результат с 1.0).");
            double doubleoperation = 0.1;
            decimal decimaloperation = 0.1m;
            double resultdoubleoperation = doubleoperation + doubleoperation + doubleoperation + doubleoperation + doubleoperation + doubleoperation + doubleoperation + doubleoperation + doubleoperation + doubleoperation;
            decimal resultdecimaloperation = decimaloperation + decimaloperation + decimaloperation + decimaloperation + decimaloperation + decimaloperation + decimaloperation + decimaloperation + decimaloperation + decimaloperation;
            Console.WriteLine($"Результат операции сложения double: {resultdoubleoperation} и 1.0. Результат операции сложения decimal: {resultdecimaloperation} и 1.0.\n");

            Console.WriteLine("//19. Считайте число типа long и определите, поместится ли оно в диапазон типа short без переполнения.");
            Console.Write("Введите число: ");
            long longnumber = long.Parse(Console.ReadLine());

            if (longnumber >= short.MinValue && longnumber <= short.MaxValue)
            {
                short shortnumber = (short)longnumber;
                Console.WriteLine($"Число в short: {shortnumber}");
            }
            else
            {
                Console.WriteLine($"Произошло переполнение! Диапазон short равен от {short.MinValue} до {short.MaxValue}.\n");
            }

            Console.WriteLine("//20. Запросите у пользователя символ цифровой клавиши (от '0' до '9') и преобразуйте его в соотвествующее целочисленное значение (int) без использования строк.");
            Console.Write("Введиет символ цифровой клавиши (от '0' до '9'): ");
            char symbolinchar = Convert.ToChar(Console.ReadLine());

            if (symbolinchar >= '0' && symbolinchar <= '9')
            {
                int digit = symbolinchar - '0';
                Console.WriteLine($"Символ: {symbolinchar}. Число: {digit}.");
            }
            #endregion

            #region Блок 3: Константы и математические формулы.
            Console.WriteLine("//21. Объявите константу гравитационного ускорения g = 9.80665. Запросите массу тела и высоту. Вычислите потенциальную энергию тела: E = m * g * h.");
            const double g = 9.80665;
            Console.Write("Введите массу тела: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту: ");
            double h = double.Parse(Console.ReadLine());
            double E = m * g * h;
            Console.WriteLine($"Потенциальаня энергия тела равна: {E}\n");

            Console.WriteLine("//22. Объявите константу числа Pi. Рассчитайте объем и площадь поверхности сферы по заданному радиусу.");
            const double Pi = 3.141592653589793;
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double V = 4 / 3 * Pi * radius * radius * radius;
            double S = 4 * Pi * radius * radius;
            Console.WriteLine($"объем поверхности сферы: {V} и площадь {S}.\n");

            Console.WriteLine("//23. С помощью констант дней недели (1 — Понедельник, 7 — Воскресенье) и введенного номера дня выведите название дня недели.");
            const string Monday = "Понедельник";
            const string Tuesday = "Вторник";
            const string Wednesday = "Среда";
            const string Thursday = "Четверг";
            const string Friday = "Пятница";
            const string Saturday = "Суббота";
            const string Sunday = "Воскресенье";
            Console.Write("Введите число от 1 до 7: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine(Monday);
            }
            else if (num == 2)
            {
                Console.WriteLine(Tuesday);
            }
            else if (num == 3)
            {
                Console.WriteLine(Wednesday);
            }
            else if (num == 4)
            {
                Console.WriteLine(Thursday);
            }
            else if (num == 5)
            {
                Console.WriteLine(Friday);
            }
            else if (num == 6)
            {
                Console.WriteLine(Saturday);
            }
            else if (num == 7)
            {
                Console.WriteLine(Sunday);
            }
            else
            {
                Console.WriteLine("Введите число строго по заданию!\n");
            }

            Console.WriteLine("//24. Запросите координаты двух точек на плоскости x1, y1 и x2, y2. Вычислите расстояние между ними по евклидовой метрике.");
            Console.Write("Введите точку x1 на плоскости: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите точку y1 на плоскости: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите точку x2 на плоскости: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите точку y2 на плоскости: ");
            int y2 = int.Parse(Console.ReadLine());
            double d = Math.Sqrt((x2 - x1) * 2 + (y2 - y1) * 2);
            Console.WriteLine($"Расстояние между ними по евклидовой метрике равна {d}.\n");

            Console.WriteLine("//25. Объявите константу базовой процентной ставки банка. Запросите сумму вклада и срок в месяцах. Рассчитайте сумму простых процентов: I = P * r * t / 12.");
            const int precent = 5;
            Console.Write("Введите сумму вклада: ");
            int summcontribution = int.Parse(Console.ReadLine());
            Console.Write("Введите срок в месяцах: ");
            int periodmouth = int.Parse(Console.ReadLine());
            decimal summsimpleprecent = precent * summcontribution * periodmouth / 12;
            Console.WriteLine($"Сумма простых процентов составляет {summsimpleprecent}.\n");

            Console.WriteLine("//26. Запросите катеты прямоугольного треугольника. Вычислите гипотенузу и радиус вписанной окружности: r = a + b - c / 2.");
            Console.Write("Введите один катет прямоугольного треугольника: ");
            int cathet1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второй катет прямоугольного треугольника: ");
            int cathet2 = int.Parse(Console.ReadLine());
            double hupotenuse = Math.Sqrt((cathet1 * cathet1) + (cathet2 * cathet2));
            double radiuscircle = cathet1 + cathet2 - hupotenuse / 2;
            Console.WriteLine($"Гипотенуза равна {hupotenuse}, а радиус вписанной окружности равен {radiuscircle}.\n");

            Console.WriteLine("//27. Задайте константу скорости света c = 299792458 м/с. Запросите массу в килограммах и рассчитайте эквивалентную энергию по формуле E = m * c * c. (используйте подходящий тип данных во избежание переполнения).");
            const int thespeedoflight = 299792458;
            Console.Write("Введите массу в килограммах: ");
            int mkg = int.Parse(Console.ReadLine());
            int ecvivaletEnergy = mkg * thespeedoflight * thespeedoflight;
            Console.WriteLine($"Эквивалентная энергия равна {ecvivaletEnergy}.\n");

            Console.WriteLine("//28. Рассчитайте индекс массы тела (ИМТ) по формуле: BMI = вес / рост * рост, где вес задан в кг, а рост - в метрах.");
            Console.Write("Введите вес в кг: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Введите рост в метрах: ");
            int height = int.Parse(Console.ReadLine());
            int BIM = weight / height * height;
            Console.WriteLine($"Индекс массы тела по ИМТ равен {BIM}.\n");

            Console.WriteLine("//29. Объявите константы перевода единиц: дюймы в сантиметры, футы в метры, фунты в килограммы. Считайте значения в англо-американской системе и выведите в метрической.");
            const double inchtocm = 2.54;
            const double feettom = 0.3048;
            const double poundtokg = 0.45359237;
            Console.Write("Введите кол-во дюймов: ");
            double inch = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во футов: ");
            double feet = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во фунтов: ");
            double pound = int.Parse(Console.ReadLine());
            double inchTocentimeters = inch * inchtocm;
            double feetTometers = feet * feettom;
            double poundTokg = pound * poundtokg;
            Console.WriteLine($"Дюймы в см: {inchTocentimeters}, футы в метры: {feetTometers}, фунты в кг: {poundTokg}.\n");

            Console.WriteLine("//30. Запросите коэффициент сопротивления и силу тока. Используя закон Ома и константу времени, рассчитайте выделившееся количество теплоты по закону Джоуля-Ленца (Q = I * I / R / t).");
            Console.Write("Введите коэффициент сопротивления: ");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Введите силу тока: ");
            int I = int.Parse(Console.ReadLine());
            Console.Write("Введите время: ");
            int t = int.Parse(Console.ReadLine());
            int Q = I * I / R / t;
            Console.WriteLine($"Выделившееся кол-во теплоты по закону Джоуля-Ленца равно {Q}");
            #endregion

            #region Блок 4: Явное и неявное приведение, парсинг и валидация.

            #endregion
        }
    }
}
