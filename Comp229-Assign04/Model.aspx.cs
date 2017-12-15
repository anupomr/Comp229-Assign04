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
                // Get the  DataList
                this.getGames();
            }
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
                
                // bind the result to the  Datalist

                var models = from selecetedModel in collection
                                 where selecetedModel.MiniName == miniName
                             select selecetedModel;

                DataList.DataSource = models;
                DataList.DataBind();
            }
        }

        protected void DataList_ItemCommand(object source, DataListCommandEventArgs e)
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


                Response.Redirect("Default.aspx");
            }
        }
    }
}