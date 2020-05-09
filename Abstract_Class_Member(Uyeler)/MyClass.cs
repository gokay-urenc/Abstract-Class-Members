using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Member_Uyeler_
{
    public abstract class MyClass
    {
        public int MyProperty { get; set; }
        public abstract string Fonksiyon();
        public virtual string MesajVer()
        {
            return "Merhaba";
        }
    }
}
// Ortak özelliklerin tanımlanacağı ve görevinin sadece bu olacağı class. Instance alınmasına gerek olmayan class.

// Abstract üyelerin gövdeleri olmaz. Bu yüzdende miras alan sınıf tarafından ezilmek veya    içleri doldurulmak zorundadır. Abstract üyeler sadece abstract classlar içinde tanımlanır.

// Virtual üyelerin gövdeleri olmak zorundadır. Bu yüzdende miras alan sınıf tarafından       ezilmek zorunda değildir. Virtual üyeler her tür classta yazılabilir.