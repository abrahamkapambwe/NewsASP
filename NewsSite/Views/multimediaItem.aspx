<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="multimediaItem.aspx.cs" Inherits="NewsSite.Views.multimediaItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <div>
            <asp:Label runat="server" ID="lblTitle"></asp:Label><br />
            <asp:Label runat="server" ID="lblContent"></asp:Label>
        </div>
    </div>
    <div>
    </div>
</asp:Content>
