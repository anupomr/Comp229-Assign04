﻿<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Comp229_Assign04.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   
    <h3>Hit Games</h3>
     <a href="AddModel.aspx" class="btn btn-success btn-sm">
                   <i class="fa fa-plus"></i>Add Model
               </a>
    <asp:GridView ID="JsonGridView" runat="server" AutoGenerateColumns="false"
                    cssClass="table table-bordered table-striped table-hover" DataKeyNames="MiniName">
                    <Columns>
                        <asp:HyperLinkField DataTextField="MiniName" HeaderText="Mini Name" Visible="true" 
                             DataNavigateUrlFields="MiniName" DataNavigateUrlFormatString="Model.aspx?MiniName={0}" />
                        <asp:BoundField DataField="MiniName" HeaderText="Mini Name" Visible="false" />
                        <asp:BoundField DataField="faction" HeaderText="Faction" Visible="true" />
                        <asp:BoundField DataField="rank" HeaderText="Rank" Visible="true" />
                        <asp:BoundField DataField="_base" HeaderText="Base" Visible="true" />
                        <asp:BoundField DataField="size" HeaderText="size" Visible="true" />
                        <asp:BoundField DataField="deploymentZone" HeaderText="Deployment Zone" Visible="true" />
                        <asp:BoundField DataField="mobility" HeaderText="Mobility" Visible="true" />
                        <asp:BoundField DataField="willpower" HeaderText="Willpower" Visible="true" />

                        <asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg' aria-hidden='true'></i> Update"
                            NavigateUrl="~/UpdateModel.aspx.cs" ControlStyle-CssClass="btn btn-primary btn-sm"
                            runat="server" DataNavigateUrlFields="MiniName"
                            DataNavigateUrlFormatString="UpdateModel.aspx?MiniName={0}" />

                        
                    </Columns>
                </asp:GridView>

</asp:Content>
