<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddModel.aspx.cs" Inherits="Comp229_Assign04.AddModel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Model Details</h1>
                <h5>All fields are  required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="MiniNameTextbox">Mini Name   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="MiniNameTextbox"
                        placeholder="Mini Name" required="true">  
                    </asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="WillpowerTextbox">Willpower   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="WillpowerTextbox"
                        placeholder="Willpower" required="true">  </asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="MobilityTextbox">Mobility   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="MobilityTextBox"
                        placeholder=" Mobility " required="true">    </asp:TextBox>
                </div>

                <div class="form-group">
                    <label class="control-label" for="WoundTextbox">Wound   </label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="WoundDateTextbox"
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
