using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserBackEnd.DBModels
{
    public class Vluchten
    {
        public Guid VluchtID { get; set; }
        public string Maatschappij { get; set; }
        public DateTime Datum { get; set; }
    }
}
