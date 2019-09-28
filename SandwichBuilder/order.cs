/*
 * Nicholas Tran
 * September 21, 2018
 * CIS-3342 Server Side
 * Chris Pascucci
 * Project 1 - Sandwich Builder
 * Order.cs is used to create an order object that stores all information about the order
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandwichBuilder
{
    public class Order
    {
        string name;
        string phone;
        string size;
        string toast;
        string spread;
        string vegetables;
        string premiumAdditions;
        string meal;
        string tip = "0";
        string countSpread;
        string countVegetables;
        string countPremiumAdditions;
        string sizeCost;
        string toastCost;
        string spreadCost;
        string vegetablesCost;
        string premiumAdditionsCost;
        string mealOptionCost;
        string subtotal;
        string tax;
        string total;



        public Order(string name, string phone, string size, string toast, string spread, string vegetables, string premiumAdditions, string meal, string tip)
        {
            this.name = name;
            this.phone = phone;
            this.size = size;
            this.toast = toast;
            this.spread = spread;
            this.vegetables = vegetables;
            this.premiumAdditions = premiumAdditions;
            this.meal = meal;
            this.tip = tip;
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public string Toast
        {
            get { return this.toast; }
            set { this.toast = value; }
        }
        public string Spread
        {
            get { return this.spread; }
            set { this.spread = value; }
        }
        public string Vegetables
        {
            get { return this.vegetables; }
            set { this.vegetables = value; }
        }
        public string PremiumAdditions
        {
            get { return this.premiumAdditions; }
            set { this.premiumAdditions = value; }
        }
        public string Meal
        {
            get { return this.meal; }
            set { this.meal = value; }
        }
        public string Tip
        {
            get { return this.tip; }
            set { this.tip = value; }
        }
        public string CountSpread
        {
            get { return this.countSpread; }
            set { this.countSpread = value; }
        }
        public string CountVegetables
        {
            get { return this.countVegetables; }
            set { this.countVegetables = value; }
        }
        public string CountPremiumAdditions
        {
            get { return this.countPremiumAdditions; }
            set { this.countPremiumAdditions = value; }
        }
        public string SizeCost
        {
            get { return this.sizeCost; }
            set { this.sizeCost = value; }
        }
        public string ToastCost
        {
            get { return this.toastCost; }
            set { this.toastCost = value; }
        }
        public string SpreadCost
        {
            get { return this.spreadCost; }
            set { this.spreadCost = value; }
        }
        public string VegetablesCost
        {
            get { return this.vegetablesCost; }
            set { this.vegetablesCost = value; }
        }
        public string PremiumAdditionsCost
        {
            get { return this.premiumAdditionsCost; }
            set { this.premiumAdditionsCost = value; }
        }
        public string MealOptionCost
        {
            get { return this.mealOptionCost; }
            set { this.mealOptionCost = value; }
        }
        public string Subtotal
        {
            get { return this.subtotal; }
            set { this.subtotal = value; }
        }
        public string Tax
        {
            get { return this.tax; }
            set { this.tax = value; }
        }
        public string Total
        {
            get { return this.total; }
            set { this.total = value; }
        }
    }
}