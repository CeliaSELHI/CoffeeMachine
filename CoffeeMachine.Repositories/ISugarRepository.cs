using CoffeMachine.Models;
using System.Collections.Generic;

namespace CoffeeMachine.Repositories
{
    public interface ISugarRepository
    {
        SugarDto Get();
        void Store(SugarDto sugar);
    }
}