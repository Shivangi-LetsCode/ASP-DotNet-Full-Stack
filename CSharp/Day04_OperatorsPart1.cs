class Operators1 {
    public static void Main()
    {
        // 1) ARITHMETIC OPERATORS(+,-,*,/,%(Modulus))
        int a = 10;
        int b = 2;
        Console.WriteLine(a + b); //12
        Console.WriteLine(a - b); //8
        Console.WriteLine(a * b); //20
        Console.WriteLine(a / b); //5
        Console.WriteLine(a % b);//0

        //2) ASSIGNMENT OPERATORS(=,+=,-=,*=,/=,%=)
        int c = 10;
        Console.WriteLine(c);

        int d = 5;
        d += 2; // d=d+2 => d=5+2 => 7
        Console.WriteLine(d);

        int e = 5;
        e -= 2;
        Console.WriteLine(e);

        int f = 5;
        f += 2;
        Console.WriteLine(f);

        int g = 5;
        g *= 2;
        Console.WriteLine(g);

        int h = 5;
        h /= 2;
        Console.WriteLine(h);

        int i = 5;
        i %= 2;
        Console.WriteLine(i);

        // 3) RELATIONAL/COMPARISION OPERATORS(==,!=,>,<,>=,<=)
        Console.WriteLine(2 == 3);
        Console.WriteLine(2 == 2);
        Console.WriteLine(2 != 2);
        Console.WriteLine(2 != 3);
        Console.WriteLine(2 > 1);
        Console.WriteLine(2 > 3);
        Console.WriteLine(2 < 8);
        Console.WriteLine(4 < 2);
        Console.WriteLine(3 >= 1); // greater than equals to
        Console.WriteLine(3 >= 8);
        Console.WriteLine(4 >= 4);
        Console.WriteLine(5 <= 6);
        Console.WriteLine(8 <= 4);
        Console.WriteLine(5 <= 5);

        //4) Logical Operators(!(Not), &&(and), ||(or))
        Console.WriteLine(3 > 1 && 4 > 2); // True
        Console.WriteLine(5 > 2 && 4 > 7); // False
        Console.WriteLine(5 > 7 && 3 > 2); // False
        Console.WriteLine(9 > 12 && 4 > 7); // False

        Console.WriteLine(3 > 1 || 4 > 2); // True
        Console.WriteLine(5 > 2 || 4 > 7); // True
        Console.WriteLine(5 > 7 || 3 > 2); // True
        Console.WriteLine(9 > 12 || 4 > 7); // False

        Console.WriteLine(!(4 > 2));
        Console.WriteLine(!(3 < 2));
        Console.WriteLine(!(3 == 5));
        Console.WriteLine(!(6 != 9));

        // 5) UNARY OPERATORS(+(unary plus),-(unary minus),++(increment),--(decrement),!(logical not))
        int k = +5;
        Console.WriteLine(k);
        int l = -5;
        Console.WriteLine(l);
        // Pre Increment (Prefix form: ++a) => first will change the value and then assign
        int m = 5;
        int n = ++m; // m becomes 6, then n = 6 => ++m => m=m+1 => 5+1 => 6
        Console.WriteLine(n);

        // Post Increment (Postfix form: a++) => first will assign the value and then change
        int o = 5;
        int p = o++; // p = 5, then o becomes 6
        Console.WriteLine(p);
        Console.WriteLine(o);

        // Pre Decrement (Prefix form: --a) => first will change the value and then assign
        int q = 5;
        int r = --q; // q becomes 4, then r = 4 
        Console.WriteLine(r);

        // Post Decrement (Postfix form: a--) => first will assign the value and then change
        int s = 5;
        int t = s--; // s = 5, then t becomes 4
        Console.WriteLine(t);
        Console.WriteLine(s);

        bool isActive = true;
        Console.WriteLine(!isActive);

        // 6) STRING CONCATENATION OPERATOR
        string fullname = "John" + " " + "Smith";
        Console.WriteLine(fullname);
    }
}
