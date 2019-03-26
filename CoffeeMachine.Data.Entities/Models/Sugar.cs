using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Data.Entities.Models
{
   public class Sugar
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
      
    }
}
