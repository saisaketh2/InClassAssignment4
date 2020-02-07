using System;

namespace InClassAssignment4
{
    class program
    {
       
        static void Main(string[] args)
           
        {
            Console.WriteLine("");
        }
        class Car
        {
             public string color = "red";

            internal void fullThrottle()
            {
                throw new NotImplementedException();
            }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
    class car
    {
       public string color = "red";
            public string model;
       public int maxSpeed = 200;
            public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        static void Main(string[] args)
        {
            car myObj = new car();
            myObj.fullThrottle();
                car Opel = new car();
                Opel.model = "Astra";
                Opel.year = 1999;
                Console.WriteLine(Opel.model);
        }

    }
        

        

         


    }
}
