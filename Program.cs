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
            Console.WriteLine("Введите число: ");
            long longnumber = long.Parse(Console.ReadLine());

            #endregion
        }
    }
}
