using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMeeting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first dog's name: ");
            string dogName = Console.ReadLine();

            Console.Write("Enter first dog's breed: ");
            string dogBreed = Console.ReadLine();

            //dog with teh constructor with name and breed
            Dog firstDog = new Dog(dogName, dogBreed);

            //dog with the parameterless constructor
            Dog secondDog = new Dog();

            Console.Write("Enter second dog's name: ");
            secondDog.Name = Console.ReadLine();

            Console.Write("Enter second dog's breed: ");
            secondDog.Breed = Console.ReadLine();

            Dog thirdDog = new Dog();

            //all 3 in an array
            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

            foreach (var dog in dogs)
            {
                dog.SayBau();
            }

        }
    }
}
