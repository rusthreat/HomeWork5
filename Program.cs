using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_005
{
    class Program
    {
        static string str;
        static Random random = new Random();

        #region Задание 1 (матрицы из 4-го модуля)          
        // Задание 1.
        // Используется решение: 3-го задания четвертого модуля
        // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        // 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
        // 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
        //

        /// <summary>
        /// Метод, генерирующий матрицу заданного размера
        /// </summary>
        static int[][] GetMatrix(int n, int m)
        {
            int[][] Matrix = new int[n][];

            // формирование начальной матрицы
            for (int j = 0; j < n; j++)
            {
                Matrix[j] = new int[m];

                for (int i = 0; i < m; i++)
                {
                    Matrix[j][i] = random.Next(1, 10);
                }
            }

            return Matrix;
        }

        /// <summary>
        /// Метод, принимающий число и матрицу, возвращающий результат их умножения
        /// </summary>
        static int[][] MultMatrixByNumber(int a, int[][] Array)
        {
            // Определение размера входящего массива
            int n = Array.Length;
            int m = Array[0].Length;

            // объявление итоговой матрицы
            int[][] Total = new int[n][];
            // 

            for (int j = 0; j < n; j++)
            {
                Total[j] = new int[m];

                for (int i = 0; i < m; i++)
                {
                    Total[j][i] = Array[j][i] * a;
                }
            }

            return Total;
        }

        /// <summary>
        /// Метод, принимающий 2 матрицы и возвращающий результат их сложения или вычитания
        /// flag = 0 - сложение
        /// flag = 1 - вычитание
        /// </summary>
        static int[][] MatrixAddition(int flag, int[][] Array1, int[][] Array2)
        {
            // Определение размера входящей матрицы
            int n = Array1.Length;
            int m = Array1[0].Length;

            // объявление итоговой матрицы
            int[][] Total = new int[n][];

            for (int j = 0; j < n; j++)
            {
                Total[j] = new int[m];

                for (int i = 0; i < m; i++)
                {
                    if (flag == 0)
                    {
                        Total[j][i] = Array1[j][i] + Array2[j][i];
                    }
                    else 
                    {
                        Total[j][i] = Array1[j][i] - Array2[j][i];
                    }
                }
            }
            return Total;
        }

        /// <summary>
        /// Метод, принимающий 2 матрицы, возвращающий результат их умножения
        /// </summary>
        static int[][] MatrixMultiplication(int[][] Array1, int[][] Array2)
        {
            // Определение размера входящих матриц
            int n1 = Array1.Length;
            int m1 = Array1[0].Length;
            int n2 = Array2.Length;
            int m2 = Array2[0].Length;
            // объявление итоговой матрицы
            int[][] Total = new int[n1][];

            // Расчет умножения
            for (int j = 0; j < n1; j++)
            {
                Total[j] = new int[m2];

                for (int i = 0; i < m2; i++)
                {
                    int sum = 0;

                    for (int k = 0; k < m1; k++)
                    {
                        sum = sum + (Array1[j][k] * Array2[k][i]);
                    }

                    Total[j][i] = sum;
                }
            }

            return Total;
        }

        /// <summary>
        /// Метод, выводящий переданный массив на экран
        /// </summary>
        static void PrintMatrix(int[][] Array)
        {
            // Определение размера входящего массива
            int n = Array.Length;
            int m = Array[0].Length;

            for (int j = 0; j < n; j++)
            {
                Console.Write("\n|");

                for (int i = 0; i < m; i++)
                {
                    Console.Write($"{Array[j][i],4:0}");
                }

                Console.Write("  |");
            }
        }

        /// <summary>
        /// Задание 1. Метод для выполнения арифметических операций с матрицами
        /// </summary>
        static void Matrix()
        {
            // Меню первого задания
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание 1. Выберите задание:");
                Console.WriteLine("1 - Задание 1.1. (Умножение числа на матрицу)");
                Console.WriteLine("2 - Задание 1.2. (Суммирование матриц)");
                Console.WriteLine("3 - Задание 1.3. (Умножение матриц)");
                int item = int.Parse(Console.ReadLine());

                #region Задание 3.1. Умножение матрицы на число
                // 
                // * Задание 3.1
                // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
                // Добавить возможность ввода количество строк и столцов матрицы и число,
                // на которое будет производиться умножение.
                // Матрицы заполняются автоматически. 
                // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
                //
                // Пример
                //
                //      |  1  3  5  |   |  5  15  25  |
                //  5 х |  4  5  7  | = | 20  25  35  |
                //      |  5  3  1  |   | 25  15   5  |
                //
                
                if (item == 1)
                {
                    Console.WriteLine("3.1. Умножение матрицы на число");

                    // запрос размера матрицы
                    Console.WriteLine("\nУкажите число строк: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Укажите число столбцов: ");
                    int m = Convert.ToInt32(Console.ReadLine());

                    // объявление начальной матрицы
                    int[][] Array = GetMatrix(n, m);

                    Console.WriteLine("Укажите число-множитель: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    // обращение к методу, выполняющему умножение
                    int[][] Total = MultMatrixByNumber(a, Array);

                    // вывод результата
                    // поиск строки, на которой будет выведен множитель
                    int a_output = (n % 2 == 0)?(n / 2):((n + 1) / 2);

                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine();

                        // вывод множителя
                        if (a_output - 1 == j)
                        {
                            Console.Write($"{a,5:0} * |");
                        }
                        else
                        {
                            Console.Write($"        |");   
                        }

                        // вывод начальной таблицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array[j][i],3:0}");
                        }
                        
                        if (a_output - 1 == j)
                        {
                            Console.Write($" | = |");
                        }
                        else
                        {
                            Console.Write($" |   |");   
                        }
                        
                        // вывод итоговой таблицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Total[j][i],3:0}");
                        }

                        Console.Write($" |");
                    }
                }
                #endregion

                #region Задание 3.2. Сложение и вычитание матриц
                //
                // ** Задание 3.2
                // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
                // Добавить возможность ввода количество строк и столцов матрицы.
                // Матрицы заполняются автоматически
                // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
                //
                // Пример
                //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
                //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
                //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
                //  
                //  
                //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
                //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
                //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
                //
                
                else if (item == 2)
                {
                    int n;
                    int m;
                    
                    while (true)
                    {
                        Console.WriteLine("3.2. Сложение и вычитание матриц");
                        
                        // запрос размера матрицы
                        Console.WriteLine("\nУкажите число строк: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите число столбцов: ");
                        m = Convert.ToInt32(Console.ReadLine());

                        if (n != m)
                        {
                            Console.WriteLine("Складывать и вычитать можно только матрицы одинакового размера.");
                            Console.WriteLine("Попробуйте еще раз.\n");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }   
                    
                    // объявление 1-й матрицы
                    int[][] Array1 = GetMatrix(n, m);

                    // объявление 2-й матрицы
                    int[][] Array2 = GetMatrix(n, m);

                    // расчет 1-й итоговой матрицы
                    int[][] Total1 = MatrixAddition(0, Array1, Array2);

                    // объявление 2-й итоговой матрицы
                    int[][] Total2 = MatrixAddition(1, Array1, Array2);

                    // вывод результата
                    // поиск строки, на которой будут выводится знаки
                    int a_output = (n % 2 == 0)?(n / 2):((n + 1) / 2);
                    
                    Console.WriteLine();

                    // вывод операции сложения
                    Console.WriteLine("Сложение:");
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("\n|");
                        
                        // вывод первой начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array1[j][i],3:0}");
                        }
                        
                        // вывод знака сложения
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | + |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }

                        // вывод второй начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array2[j][i],3:0}");
                        }
                        
                        // вывод знака равенства
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | = |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }
                        
                        // вывод итоговой матрицы сложения
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Total1[j][i],3:0}");
                        }

                        Console.Write($" |");

                    }
                    Console.WriteLine("\n");

                    // вывод операции вычитания
                    Console.WriteLine("Вычитание:");

                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("\n|");
                        
                        // вывод первой начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array1[j][i],3:0}");
                        }
                        
                        // вывод знака вычитания
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | - |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }

                        // вывод второй начальной матрицы
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Array2[j][i],3:0}");
                        }
                        
                        // вывод знака равенства
                        if (a_output - 1 == j)
                        {
                            Console.Write(" | = |");
                        }
                        else
                        {
                            Console.Write(" |   |");   
                        }
                        
                        // вывод итоговой матрицы вычитания
                        for (int i = 0; i < m; i++)
                        {
                            Console.Write($"{Total2[j][i],3:0}");
                        }

                        Console.Write($" |");
                    }
                }
                #endregion

                #region Задание 3.3. Умножение матриц
                // *** Задание 3.3
                // Заказчику требуется приложение позволяющщее перемножать математические матрицы
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
                // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
                // Добавить возможность ввода количество строк и столцов матрицы.
                // Матрицы заполняются автоматически
                // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
                //  
                //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
                //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
                //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
                //
                //  
                //                  | 4 |   
                //  |  1  2  3  | х | 5 | = | 32 |
                //                  | 6 |  
                //
                
                else if (item == 3)
                {
                    int n1;
                    int n2;
                    int m1;
                    int m2;
                    
                    while (true)
                    {
                        Console.WriteLine("3.3. Умножение матриц");
                        
                        // запрос размера 1-й матрицы
                        Console.WriteLine("\nУкажите число строк 1-й матрицы: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите число столбцов 1-матрицы: ");
                        m1 = Convert.ToInt32(Console.ReadLine());

                        // запрос размера 2-й матрицы
                        Console.WriteLine("Укажите число строк 2-й матрицы: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Укажите число столбцов 2-матрицы: ");
                        m2 = Convert.ToInt32(Console.ReadLine());

                        if (m1 != n2)
                        {
                            Console.WriteLine("Число столбцов 1-й матрицы должно быть равно числу строк 2-й матрицы.");
                            Console.WriteLine("Попробуйте еще раз.\n");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }   
                    
                    // получение 1-й матрицы
                    int[][] Array1 = GetMatrix(n1, m1);

                    // получение 2-й матрицы
                    int[][] Array2 = GetMatrix(n2, m2);

                    // объявление итоговой матрицы
                    int[][] Total = MatrixMultiplication(Array1, Array2);

                    // Вывод результата
                    Console.WriteLine("\nМатрица 1:");
                    PrintMatrix(Array1);

                    Console.WriteLine("\n\nМатрица 2:");
                    PrintMatrix(Array2);

                    Console.WriteLine("\n\nИтог умножения матриц:");
                    PrintMatrix(Total);
                }
                #endregion

                else
                {
                    Console.WriteLine("Укажите верное значение");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("\n\nВернуться в меню Задания 1? y/n");
                str = Console.ReadLine();

                if (str == "y")
                {
                    continue;
                }
                else
                {
                    break; 
                }
            }
        }
        #endregion

        #region Задание 2 (поиск самого длинного и короткого слова)          
        // Задание 2.
        // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
        // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
        // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
        // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
        // 1. Ответ: А
        // 2. ГГГГ, ДДДД
        //

        /// <summary>
        /// Задание 2.1. Метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
        /// </summary>
        /// 
        static string GetShortWord(string text)
        {
            string short_word = text;
            string new_word = "";



            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' || new_word != "")
                {
                    if (new_word.Length < short_word.Length)
                    {
                        short_word = new_word;
                    }
                    new_word = "";
                }
                else
                {
                    new_word = new_word + text[i];
                }

            }

            // обработка ситуации, когда самое короткое слово - последнее
            if (new_word.Length < short_word.Length)
            {
                return new_word;
            }
            else
            {
                return short_word;
            }
        }

        /// <summary>
        /// Задание 2.2. Метод, принимающий  текст и возвращающий самые длинные слова
        /// </summary>
        /// 
        static string[] GetLongWords(string text)
        {
            // разделение строки на слова методом Split
            string[] array = text.Split(new char[] { ' ',',','.'}, StringSplitOptions.RemoveEmptyEntries);

            int len = 0;

            // поиск максимальной длины
            for (int i = 0; i < array.Length; i++)
            {
                if (len < array[i].Length)
                {
                    len = array[i].Length;
                }
            }
            Console.WriteLine(len);

            string[] result = new string[1];
            int n = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (len == array[i].Length)
                {
                    result[n] = array[i];
                    n++;
                    Array.Resize(ref result, n+1);

                }
            }

            return result;
        }

        /// <summary>
        /// Задание 2. Метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
        /// </summary>
        static void LengthSearch()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание 2. Выберите задание:");
                Console.WriteLine("1 - Задание 2.1. (Поиск самого короткого слова)");
                Console.WriteLine("2 - Задание 2.2. (Удаление лишних букв в словах)");
                int item = int.Parse(Console.ReadLine());

                if (item == 1)
                {
                    Console.WriteLine("Введите строку:");
                    string text = Console.ReadLine();

                    text = GetShortWord(text);

                    Console.WriteLine($"\nСамое короткое слово: {text}");
                }
                else if (item == 2)
                {
                    Console.WriteLine("Введите строку:");
                    string text = Console.ReadLine();

                    string[] array = GetLongWords(text);

                    Console.WriteLine($"Самые длинные слова:");
                    foreach(string word in array)
                    {
                        Console.WriteLine(word);
                    }
                }
                else
                {
                    Console.WriteLine("Укажите верное значение");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("\n\nВернуться в меню Задания 2? y/n");
                str = Console.ReadLine();

                if (str == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        #endregion

        #region Задание 3 (удаление лишних букв)          
        // Задание 3. Создать метод, принимающий текст. 
        // Результатом работы метода должен быть новый текст, в котором
        // удалены все кратные рядом стоящие символы, оставив по одному 
        // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
        // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
        // 

        /// <summary>
        /// Задание 3. Метод, удаляющий лишние буквы в слове
        /// </summary>
        static string DeleteLetters(string text)
        {
            string str = "";
            char prev;
          
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    str = str + text[i];
                    prev = text[i];
                }
                else
                {
                    if (text[i] != text[i - 1])
                    {
                        str = str + text[i];
                    }
                }
            }
            return str;
        }

        static void ShortText()
        {
            Console.WriteLine("Задание 3. Выберите задание:");
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();

            text = DeleteLetters(text);

            Console.WriteLine($"\nРезультат: {text}");
        }
        #endregion

        #region Задание 4 (проверка на геом. прогрессию)          
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
        // является заданная последовательность элементами арифметической или геометрической прогрессии
        // 
        // Примечание
        //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
        //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
        //
        
        /// <summary>
        /// Задание 4. Метод, определяющий, является ли последовательность арифметической или геометрической
        /// </summary>
        static bool MathProgressionCheck(List<int> numbs)
        {
            if (numbs.Count <= 2)
            {
                return false;
            }

            // разность 
            int d = 1;

            for (int i = 1; i < numbs.Count; i++)
            {
                if (i == 1)
                {
                    d = numbs[i] - numbs[i - 1];
                }
                else
                {
                    if (d != numbs[i] - numbs[i - 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Задание 4. Метод, определяющий, является ли последовательность геометрической
        /// </summary>
        static bool GeomProgressionCheck(List<int> numbs)
        {
            if (numbs.Count <= 2)
            {
                return false;
            }

            // знаменатель 
            int d = 1;

            for (int i = 1; i < numbs.Count; i++)
            {
                if (i == 1)
                {
                    d = numbs[i] / numbs[i - 1];
                }
                else
                {
                    if (d != numbs[i] / numbs[i - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void ProgressionCheck()
        {
            Console.WriteLine("Задание 4. Проверка прогрессий");
            Console.WriteLine("\nУкажите количество чисел:");
            int q = Convert.ToInt32(Console.ReadLine());

            List<int> numbs = new List<int>();
            Console.WriteLine("\nВведите числа");

            for (int i = 0; i < q; i++)
            {
                numbs.Add(Convert.ToInt32(Console.ReadLine()));
            }

            // Проверка на арифметическую прогрессию
            bool m = MathProgressionCheck(numbs);

            if (m)
            {
                Console.WriteLine("\nЯвляется математической последовательностью");
            }
            else
            {
                Console.WriteLine("\nНе является математической последовательностью");
            }

            bool g = GeomProgressionCheck(numbs);
            if (g)
            {
                Console.WriteLine("\nЯвляется геометрической последовательностью");
            }
            else
            {
                Console.WriteLine("\nНе является геометрической последовательностью");
            }
        }
        #endregion

        #region Задание 5 (вычисление функции Аккермана)          
        // *Задание 5
        // Вычислить, используя рекурсию, функцию Аккермана:
        // A(2, 5), A(1, 2)
        // A(n, m) = m + 1, если n = 0,
        //         = A(n - 1, 1), если n <> 0, m = 0,
        //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
        // 
        // Весь код должен быть откоммментирован
        /// <summary>
        /// Задание 5. Расчет функции Аккермана
        /// </summary>
        public static int AkkermanFunctionCalc(int n, int m)
        {
            if (n == 0)
            {
                return (m + 1);
            }
            else if (n != 0 && m == 0)
            {
                return AkkermanFunctionCalc(n - 1, 1);
            }
            else 
            {
                return AkkermanFunctionCalc(n - 1, AkkermanFunctionCalc(n, m - 1));
            }
        }

        static void AkkermanFunction()
        {
            Console.WriteLine("Задание 5. Вычисление функции Аккермана A(n, m)");
            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Введите m:");
            int m = Convert.ToInt32(Console.ReadLine());

            int result = AkkermanFunctionCalc(n, m);
            Console.WriteLine($"\nРезультат расчета: {result}");
        }
        #endregion

        static void Main(string[] args)
        {
            // Домашнее задание
            // Требуется написать несколько методов
            //
            // меню для выбора решения
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Модуль 5. Выберите задание:");
                Console.WriteLine("1 - Задание 1 (матрицы из 4-го модуля)");
                Console.WriteLine("2 - Задание 2 (поиск самого длинного и короткого слова)");
                Console.WriteLine("3 - Задание 3 (удаление лишних букв)");
                Console.WriteLine("4 - Задание 4 (проверка на геом. прогрессию)");
                Console.WriteLine("5 - Задание 5 (вычисление функции Аккермана)");
                Console.WriteLine("6 - Выход");
                int item = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (item)
                {
                    case 1: Matrix(); break;
                    case 2: LengthSearch(); break;
                    case 3: ShortText(); break;
                    case 4: ProgressionCheck(); break;
                    case 5: AkkermanFunction(); break;
                    case 6: break;
                }
             
                Console.WriteLine("\n\nВернуться в главное меню? y/n");
                str = Console.ReadLine();

                if (str == "y")
                {
                    continue;
                }
                else
                {
                    break; 
                }
            }
        }
    }
}
