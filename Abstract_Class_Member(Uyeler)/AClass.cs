using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Member_Uyeler_
{
    class AClass : MyClass // Miras alanın altındaki hatanın ampul işaretine gelip implement                         yapınca aşağıdaki kod gelir. (CTRL + .)
    {
        public override string Fonksiyon() // Abstract ve virtual arasındaki tek ortak nokta                                     override ile çağrılıyor olmasıdır.
        {
            return "AAA";
        }
    }
}