using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Hotels.Core
{
    public class Destination
    {
        private string Name;
        public List<Hotel> hotels;

        public Destination(string name)
        {
            Name = name;
            hotels = new List<Hotel>();
        }

        public void AddHotel(string name, int pools)
        {
            hotels.Add(new Hotel(name, pools));
        }

        public int TotalNumberOfPools()
        {
            int totalNumberOfPools = 0;
            foreach (var pool in hotels)
            {
                totalNumberOfPools += pool.Pools;
            }

            return totalNumberOfPools;
        }

        public int TotalNumberOfPools_Linq()
        {
            int totalNumberPoolsLinq = hotels
                .Sum(x => x.Pools);


            return totalNumberPoolsLinq;
        }

        public string GetName()
        {
            return ($"DESTINATION {Name}").ToUpper();
        }

        public List<string> HotelNames()
        {
            List<string> names = new List<string>();

            foreach (var name in hotels)
            {
                names.Add(name.Name);
            }

            return names;
        }

        public List<string> HotelNames_Linq()
        {
            var names = hotels
                .Select(x => x.Name)
                .ToList();

            return names;
        }

        public int MaxPools()
        {
            List<int> pools = new List<int>();

            foreach (var pool in hotels)
            {
                pools.Add(pool.Pools);
            }

            pools.Sort();

            return pools[pools.Count - 1];



        }

        public int MaxPools_Linq()
        {
            var maxPools = hotels
                .Max(x => x.Pools);

            return maxPools;
        }
    }
}
