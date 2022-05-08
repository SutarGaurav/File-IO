using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOHomework.May062022
{
    [Serializable]
    public class Batch
    {
        public byte Id { get; set; }
        public string BatchName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Location { get; set; }
        public string TrainerName { get; set; }
    }
}
