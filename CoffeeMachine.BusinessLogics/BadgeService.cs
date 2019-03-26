using CoffeeMachine.Repositories;
using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.BusinessLogics
{
    public class BadgeService : IBadgeService
    {
        private readonly IBadgeRepository _badgeRepositery;
        public BadgeService(IBadgeRepository badgeRepositery)
        {
            _badgeRepositery = badgeRepositery;
        }
      
    }
}
