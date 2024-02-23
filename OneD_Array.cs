using System;
using Задание_3_2.Interfaces;

public sealed class OneD_Array : BaseArray, IOneD_Array
{
    private int[] _array;

    public OneD_Array(int length, bool Keyboard_Input = false)
    {
        _array = new int[length];
        Create(Keyboard_Input);
    }

    protected override void Initialize()
    {
        Random rnd = new Random();
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = rnd.Next(0, 150);
        }
    }

    protected override void Keyboard_Initialize()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = int.Parse(Console.ReadLine());
        }
    }

    public override void Print()
    {
        Print_Array(_array);
    }

    private static void Print_Array(int[] _arr)
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            Console.Write(_arr[i] + " ");
        }
        Console.WriteLine();
    }

    public override double Mid_Value()
    {
        int value_sum = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            value_sum += _array[i];
        }
        return value_sum / _array.Length;
    }

    public void Delite_Values_More_Than_Mod_100()
    {
        int new_array_length = 0;

        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] > -100 && _array[i] < 100)
            {
                new_array_length++;
            }
        }

        int[] new_array = new int[new_array_length];
        int new_array_ind = 0;

        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] > -100 && _array[i] < 100)
            {
                new_array[new_array_ind] = _array[i];
                new_array_ind++;
            }
        }
        _array = new_array;
    }

    public void Delite_Unique_Values()
    {
        int new_arr_length = _array.Length;
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = i; j < _array.Length; j++)
            {

                if (_array[i] == _array[j] && i != j)
                {
                    new_arr_length--;
                    break;
                }
            }
        }
        int Counter = 0;
        int[] new_arr = new int[new_arr_length];
        for (int k = 0; k < _array.Length; k++)
        {
            if (!Contain(new_arr, _array[k]))
            {
                new_arr[Counter] = _array[k];
                Counter++;
            }
        }
        Print_Array(new_arr);
    }

    private static bool Contain(int[] arr, int symb)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (symb == arr[i])
            {
                return true;
            }
        }
        return false;
    }
}