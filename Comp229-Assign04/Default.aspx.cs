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
    public partial class Index : System.Web.UI.Page
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
            // Joson file in the project.
            var filePath = MapPath("~/App_Data/Assign04.json");

            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                //Get json file contents into string
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);
                
                // bind the result to the Datalist

                 var models = from selectModel in collection
                              select selectModel;

                JsonGridView.DataSource = models;
                JsonGridView.DataBind();

                

            }
           


        }

       /* protected void JsonGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string miniName = Request.QueryString["MiniName"];

            // Joson file in the project.
            var filePath = MapPath("~/App_Data/Assign04.json");


            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                //Get json file contents into string
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);



                var modelsDelete = from delModel in collection
                                   where delModel.MiniName == miniName
                                   select delModel;
                // Remove Model from Collection
                foreach (var item in modelsDelete)
                {
                    collection.Remove(item);
                }

                this.getGames();
                Response.Redirect("Default.aspx");
            }
        }*/
    }
}