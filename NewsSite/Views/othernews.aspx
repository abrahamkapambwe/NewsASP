<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="othernews.aspx.cs" Inherits="NewsSite.Views.othernews" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:ListView ID="lstothernews" runat="server" OnItemDataBound="lstothernews_itemDatabound">
            <LayoutTemplate>
                <div id="itemPlaceholder" runat="server">
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div style="clear: both; margin-right: 10px; height: 200px; margin-bottom: 5px; margin-top: 5px">
                    <div class="viewport">
                        <asp:Image ID="imgPhoto" runat="server" Style="margin-bottom: 20px" alt='<%#Eval("NewsHeadline") %>'
                            Width="100%" Height="100%" title='<%#Eval("NewsHeadline") %>' />
                    </div>
                    <div class="information-design">
                        <div class="template-name">
                            <span>
                                <asp:HyperLink runat="server" ID="hyperNavi" class="brand type-of-story">
                                            <%# Eval("NewsHeadline") %></asp:HyperLink><br />
                                <asp:HyperLink ID="linksummary" class="template-author" runat="server">
                                                <%# Eval("SummaryContent")%></asp:HyperLink></span>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
