using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2Del1
{
     class Dog : Mammal
    {


        public string Bark { get; set; }

        public override string BaseAnimalInformation()
        {
            return string.Format("Hund:{0} Den {1}. ",
                base.BaseAnimalInformation(),
                Bark);
        }


    }
}