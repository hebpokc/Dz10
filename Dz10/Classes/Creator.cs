using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    class Creator
    {
        static Hashtable buildings;
        static Creator()
        {
            buildings = new Hashtable();
        }
        public static BrickBuilding CreateBrickBuild(double height, int floors, int aparts, int entrances)
        {
            BrickBuilding bb = new BrickBuilding(height, floors, aparts, entrances);
            buildings.Add(bb.GetBuildingNum(), bb);
            return bb;
        }
        public static MetalBuilding CreateMetalBuild(double height, int floors, int aparts, int entrances)
        {
            MetalBuilding mb = new MetalBuilding(height, floors, aparts, entrances);
            buildings.Add(mb.GetBuildingNum(), mb);
            return mb;
        }
        public static void Destroy(int number)
        {
            buildings.Remove(number);
        }
        public static void Print()
        {
            Console.WriteLine($"\nКоличество зданий: {buildings.Count}");
            ICollection keys = buildings.Keys;
            foreach (var s in keys)
            {
                Console.WriteLine(s + ": " + buildings[s].ToString());
            }
        }
    }
}
