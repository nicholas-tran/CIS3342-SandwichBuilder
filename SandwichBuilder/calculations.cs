/*
 * Nicholas Tran
 * September 21, 2018
 * CIS-3342 Server Side
 * Chris Pascucci
 * Project 1 - Sandwich Builder
 * Calculations.cs is used to calculate all information regarding an order
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandwichBuilder
{
    public class Calculations
    {
        //Calculates the size cost using switch statements
        public decimal calculateSize(string size)
        {
            decimal cost = 0m;
            switch (size)
            {
                case "Kids":
                    cost = 3.00m;
                    break;
                case "Small":
                    cost = 3.50m;
                    break;
                case "Medium":
                    cost = 4.00m;
                    break;
                case "Large":
                    cost = 4.50m;
                    break;
                case "Extra Large":
                    cost = 5.00m;
                    break;
            }
            return cost;
        }
        //End calculateSize method

        //Calculates cost of toast using if else statement
        public decimal calculateToast(string toast)
        {
            decimal cost = 0m;
            if (toast == "Yes")
            {
                cost = .5m;
                return cost;
            }
            else
            {
                return cost;
            }
        }
        //End calculateToast method

        //Calculates the cost of spread based on quantity
        public decimal calculateSpread(string spread)
        {
            decimal cost = 0;
            int count = Convert.ToInt32(spread);
            cost = count * .20m;
            return cost;
        }
        //End calculateSpread

        //Calculates cost of vegetables based on quantity
        public decimal calculateVegetables(string vegetables)
        {
            decimal cost = 0;
            int count = Convert.ToInt32(vegetables);
            cost = count * .1m;
            return cost;
        }
        //End calculateVegetables method

        //Calculates cost of premium additions based on quantity
        public decimal calculatePremiumAdditions(string premiumAdditions)
        {
            decimal cost = 0;
            int count = Convert.ToInt32(premiumAdditions);
            cost = count * .50m;
            return cost;
        }
        //End calculatePremiumAdditions method

        //Calculates cost of meal option based on switch statement
        public decimal calculateMealOption(string meal)
        {
            decimal cost = 0;
            switch (meal)
            {
                case "No":
                    cost = 0m;
                    break;
                case "Drink and Chips":
                    cost = 2.00m;
                    break;
                case "Drink and Fruit":
                    cost = 1.5m;
                    break;
                case "Drink and Cookie":
                    cost = 1.75m;
                    break;
                case "Drink and Snackbar":
                    cost = 2.00m;
                    break;
            }
            return cost;
        }
        //End calculateMealOption method

        //Calculates the subtotal before tax and tip by adding other values together
        public decimal calculateSubTotal(string size, string toast, string spread, string vegetables, string premiumAdditions)
        {
            decimal cost = 0m;
            cost = Convert.ToDecimal(size) + Convert.ToDecimal(toast) + Convert.ToDecimal(spread) + Convert.ToDecimal(vegetables) + Convert.ToDecimal(premiumAdditions);
            return cost;
        }
        //End calculateSubtotal method

        //Calculates the tax amount based on the subtotal and rate of Philadelphia tax
        public decimal calculateTax(string size, string toast, string spread, string vegetables, string premiumAdditions)
        {
            decimal tax = 0m;
            tax = Convert.ToDecimal(calculateSubTotal(size, toast, spread, vegetables, premiumAdditions)) * 0.08m;
            return tax;
        }
        //End calculateTax method

        //Calculates the total amount by adding subtotal, tax and tip
        public decimal calculateTotal(string size, string toast, string spread, string vegetables, string premiumAdditions, string tip)
        {
            decimal cost = 0m;
            cost = calculateSubTotal(size, toast, spread, vegetables, premiumAdditions) + 
                calculateTax(size, toast, spread, vegetables, premiumAdditions) + 
                Convert.ToDecimal(tip);
            return cost;
        }
        //End calculateTotal method
    }
}