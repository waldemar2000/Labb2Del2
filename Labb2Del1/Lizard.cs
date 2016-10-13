using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb2Del1
{
     class Lizard : Reptile
    {
        public string Walk { get; set; }

        public override string BaseAnimalInformation()
        {
            return string.Format("Ödla:{0} Den kan {1}. ",
                base.BaseAnimalInformation(),
                Walk);

        }

    }
}