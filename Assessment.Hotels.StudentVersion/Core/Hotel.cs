using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Hotels.Core
{
    public class Hotel 
    {
        public string Name;
        public int Pools;
        public List<Suits> suits;
        public string Description;

        public Hotel(string name, int pools)
        {
            Name = name;
            Pools = pools;
            suits = new List<Suits>();
            Description = $"{Name} has {Pools} pools";
        }

        public void SuitsGroup(string typeSuit)
        {
            Suits type = (Suits)Enum.Parse(typeof(Suits),typeSuit);

            if (!suits.Contains(type))
                suits.Add(type);
            else
                throw new ArgumentException();
            
        }

        public bool Suits(Suits type)
        {

            var isTrue = suits
                .Contains(type);
                

            return isTrue;

        }
    }
}
