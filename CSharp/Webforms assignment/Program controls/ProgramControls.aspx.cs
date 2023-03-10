using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramControls
{
    public partial class ProgramControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                image.ImageUrl = "Image/Apple-Ipad.png";
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                image.ImageUrl = "Image/Apple-iphone-12.png";
            }
            else if(DropDownList1.SelectedIndex == 2)
            {
                image.ImageUrl = "Image/Apple-Macbook.png";
            }
            else
                image.ImageUrl = "Image/Apple-watch.png";
        } 

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex > -1)
            { 
              int pr = DropDownList1.SelectedIndex;
                mrp.Text = "Rs ";
                if (pr == 0)
                    mrp.Text += "50000";
                else if (pr == 1)
                    mrp.Text += "90000";

                else if (pr == 2)
                    mrp.Text += "190000";
                else 
                    mrp.Text += "30000";


            }
        }
    }
}