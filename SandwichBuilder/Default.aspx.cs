/*
 * Nicholas Tran
 * September 21, 2018
 * CIS-3342 Server Side
 * Chris Pascucci
 * Project 1 - Sandwich Builder
 * Default.aspx is the server side page that processes information from the client side form sandwich_builder.html
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SandwichBuilder
{
    public partial class Default : System.Web.UI.Page
    {
        Calculations calculate = new Calculations();

        protected void Page_Load(object sender, EventArgs e)
        {
            string n = Request.Form["name"];
            string p = Request.Form["phone"];
            string s = Request.Form["size"];
            string t = Request.Form["toast"];
            string r = Request.Form["spread"];
            string v = Request.Form["vegetables"];
            string a = Request.Form["premiumAddition"];
            string m = Request.Form["meal"];
            string g = Request.Form["tip"];
            Order newOrder = new Order(n,p,s,t,r,v,a,m,g);
            lblName.Text = newOrder.Name;
            lblPhoneNumber.Text = newOrder.Phone;
            lblSize.Text = newOrder.Size;
            lblToast.Text = newOrder.Toast;
            lblSpread.Text = newOrder.Spread;
            lblVegetables.Text = newOrder.Vegetables;
            lblPremiumAdditions.Text = newOrder.PremiumAdditions;
            lblMeal.Text = newOrder.Meal;
            //Ensuring that a blank tip is a $0.00 tip
            if (Request.Form["tip"].ToString() == "")
            {
                newOrder.Tip = 0.00m.ToString();
                lblTips.Text = newOrder.Tip;
            }
            else
            {
                lblTips.Text = newOrder.Tip;
            }
            //End if else
            //Quantifying the amounts of each item of each category for later cost calculations
            if (Request.Form["spread"] == null)
            {
                newOrder.CountSpread = "0";
                lblCountSpread.Text = newOrder.CountSpread;
            }
            else
            {
                string spread = newOrder.Spread;
                string[] countSpread = spread.Split(',');
                newOrder.CountSpread = countSpread.Count().ToString();
                lblCountSpread.Text = newOrder.CountSpread;


            }
            //End if else
            //Quantifying the amounts of each item of each category for later cost calculations
            if (Request.Form["vegetables"] == null)
            {
                newOrder.CountVegetables = "0";
                lblCountVegetables.Text = newOrder.CountVegetables;
            }
            else
            {
                string vegetables = newOrder.Vegetables;
                string[] countVegetables = vegetables.Split(',');
                newOrder.CountVegetables = countVegetables.Count().ToString();
                lblCountVegetables.Text = newOrder.CountVegetables;
            }
            //End if else
            //Quantifying the amounts of each item of each category for later cost calculations
            if (Request.Form["premiumAddition"] == null)
            {
                newOrder.CountPremiumAdditions = "0";
                lblCountPremiumAdditions.Text = newOrder.CountPremiumAdditions;
            }
            else
            {
                string premiumAdditions = newOrder.PremiumAdditions;
                string[] countPremiumAdditions = premiumAdditions.Split(',');
                newOrder.CountPremiumAdditions = countPremiumAdditions.Count().ToString();
                lblCountPremiumAdditions.Text = newOrder.CountPremiumAdditions;
            }
            //End if else
            //Calculate costs for receipt
            newOrder.SizeCost = calculate.calculateSize(newOrder.Size).ToString();
            lblSizeCost.Text = newOrder.SizeCost.ToString();
            newOrder.ToastCost = calculate.calculateToast(newOrder.Toast).ToString();
            lblToastCost.Text = newOrder.ToastCost.ToString();
            newOrder.SpreadCost = calculate.calculateSpread(newOrder.CountSpread).ToString();
            lblSpreadCost.Text = newOrder.SpreadCost.ToString();
            newOrder.VegetablesCost = calculate.calculateVegetables(newOrder.CountVegetables).ToString();
            lblVegetablesCost.Text = newOrder.VegetablesCost.ToString();
            newOrder.PremiumAdditionsCost = calculate.calculatePremiumAdditions(newOrder.CountPremiumAdditions).ToString();
            lblPremiumAdditionsCost.Text = newOrder.PremiumAdditionsCost.ToString();
            newOrder.MealOptionCost = calculate.calculateMealOption(newOrder.Meal).ToString();
            lblMealOptionCost.Text = newOrder.MealOptionCost.ToString();
            newOrder.Subtotal = calculate.calculateSubTotal(newOrder.SizeCost, newOrder.ToastCost, newOrder.SpreadCost, newOrder.VegetablesCost, newOrder.PremiumAdditionsCost).ToString();
            lblSubtotal.Text = newOrder.Subtotal.ToString();
            newOrder.Tax = calculate.calculateTax(newOrder.SizeCost, newOrder.ToastCost, newOrder.SpreadCost, newOrder.VegetablesCost, newOrder.PremiumAdditionsCost).ToString();
            lblTax.Text = newOrder.Tax.ToString();
            newOrder.Total = calculate.calculateTotal(newOrder.SizeCost, newOrder.ToastCost, newOrder.SpreadCost, newOrder.VegetablesCost, newOrder.PremiumAdditionsCost, newOrder.Tip).ToString();
            lblTotal.Text = newOrder.Total.ToString();
            //Apply currency conversion on strings
            decimal temp = Convert.ToDecimal(lblTips.Text);
            lblTips.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblSizeCost.Text);
            lblSizeCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblToastCost.Text);
            lblToastCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblSpreadCost.Text);
            lblSpreadCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblVegetablesCost.Text);
            lblVegetablesCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblPremiumAdditionsCost.Text);
            lblPremiumAdditionsCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblMealOptionCost.Text);
            lblMealOptionCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblSubtotal.Text);
            lblSubtotal.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblTax.Text);
            lblTax.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblTotal.Text);
            lblTotal.Text = temp.ToString("C");

            /*
            //These lines of code only take information submitted via form from an html website and assigns it to labels in this aspx page
            lblName.Text = Request.Form["name"];
            lblPhoneNumber.Text = Request.Form["phone"];
            lblSize.Text = Request.Form["size"];
            lblToast.Text = Request.Form["toast"];
            lblSpread.Text = Request.Form["spread"];
            lblVegetables.Text = Request.Form["vegetables"];
            lblPremiumAdditions.Text = Request.Form["premiumAddition"];
            lblMeal.Text = Request.Form["meal"];
            //Ensuring that a blank tip is a $0.00 tip
            if (Request.Form["tip"].ToString() == "")
            {
                lblTips.Text = 0.00m.ToString();
            }
            else
            {
                lblTips.Text = Convert.ToDecimal(Request.Form["tip"]).ToString();
            }
            //End if else
            //Quantifying the amounts of each item of each category for later cost calculations
            if (Request.Form["spread"] == null)
            {
                lblCountSpread.Text = 0.ToString();
            }
            else
            {
                string spread = Request.Form["spread"];
                string[] countSpread = spread.Split(',');
                lblCountSpread.Text = countSpread.Count().ToString();

            }
            //End if else
            //Quantifying the amounts of each item of each category for later cost calculations
            if (Request.Form["vegetables"] == null)
            {
                lblCountVegetables.Text = 0.ToString();
            }
            else
            {
                string vegetables = Request.Form["vegetables"];
                string[] countVegetables = vegetables.Split(',');
                lblCountVegetables.Text = countVegetables.Count().ToString();
            }
            //End if else
            //Quantifying the amounts of each item of each category for later cost calculations
            if (Request.Form["premiumAddition"] == null)
            {
                lblCountPremiumAdditions.Text = 0.ToString();
            }
            else
            {
                string premiumAdditions = Request.Form["premiumAddition"];
                string[] countPremiumAdditions = premiumAdditions.Split(',');
                lblCountPremiumAdditions.Text = countPremiumAdditions.Count().ToString();
            }
            //End if else
            //Calculate costs for receipt
            lblSizeCost.Text = calculate.calculateSize(Request.Form["size"]).ToString();
            lblToastCost.Text = calculate.calculateToast(Request.Form["toast"]).ToString();
            lblSpreadCost.Text = calculate.calculateSpread(lblCountSpread.Text).ToString();
            lblVegetablesCost.Text = calculate.calculateVegetables(lblCountVegetables.Text).ToString();
            lblPremiumAdditionsCost.Text = calculate.calculatePremiumAdditions(lblCountPremiumAdditions.Text).ToString();
            lblMealOptionCost.Text = calculate.calculateMealOption(Request.Form["meal"]).ToString();
            lblSubtotal.Text = calculate.calculateSubTotal(lblSizeCost.Text, lblToastCost.Text, lblSpreadCost.Text, lblVegetablesCost.Text, lblPremiumAdditionsCost.Text).ToString();
            lblTax.Text = calculate.calculateTax(lblSizeCost.Text, lblToastCost.Text, lblSpreadCost.Text, lblVegetablesCost.Text, lblPremiumAdditionsCost.Text).ToString();
            lblTotal.Text = calculate.calculateTotal(lblSizeCost.Text, lblToastCost.Text, lblSpreadCost.Text, lblVegetablesCost.Text, lblPremiumAdditionsCost.Text, lblTips.Text).ToString();
            //Apply currency conversion on strings
            decimal temp = Convert.ToDecimal(lblTips.Text);
            lblTips.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblSizeCost.Text);
            lblSizeCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblToastCost.Text);
            lblToastCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblSpreadCost.Text);
            lblSpreadCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblVegetablesCost.Text);
            lblVegetablesCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblPremiumAdditionsCost.Text);
            lblPremiumAdditionsCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblMealOptionCost.Text);
            lblMealOptionCost.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblSubtotal.Text);
            lblSubtotal.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblTax.Text);
            lblTax.Text = temp.ToString("C");
            temp = Convert.ToDecimal(lblTotal.Text);
            lblTotal.Text = temp.ToString("C");*/
        }
    }
}