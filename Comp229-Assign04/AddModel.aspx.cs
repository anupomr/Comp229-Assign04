using Comp229_Assign04.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class AddModel : System.Web.UI.Page
    {
        
        List<Mini> items = new List<Mini>();
        public int pos = 2;
        Mini item = new Mini();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
           
            TextWriter writer= new StreamWriter("F:\\Semester3\\ASPLAB\\Comp229-Assign04\\Comp229-Assign04\\App_Data\\Model.json");
            
            item.MiniName = MiniNameTextbox.Text;
            item.willpower = Convert.ToInt32(WillpowerTextbox.Text);
            item.mobility = Convert.ToInt32(MobilityTextBox.Text);
            item.wounds = Convert.ToInt32(WoundDateTextbox.Text);
            //items.Insert(pos, item);
           // items= Global.Mini.ToList();
            items.Add(item);
            
           
                using (writer)
                {
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    writer.WriteLine(serializer.Serialize(items));
                }
           
            Response.Redirect("Default.aspx");
        }
       

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}