using System;
using System.Collections.Generic;
using System.Text;


public class Util
{
    public static void Swap(ref int a, ref int b)
    {
        var temp = a;
        a = b;
        b = temp;
    }
}


