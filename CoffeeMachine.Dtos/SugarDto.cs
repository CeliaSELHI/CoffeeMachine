using CoffeeMachine.Data.Entities.Models;

namespace CoffeMachine.Models
{
    public class SugarDto
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        #region °Ctor°

        public SugarDto()
        {

        }
        public SugarDto(Sugar sugar)
        {
            Id = sugar.Id;
            Quantity = sugar.Quantity;
        }

        #endregion
    }
}
