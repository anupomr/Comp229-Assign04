<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Comp229_Assign04.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %>.</h2>
    <h3>Your Landing page.</h3>
    
    <asp:GridView ID="JsonGridView" runat="server" AutoGenerateColumns="false"
                    cssClass="table table-bordered table-striped table-hover" >
                    <Columns>
                     
                        <asp:BoundField DataField="MiniName" HeaderText="Mini Name" Visible="true" />
                        <asp:BoundField DataField="faction" HeaderText="Faction" Visible="true" />
                        <asp:BoundField DataField="rank" HeaderText="Rank" Visible="true" />
                        <asp:BoundField DataField="_base" HeaderText="Base" Visible="true" />
                        <asp:BoundField DataField="size" HeaderText="size" Visible="true" />
                        <asp:BoundField DataField="deploymentZone" HeaderText="Deployment Zone" Visible="true" />
                        <asp:BoundField DataField="mobility" HeaderText="Mobility" Visible="true" />
                        <asp:BoundField DataField="willpower" HeaderText="Willpower" Visible="true" />
                    </Columns>
                </asp:GridView>

</asp:Content>
