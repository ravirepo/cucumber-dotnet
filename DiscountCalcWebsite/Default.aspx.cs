using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DiscountCalcEngine.DiscountCalculator discountCalculator =
                new DiscountCalcEngine.DiscountCalculator();
            discountCalculator.IsSeniorCitizen = isSeniorCitizen.Checked;
            discountCalculator.State = ddlState.SelectedValue;
            discountCalculator.Profession = txtProfession.Text;

            int discount = discountCalculator.calculateDiscount();
            lblDiscount.Text = discount.ToString();
        }
    }
}