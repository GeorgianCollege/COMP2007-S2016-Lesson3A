using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 * @Author: Tom Tsiliopoulos
 * @Date: May 26, 2016
 * @Version: 0.0.1 - added setActivePage method
 */
namespace COMP2007_S2016_Lesson3
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            setActivePage();
        }

        /**
         * This method adds an css class of "active" to list items
         * when switching pages
         * 
         * @method setActivePage
         * @return void
         */
        private void setActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}