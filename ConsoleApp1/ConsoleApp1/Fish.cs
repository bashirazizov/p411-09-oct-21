using System;
namespace ConsoleApp1
{
    abstract class Fish : Animal 
    {
        public string WaterType { get; set; }
    }

    class Salmon : Fish
    {
        public override void makeSound()
        {
            throw new System.NotImplementedException();
        }

        public override void Move()
        {
            Console.WriteLine("Salmon swims");
        }
    }

    class Shark : Fish
    {


        public override void makeSound()
        {
            Console.WriteLine("Nom nom!");
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override string Test()
        {
            return base.Test() + "Test2";
        }

        public void KillSwimmer()
        {
            Console.WriteLine("Blood");
        }

        private int _teethCount;

        public int TeethCount { 
            get {
                return _teethCount;
            } 
            set
            {
                if (value > 0 && value < 50)
                {
                    _teethCount = value;
                }
            }
        }

        //public int getTeethCount() {
        //    return TeethCount;
        //}

        //public void setTeethCount(int s)
        //{
        //    if (s>0 && s<50)
        //    {
        //        TeethCount = s;
        //    }
        //}

    }
    }
