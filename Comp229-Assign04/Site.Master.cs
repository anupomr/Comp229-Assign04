using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home":
                    home.Attributes.Add("class", "active");
                    Page.Title = string.Format("EWGame :: Home :: {0:d}", DateTime.Now);
                    break;
                case "Model":
                    model.Attributes.Add("class", "active");
                    Page.Title = string.Format("EWGame :: Model :: {0:d}", DateTime.Now);
                    break;
                
               
            }
        }
    }
}