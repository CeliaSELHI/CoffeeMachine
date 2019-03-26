using CoffeeMachine.Repositories;
using System;

namespace CoffeeMachine.BusinessLogics
{
    public class SugarService : ISugarService
    {
        private readonly ISugarRepository _sugarRepository;
        public SugarService(ISugarRepository sugarRepository)
        {
            _sugarRepository = sugarRepository;
        }

        public void UpdateSugar(int quantity)
        {
            var currentSugar = _sugarRepository.Get();
            if (currentSugar != null)
            {
                if (currentSugar.Quantity < quantity)
                {
                    throw new NotEnoughSugarException();
                }
                currentSugar.Quantity -= quantity;
                _sugarRepository.Store(currentSugar);
            }
        }
    }
}
