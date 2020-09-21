using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23pamoka
{
    public abstract class BaseClass
    {
        public string Name { get; }

        public BaseClass(string Name, string name)
        {
            name = Name;
        }

        public abstract string NameMetodas(string name);

        public abstract int NameKodas(int a);

    }


}
