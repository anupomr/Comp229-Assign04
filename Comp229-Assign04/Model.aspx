<%@ Page Title="Model" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Model.aspx.cs" Inherits="Comp229_Assign04.Model" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Model Directory</h1>
    <asp:DataList ID="DataList" runat="server">
        <ItemTemplate>
            <asp:Literal ID="extraDetailsLiteral" runat="server" EnableViewState="false" />
            Name: <strong><%#Eval("MiniName")%></strong><br />           
            Faction: <strong><%#Eval("faction")%></strong><br />
            Rank: <strong><%#Eval("rank")%></strong><br />
             Base: <strong><%#Eval("_base")%></strong><br />
             Size: <strong><%#Eval("size")%></strong><br />
            Deployment Zone: <strong><%#Eval("deploymentZone")%></strong><br />
            Mobility: <strong><%#Eval("mobility")%></strong><br />
            Willpower: <strong><%#Eval("willpower")%></strong><br />
            Image :
            <br />
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("imageUrl") %>' Height="280px" Width="300px" />
            <br />
            
        </ItemTemplate>
        <ItemStyle BackColor="#ff0000"></ItemStyle>
        
    </asp:DataList>

</asp:Content>
