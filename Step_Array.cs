using System;
using Задание_3_2.Interfaces;

public sealed class Step_Array : BaseArray, IStep_Array
{
    private int[][] _array;

    public Step_Array(int Length, bool Keyboard_Input)
    {
        _array = new int[Length][];
        Create(Keyboard_Input);
    }

    protected override void Initialize()
    {
        Random rnd = new Random();
        for (int i = 0; i < _array.Length; i++)
        {
            int arr_length = rnd.Next(1, 8);
            _array[i] = new int[arr_length];
            for (int j = 0; j < arr_length; j++)
            {
                _array[i][j] = rnd.Next(0, 100);
            }
        }
    }

    protected override void Keyboard_Initialize()
    {
        Random rnd = new Random();
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine("Введите длинну подмассива: ");
            int arr_length = int.Parse(Console.ReadLine());
            _array[i] = new int[arr_length];
            for (int j = 0; j < _array[i].Length; j++)
            {
                _array[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public override double Mid_Value()
    {
        int value_sum = 0;
        int value_counter = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                value_sum += _array[i][j];
                value_counter += 1;
            }
        }
        return value_sum / value_counter;
    }

    public string Mid_Subarray_Value()
    {
        string mid_val_arr = "";
        for (int i = 0; i < _array.Length; i++)
        {
            int value_sum = 0;
            for (int j = 0; j < _array[i].Length; j++)
            {
                value_sum += _array[i][j];
            }
            mid_val_arr += value_sum / _array[i].Length + " ";
        }
        return mid_val_arr;
    }

    public void Change_Even_Values()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                if (_array[i][j] % 2 == 0)
                {
                    _array[i][j] = i * j;
                }
            }
        }
    }

    public override void Print()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                Console.Write(_array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}