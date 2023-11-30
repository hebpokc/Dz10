using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz10
{
    abstract class Building
    {
        private int _buildingNum;
        private static int magnifier = 1;
        private double _height;
        private int _numOfFloors;
        private int _numOfAparts;
        private int _numOfEntrances;
        internal Building(double height, int floors, int aparts, int entrances)
        {
            _buildingNum = magnifier;
            _height = height;
            _numOfFloors = floors;
            _numOfAparts = aparts;
            _numOfEntrances = entrances;
            IncreaseNumber();
        }
        private void IncreaseNumber()
        {
            magnifier++;
        }
        public int GetBuildingNum()
        {
            return _buildingNum;
        }
        public void SetHeight(double height)
        {
            _height = height;
        }
        public double GetHeight()
        {
            return _height;
        }
        public void SetNumOfFloors(int floors)
        {
            _numOfFloors = floors;
        }
        public double GetNumOfFloors()
        {
            return _numOfFloors;
        }
        public void SetNumOfAparts(int aparts)
        {
            _numOfAparts = aparts;
        }
        public double GetNumOfAparts()
        {
            return _numOfAparts;
        }
        public void SetNumOfEntrances(int entrances)
        {
            _numOfEntrances = entrances;
        }
        public double GetNumOfEntrances()
        {
            return _numOfEntrances;
        }
        public double HeightOfFloor()
        {
            return Math.Round((_height / (double)_numOfFloors), 2);
        }
        public int NumOfApartInEntrances()
        {
            return _numOfAparts / _numOfEntrances;
        }
        public int NumOfApartOnFloor()
        {
            return NumOfApartInEntrances() / _numOfFloors;
        }
        public void Print()
        {
            Console.WriteLine($"\nНомер здания: {_buildingNum}\nВысота: {_height}\nКол-во этажей: {_numOfFloors}\nКол-во квартир: {_numOfAparts}" +
                $"\nКол-во подъездов: {_numOfEntrances}");
        }
    }
}
