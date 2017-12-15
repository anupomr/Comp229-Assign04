<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddModel.aspx.cs" Inherits="Comp229_Assign04.AddModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Model Details</h1>
                <h5>All fields are  required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="MiniNameTextBox">Mini Name   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="MiniNameTextBox"
                        placeholder="Mini Name" required="true">  
                    </asp:TextBox>
                </div>



                <div class="form-group">
                    <label class="control-label" for="FactionTextBox">Faction   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="FactionTextBox"
                        placeholder=" Faction " required="true">    </asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="RankTextBox">Rank   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="RankTextBox"
                        placeholder="Rank" required="true">  </asp:TextBox>
                </div>
               
                <div class="form-group">
                    <label class="control-label" for="BaseTextBox">Base   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="BaseTextBox"
                        placeholder=" Base " required="true">    </asp:TextBox>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="SizeTextBox">Size   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="SizeTextBox"
                        placeholder="Size" required="true">  </asp:TextBox>
                </div>
                 <div class="form-group">
                    <label class="control-label" for="DeploymentZoneTextBox">Deployment Zone   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="DeploymentZoneTextBox"
                        placeholder="Deployment Zone" required="true">  </asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="MobilityTextBox">Mobility   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="MobilityTextBox"
                        placeholder="Mobility" required="true">  </asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="WillpowerTextBox">Willpower   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="WillpowerTextBox"
                        placeholder="Willpower" required="true">  </asp:TextBox>
                </div>


                 <div class="form-group">
                    <label class="control-label" for="ResilianceTextBox">Resiliance   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="ResilianceTextBox"
                        placeholder="Resiliance " required="true">    </asp:TextBox>
                </div>
                

                <div class="form-group">
                    <label class="control-label" for="WoundTextBox">Wound   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="WoundDateTextBox"
                        placeholder="Wounds " required="true">    </asp:TextBox>
                </div>

                <div class="text-right">
                    <asp:Button Text="cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                        UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server"
                        OnClick="SaveButton_Click" />
                </div>

            </div>
        </div>
    </div>

</asp:Content>
