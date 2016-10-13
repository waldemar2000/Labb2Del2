using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Del1
{
    class Mammal : Animal
    {
       
       public string Fur{get;set;}
        

        public override string BaseAnimalInformation()
        {
            return string.Format(" däggdjur{0}Den har {1}. ",
                base.BaseAnimalInformation(),
                Fur);
        }

    }
}
