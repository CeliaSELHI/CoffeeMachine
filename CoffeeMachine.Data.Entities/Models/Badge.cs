using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Data.Entities.Models
{
    public class Badge
    {
        public string Id { get; set; }
        public int IdDrink { get; set; }
        [ForeignKey("IdDrink")]
        public Drink CurrentDrink { get; set; }
        public bool IsOwerMug { get; set; }
    }
}
