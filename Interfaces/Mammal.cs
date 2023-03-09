using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public interface Mammal
    {
        string name { get; set; }
        int age { get; set; }
        void PerformTrick();
        void GetInfo();
    }
}
