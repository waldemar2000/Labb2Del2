using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Del1
{
    class Snake : Reptile
    {

        public string Walk { get; set; }

        public override string BaseAnimalInformation()
        {
            return string.Format("Orm:{0} Den kan {1}. ",
                base.BaseAnimalInformation(),Walk
                );

        }
    }
}

