using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOHomework.May062022
{
    [Serializable]
    public class ProductClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Catergory { get; set; }
    }
}
