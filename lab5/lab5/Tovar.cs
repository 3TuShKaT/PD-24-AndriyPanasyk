using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Tovar
    {
        private string _name;
        private string _type;
        private string _description;
        private double _cost;

        public string Name => _name;
        public string Type => _type;
        public string Description => _description;
        public double Cost => _cost;

        public Tovar(string name, string type, string description, double cost)
        {
            _name = name;
            _type = type;
            _description = description;
            _cost = cost;
        }
    }
}
