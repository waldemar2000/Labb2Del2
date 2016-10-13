using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Del1
{
    class Runtime
    {
        public void Start()
        {

           Snake newsnake=new Snake

            {
                Name = "Snake",
                Weight = 30,
                Age = 50,
                ColdBlooded="kallblodiga",
                Scales = "Fjäll",
                Walk="inte gå"
           };
            Lizard newLizard=new Lizard
            {
                Name = "charizard",
                Weight = 100,
                Age = 75,
                ColdBlooded = "kallblodiga",
                Scales = "Fjäll",
                Walk="gå"
            };

            Dog newdog = new Dog
            {
                Name = "ace",
                Weight = 50,
                Age = 7,
                Fur="päls",
                Bark = "skäller"
            };

            Horse newhorse = new Horse
            {
                Name = "toto",
                Weight=200,
                Age=12,
                Fur="päls",
                Bark="skäller inte"

            };

            Console.WriteLine(newhorse.BaseAnimalInformation());
            Console.WriteLine(newLizard.BaseAnimalInformation());
            Console.WriteLine(newsnake.BaseAnimalInformation());
            Console.WriteLine(newdog.BaseAnimalInformation());
            Console.ReadKey(true);


        }

        

    }


}
