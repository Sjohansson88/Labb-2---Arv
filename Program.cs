using System.Security.Cryptography;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           Rottweiler myRottweiler = new Rottweiler("Rocky", 4, "Brown", 25.0, true, "Bulldog", true);
            myRottweiler.Sound(); 
            myRottweiler.GuardHouse();

            Chihuahua myChihuahua = new Chihuahua("Wilmer", 11, "Black", 8.0, true, "Chihuahua", true);
            myChihuahua.Sound();
            myChihuahua.ShakeHands();



            Cat myCat = new Cat("Nisse", 5, "White", 4.0, true, "Siames");
            myCat.Sound();
            myCat.ChasingMouse();

            Pig myPig = new Pig("Ralf", 7, "Pink", 38.0, false, true);
            myPig.Sound();
            myPig.Sleep();


            Console.ReadKey();
        }
    }

 
    
        





}