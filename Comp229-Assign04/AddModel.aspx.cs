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
        
              

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            var filePath = MapPath("~/App_Data/Assign04.json");
            Mini item = new Mini();
            item.MiniName = MiniNameTextBox.Text;
            item.faction = FactionTextBox.Text;
            item.rank=Convert.ToInt32(RankTextBox.Text);
            item._base= Convert.ToInt32(BaseTextBox.Text);
            item.size=Convert.ToInt32(SizeTextBox.Text);
            item.deploymentZone = DeploymentZoneTextBox.Text;
            item.mobility = Convert.ToInt32(MobilityTextBox.Text);
            item.willpower = Convert.ToInt32(WillpowerTextBox.Text);
            item.resiliance=Convert.ToInt32(ResilianceTextBox.Text);
            item.wounds = Convert.ToInt32(WoundDateTextBox.Text);
            
            if (File.Exists(filePath))
            {
                var jsonString = File.ReadAllText(filePath);
                //Get json file contents into string
                var collection = JsonConvert.DeserializeObject<List<Mini>>(jsonString);

                collection.Add(item);
                //Write the web content into json File
                File.WriteAllText(filePath, JsonConvert.SerializeObject(collection));
               
            }

            this.mailItem();

            // Finally Back to Landing page
            Response.Redirect("Default.aspx");
        }
       

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Back to Landing page
            Response.Redirect("Default.aspx");
        }
        public void mailItem()
        {
            
            SmtpClient smtpClient = new SmtpClient();
            MailMessage message = new MailMessage();
            try
            {
                MailAddress fromAddress = new MailAddress("cc-comp229f2016@outlook.com", "From Me");
                MailAddress toAddress = new MailAddress("aroy34@my.centennialcollege.ca", "To You");
                message.From = fromAddress;
                message.To.Add(toAddress);
                message.Subject = "Testing!";
                message.Body = "This is the body of a sample message";
                message.Attachments.Add(new Attachment(MapPath("~/App_Data/Assign04.json")));
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("cc-comp229f2016@outlook.com", "comp229pwd");
                smtpClient.Send(message);
                Response.Write("E-mail sent!");
                //statusLabel.Text = "Email sent.";
            }
            catch (Exception ex)
            {
                //statusLabel.Text = ;
                Response.Write("Coudn't send the message!" + ex.Message);
            }
           
        }
    }
}