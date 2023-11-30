using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class BrickBuilding : Building
    {
        internal BrickBuilding(double height, int floors, int aparts, int entrances) : base(height, floors, aparts, entrances) { }
        public override string ToString()
        {
            return "Кирпичный дом";
        }
    }
}
