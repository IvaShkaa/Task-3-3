using System;
using Задание_3_2.Interfaces;

public abstract class BaseArray : IBaseArray, IPrint
{
    public abstract void Print();
    protected abstract void Initialize();
    protected abstract void Keyboard_Initialize();
    public abstract double Mid_Value();

    public void Create(bool Keyboard_Input = false)
    {
        if (Keyboard_Input == false)
        {
            Initialize();
        }
        else
        {
            Keyboard_Initialize();
        }
    }
}

