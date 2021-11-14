using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Store
    {
        private List<Tovar> _tovar;

        public Tovar this[int index] => _tovar[index];

        public Tovar this[string name] => _tovar.FirstOrDefault(a => a.Name.Equals(name));

        public Store()
        {
            _tovar = new List<Tovar>();
        }
        public void AddTovar(Tovar tovar)
        {
            _tovar.Add(tovar);
        }
        public void SortName()
        {
            _tovar = _tovar.OrderBy(a=> a.Name).ToList();
        }

    }
}
