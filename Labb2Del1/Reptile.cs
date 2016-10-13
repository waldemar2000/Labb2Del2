using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Del1
{
    class Reptile : Animal
    {

        public string ColdBlooded { get; set; }
        public string Scales { get; set; }
        public override string BaseAnimalInformation()
        {
            return string.Format(" reptil{0} Den är {1}. Den har {2}. ",
                base.BaseAnimalInformation(),ColdBlooded, Scales);

        }
    }
}
