using System;
using System.Collections.Generic;
using System.Text;

namespace Exploritas.Domain.Entities
{
    public class Cota : Entity
    {

        public double Nav { get; set; }
        public double Share { get; set; }
        public double NavAndShareId { get; set; }
        public DateTime Data { get; set; }


    }
}
