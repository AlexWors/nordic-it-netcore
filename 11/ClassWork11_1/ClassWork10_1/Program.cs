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
                BirthDate = DateTimeOffset.Parse("2018-03-04 ")
            };

            pet1.SetBirthPlace("Chelyabinsk");
            pet1.WriteDescription(true);


            Pet pet2 = new Pet("Mars", 2, Kind.Cat, 'F', DateTimeOffset.Parse("2015-08-13 "));

            pet2.SetBirthPlace("Khazakhstan");
            pet2.WriteDescription(true);
            
        }
    }
}