using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UpCasting
            //Fish s1 = new Shark();
            //Tiger t1 = new Tiger();

            //Mammal t2 = new Tiger();
            //Mammal c1 = new Cat();

            //string name = "Mamed";
            //int age = 5;
            //bool isMarried = false;

            //Object[] items = {s1, t1, name, age, isMarried };
            #endregion

            #region Class as reference type
            //Student b2 = new Student();
            //b2.Name = "Mamed";

            //Student b3 = b2;

            //b3.Name = "Kamran";

            //Console.WriteLine(b2.Name);
            //Console.WriteLine(b3.Name);
            #endregion

            #region Downcasting
            //Worker w1 = new Worker();
            //Person w2 = new Worker();
            //w2.Name = "Elgun";
            //Person p1 = new Person();


            //if (w2 is Worker)
            //{
            //    w3 = (Worker)w2;
            //    Console.WriteLine(w3.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Can not cast");
            //}


            //w3 = s1 as Worker;
            //if (w3 != null)
            //{
            //    Console.WriteLine(w3.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Can not cast");
            //}
            #endregion

            #region Custom Casting
            //Student s1 = new Student();
            //s1.Name = "Mamed";
            //s1.SurName = "Mamedli";
            //s1.Age = 24;
            //Worker w3 = s1;


            //Azn manat = new Azn();
            //manat.Amount = 510;
            //Usd dollar = manat;
            //Console.WriteLine(manat.Amount);
            //Console.WriteLine(dollar.Amount);
            #endregion

            #region Custom type operators
            //Student s1 = new Student();
            //s1.Name = "Mamed";
            //s1.SurName = "Mamedli";
            //s1.Age = 24;

            //Student s2 = new Student();
            //s2.Name = "Malik";
            //s2.SurName = "Alisoy";
            //s2.Age = 41;

            //Console.WriteLine(s1+s2);
            //Console.WriteLine(s1>s2);

            //Azn manat = new Azn();
            //manat.Amount = 510;

            //Usd dollar = new Usd();
            //dollar.Amount = 300;
            //Console.WriteLine(manat==dollar);
            #endregion

            #region null
            //Person p1 = null;
            //Person p2 = new Person();
            //p2.Name = "Mamed";
            //Worker w2 = null;
            //p1 = p2;
            //Console.WriteLine(p1.Name);
            //string str = null;
            //int? id = null;
            //DetailedInfo(id);
            #endregion
        }

        #region null param
        //static void DetailedInfo(int? id)
        //{
        //    if (id!=null)
        //    {
        //        Console.WriteLine($"{id} nomreli elan sehifesi gosterildi");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Elan Tapilmadi umumi elanlari gosterirem");
        //    }
        //}
        #endregion
    }

    #region Custom Casting
    class Usd
    {
        public double Amount { get; set; }
    }

    class Azn
    {
        public double Amount { get; set; }

        public static implicit operator Usd(Azn m)
        {
            Usd castedUsd = new Usd();
            castedUsd.Amount = m.Amount / 1.7;
            return castedUsd;
        }

        public static bool operator <(Azn manat, Usd dollar)
        {
            return manat.Amount/1.7 < dollar.Amount;
        }

        public static bool operator >(Azn manat, Usd dollar)
        {
            return manat.Amount / 1.7 > dollar.Amount;
        }

        public static bool operator ==(Azn manat, Usd dollar)
        {
            return manat.Amount / 1.7 == dollar.Amount;
        }
        public static bool operator !=(Azn manat, Usd dollar)
        {
            return manat.Amount / 1.7 != dollar.Amount;
        }
    }
    #endregion
}
