using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class MetalBuilding : Building
    {
        internal MetalBuilding(double height, int floors, int aparts, int entrances) : base(height, floors, aparts, entrances) { }
        public override string ToString()
        {
            return "Металлический дом";
        }
    }
}
