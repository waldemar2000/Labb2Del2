using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Del1
{
    public abstract class Animal
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }


        public virtual string BaseAnimalInformation()
        {
            return string.Format(", namnet är {0} som kan bli {1} år och kan väga {2} kg.",
                Name,
                Age ,
                Weight);

        }


    }
}
