using System;
using System.Collections;
using System.Collections.Generic;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<string> test = new MyGeneric<string>("这是自1111111111定义泛型");

            Console.WriteLine("Hello World!");

            Func<string, string> func = num => { return "num is " + num; };

            Show<string, Func<string, string>>("AAAAAAAAAAAAAAAAAA", ShowG);

            Show<int, string>(1111111, null);
        }


        public static G ShowG<G>(G g)
        {
            return g;
        }

        public static void Show<T, G>(T t, Func<G, G> f)
        {
            Console.WriteLine(t.ToString());
        }

        public static void Test2()
        { 
        
        }
    }


    class MyGeneric<T> : List<T>
    {
        private T t;

        public MyGeneric(T t)
        {
            this.t = t;
        }
    }
}
