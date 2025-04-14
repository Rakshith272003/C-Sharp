using System;

public class Number
{
    public int Value;

    public Number(int value)
    {
        Value = value;
    }

    // + Operator
    public static Number operator +(Number a, Number b)
    {
        return new Number(a.Value + b.Value);
    }

    // - Operator
    public static Number operator -(Number a, Number b)
    {
        return new Number(a.Value - b.Value);
    }

    // * Operator
    public static Number operator *(Number a, Number b)
    {
        return new Number(a.Value * b.Value);
    }

    // / Operator
    public static Number operator /(Number a, Number b)
    {
        return new Number(a.Value / b.Value);
    }

    // == Operator
    public static bool operator ==(Number a, Number b)
    {
        return a.Value == b.Value;
    }

    // != Operator
    public static bool operator !=(Number a, Number b)
    {
        return a.Value != b.Value;
    }

    // > Operator
    public static bool operator >(Number a, Number b)
    {
        return a.Value > b.Value;
    }

    // < Operator
    public static bool operator <(Number a, Number b)
    {
        return a.Value < b.Value;
    }

    // >= Operator
    public static bool operator >=(Number a, Number b)
    {
        return a.Value >= b.Value;
    }

    // <= Operator
    public static bool operator <=(Number a, Number b)
    {
        return a.Value <= b.Value;
    }

    // ++ Operator
    public static Number operator ++(Number a)
    {
        return new Number(a.Value + 1);
    }

    // -- Operator
    public static Number operator --(Number a)
    {
        return new Number(a.Value - 1);
    }

    // ! Operator (returns true if Value == 0)
    public static bool operator !(Number a)
    {
        return a.Value == 0;
    }

    public override string ToString()
    {
        return Value.ToString();
    }

    // Required for == and != overloading
    public override bool Equals(object obj)
    {
        if (obj is Number n)
            return Value == n.Value;
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}
