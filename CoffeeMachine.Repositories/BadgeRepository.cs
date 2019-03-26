using CoffeeMachine.Data.Entities.Contexts;
using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.Repositories
{
    public class BadgeRepository : IBadgeRepository
    {
        public BadgeDto Get(string id)
        {
            CoffeeMachineContext context = new CoffeeMachineContext();

            var currentBadge = (from badge in context.Badges
                                where badge.Id == id
                                select badge).FirstOrDefault();

            return currentBadge != null ? new BadgeDto(currentBadge) : new BadgeDto();
        }    

    }
}
