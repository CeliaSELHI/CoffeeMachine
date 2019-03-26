using CoffeeMachine.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Data.Entities.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public int IdType { get; set; }
        public int IdSugar { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("IdType")]
        public DrinkType CurrentType { get; set; }
        [ForeignKey("IdSugar")]
        public Sugar CurrentSugar { get; set; }
    }
}
