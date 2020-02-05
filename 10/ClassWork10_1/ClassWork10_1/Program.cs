using System;

namespace ClassWork10_1
{
    

    class Program
    {
        static void Main()
        {
            Pet pet1 = new Pet
            {
                Name = "Balu",
                Age = 5,
                Kind = Kind.Dog,
                Sex = 'M',                
            };

            pet1.SetBirthPlace("Chelyabinsk");
            
            

            Console.WriteLine(pet1.Description);
            Pet pet2 = new Pet
            {
                Name = "Mars",
                Age = 2,
                Kind = Kind.Cat,
                Sex = 'F'
            };
            pet2.SetBirthPlace("Khazakhstan");
            Console.WriteLine(pet2.Description);
            
        }
    }
}