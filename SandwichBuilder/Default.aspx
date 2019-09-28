<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SandwichBuilder.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
    <title>Sandwich Builder Result</title>
    <style type="text/css">
        .auto-style1 {
                    min-width: 510px;
        }
        .auto-style5 {
                    min-width: 510px;
        }
        .auto-style6 {
                min-width: 510px;
        }
        .auto-style7 {
        min-width: 510px;
        }
        .auto-style8 {
            min-width: 510px;
        }
        .auto-style9 {
            min-width: 510px;
        }
    </style>
</head>
<body>
    <div id ="header">
        <h1>Your Receipt</h1>
        </div>
    <form id="form1" runat="server">
            <table class="auto-style6" 75%";" id="receipt" style="text-align: left">
                <tr>
                    <td class="auto-style1" style="text-align: left">Name:
            <asp:Label ID="lblName" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">Telephone Number:
            <asp:Label ID="lblPhoneNumber" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9" style="text-align: left"><strong>Order</strong></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">Size:
            <asp:Label ID="lblSize" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" style="text-align: left">Toasted:
            <asp:Label ID="lblToast" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">Spread:
            <asp:Label ID="lblSpread" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">Quantity:
            <asp:Label ID="lblCountSpread" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">Vegetables: <asp:Label ID="lblVegetables" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8" style="text-align: left">Quantity:
            <asp:Label ID="lblCountVegetables" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">Premium Additions:<asp:Label ID="lblPremiumAdditions" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8" style="text-align: left">Quantity:
            <asp:Label ID="lblCountPremiumAdditions" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">Meal Option:<asp:Label ID="lblMeal" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"><strong style="text-align: right;">Receipt</strong></td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">Size:
            <asp:Label ID="lblSizeCost" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" style="text-align: left;">Toasted:
            <asp:Label ID="lblToastCost" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">Spread: <asp:Label ID="lblSpreadCost" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">Vegetables:
            <asp:Label ID="lblVegetablesCost" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">Premium Additions:
            <asp:Label ID="lblPremiumAdditionsCost" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">Meal Option:
            <asp:Label ID="lblMealOptionCost" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">SubTotal: <asp:Label ID="lblSubtotal" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">Tax (8%):
            <asp:Label ID="lblTax" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">Tips:
            <asp:Label ID="lblTips" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1" style="text-align: left;">&nbsp;Total:
            <asp:Label ID="lblTotal" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
