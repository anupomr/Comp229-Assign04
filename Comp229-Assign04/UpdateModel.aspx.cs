using Comp229_Assign04.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign04
{
    public partial class UpdateModel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get the Student Data
                this.getGames();
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Back to Landing page
            Response.Redirect("Default.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            string miniName = Request.QueryString["MiniName"];
            var filePath = MapPath("~/App_Data/Assign04.json");
            //Mini item = new Mini();
            


           

            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                //Get json file contents into string
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
                var models = from selectModel in collection
                             where selectModel.MiniName == miniName
                             select selectModel;
                foreach (Mini item in models)
                {
                    item.MiniName = MiniNameTextBox.Text;
                    item.faction = FactionTextBox.Text;
                    item.rank = Convert.ToInt32(RankTextBox.Text);
                    item._base = Convert.ToInt32(BaseTextBox.Text);
                    item.size = Convert.ToInt32(SizeTextBox.Text);
                    item.deploymentZone = DeploymentZoneTextBox.Text;
                    item.mobility = Convert.ToInt32(MobilityTextBox.Text);
                    item.willpower = Convert.ToInt32(WillpowerTextBox.Text);
                    item.resiliance = Convert.ToInt32(ResilianceTextBox.Text);
                    item.wounds = Convert.ToInt32(WoundDateTextBox.Text);
                    //collection.Add(item);
                }
                
                //Write the web content into json File
                File.WriteAllText(filePath, JsonConvert.SerializeObject(collection));
                
            }           

            // Finally Back to Landing page
            Response.Redirect("Default.aspx");

        }

        private void getGames()
        {
            string miniName = Request.QueryString["MiniName"];
            // Joson file in the project.
            var filePath = MapPath("~/App_Data/Assign04.json");

            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                //Get json file contents into string
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);

                // bind the result to the Datalist

                var models = from selectModel in collection
                             where selectModel.MiniName == miniName
                             select selectModel;
                foreach (var item in models)
                {                    
                    MiniNameTextBox.Text = item.MiniName;
                    FactionTextBox.Text = item.faction;
                    RankTextBox.Text = Convert.ToString(item.rank);
                    BaseTextBox.Text= Convert.ToString(item._base);
                    SizeTextBox.Text = Convert.ToString(item.size);
                    DeploymentZoneTextBox.Text=item.deploymentZone ;
                    MobilityTextBox.Text=Convert.ToString(item.mobility);
                    WillpowerTextBox.Text=  Convert.ToString(item.willpower);
                    ResilianceTextBox.Text = Convert.ToString(item.resiliance);
                    WoundDateTextBox.Text=  Convert.ToString(item.wounds);
                }
            }
        }
    }
}