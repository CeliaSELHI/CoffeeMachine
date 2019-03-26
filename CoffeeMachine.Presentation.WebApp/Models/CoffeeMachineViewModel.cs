using CoffeeMachine.Repositories;
using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeMachine.Presentation.WebApp.Models
{
    public class CoffeeMachineViewModel : BaseViewModel
    {
        #region ° Properties °
        public int SugarQuantity { get; set; }
        public bool IsOwerMug { get; set; }
        public int DrinkType { get; set; }
        public SelectList DrinkTypesList { get; set; }
        #endregion

        #region Ctor
        public CoffeeMachineViewModel()
        {
             
        }
        #endregion

        public void InitForView(BadgeDto badge)
        {
            SugarQuantity = badge.Drink.Sugar.Quantity;
            IsOwerMug = badge.IsOwerMug;
            DrinkType = badge.Drink.Type.Id;
        }


    }
}