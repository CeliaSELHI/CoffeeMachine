using CoffeeMachine.BusinessLogics;
using CoffeeMachine.Presentation.WebApp.Models;
using CoffeeMachine.Repositories;
using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CoffeeMachine.Presentation.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        //TODO USE WEB API TO ACCEEDE TO REPOSITORIES AND SERVICES
        private readonly IBadgeRepository _badgeRepository;
        private readonly IDrinkTypesRepository _drinkTypesRepository; 

        public HomeController(IBadgeRepository bagdeRepository, IDrinkTypesRepository drinkTypesRepository)
        {
            _badgeRepository = bagdeRepository;
            _drinkTypesRepository = drinkTypesRepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CoffeeMachine(string idBadge)
        {
            List<DrinkTypeDto> drinkTypesList = _drinkTypesRepository.Get();
            CoffeeMachineViewModel model = new CoffeeMachineViewModel();
             model.DrinkTypesList =  new SelectList(drinkTypesList.OrderBy(x => x.Id), "Id", "Label", null, 1, null);
            if (!string.IsNullOrEmpty(idBadge))
            {
                BadgeDto badge = _badgeRepository.Get(idBadge);

                model.SugarQuantity = badge.Drink.Sugar.Quantity;
                model.IsOwerMug = badge.IsOwerMug;
                model.DrinkType = badge.Drink.Type.Id;
            }
            return View(model);
        }
            

        [HttpPost]
        public ActionResult CoffeeMachine(CoffeeMachineViewModel model)
        {
            if (ModelState.IsValid)
            {
                try {

                    //Save Selection


                }
                catch (Exception e) {


                }

            }
            return View();
        }

    }
}