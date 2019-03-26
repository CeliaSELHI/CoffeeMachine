using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Repositories
{
    public class DrinkTypeDto
    {
        public int Id { get; set; }
        public string Label { get; set; }

        #region °Ctor°
        public DrinkTypeDto()
        {

        }
        public DrinkTypeDto(DrinkType type)
        {
            Id = type.Id;
            Label = type.Label;
        }
        #endregion
    }
}
