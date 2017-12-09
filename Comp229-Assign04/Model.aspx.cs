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
    public partial class Model : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get the Student Data
                this.getGames();
            }
        }
        private void getGames()
        {
            string miniName = Request.QueryString["MiniName"];
            // Joson file in the project.
            var filePath = @"F:\Semester3\ASPLAB\Comp229-Assign04\Comp229-Assign04\App_Data\Assign04.json";
            //var filePath = HostingEnvironment.MapPath(@"App_Data/Assign04.json");
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                //Get json file contents into string
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
                
                // bind the result to the Student GridView

                var models = from c in collection
                                 where c.MiniName == miniName
                             select c;

                DataList.DataSource = models;
                DataList.DataBind();



            }



        }
    }
}