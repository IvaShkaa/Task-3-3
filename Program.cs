using System;
using System.Globalization;
using Задание_3_2.Interfaces;

public class Program
{
    static void Main(string[] args)
    {
        BaseArray[] Base_Array = new BaseArray[3];

        //Cоздание одномерного массива
        Console.WriteLine("Введите длинну Вашего одномерного массива: ");
        int Arr_Len = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _1DKeyboard_Input = bool.Parse(Console.ReadLine());  

        Base_Array[0] = new OneD_Array(Arr_Len, _1DKeyboard_Input);

        //Cоздание двумерного массива
        Console.WriteLine("Введите количество строк в вашем двумерном массиве:");
        int _2D_Arr_height = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов в вашем двумерном массиве:");
        int _2D_Arr_length = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _2DKeyboard_Input = bool.Parse(Console.ReadLine());

        Base_Array[1] = new TwoD_Array(_2D_Arr_length, _2D_Arr_height, _2DKeyboard_Input);

        //Создание ступенчатого массива
        Console.WriteLine("Введите количество подмассивов в вашем ступенчатом массиве:");
        int Step_Arr_length = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _SDKeyboard_Input = bool.Parse(Console.ReadLine());

        Base_Array[2] = new Step_Array(Step_Arr_length, _SDKeyboard_Input);

        //Вывод всего массива и его среднего значения
        for (int i = 0; i < Base_Array.Length; i++)
        {
            Console.WriteLine("Вывод массива:");
            Base_Array[i].Print();
            Console.WriteLine($"Среднее значение {Base_Array[i].Mid_Value()} ");
        }

        //Cоздание дня недели
        Задание_3_2.Calendar cal = new Задание_3_2.Calendar();

        //Создание массива всех ранее созданых объектов
        IPrint[] new_arr = new IPrint[4];
        new_arr[0] = Base_Array[0];
        new_arr[1] = Base_Array[1];
        new_arr[2] = Base_Array[2];
        new_arr[3] = cal;

        //Печать всех элементов из new_arr
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < new_arr.Length; i++)
        {
            Console.WriteLine("Печать элемента");
            new_arr[i].Print();
        }

        //Пересоздание внутреннего массива в каждом экземпляре класса
        //Вывод самого массива и его среднего
        Console.WriteLine("-----------------------------------");
        for (int i = 0; i < Base_Array.Length; i++)
        {
            Console.WriteLine("Вы хотите пересоздать массив с клавиатуры или автоматически?");
            Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
            Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
            bool flag = bool.Parse(Console.ReadLine());
            Base_Array[i].Create(flag);

            Console.WriteLine("Вывод пересозданного массива: ");
            Base_Array[i].Print();

            Console.WriteLine("Вывод среднего в пересозданном массиве: ");
            Console.WriteLine(Base_Array[i].Mid_Value());
        }

        Console.ReadLine();
    }
}
