<%@ Page Title="" Language="C#" MasterPageFile="~/MainNews.Master" AutoEventWireup="true"
    CodeBehind="details.aspx.cs" Inherits="NewsSite.Views.details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="float: left">
        <asp:HiddenField runat="server" ID="hdfNewsID" />
        <div style="padding-left: 10px; padding-top: 5px">
            <h2>
                <asp:Label runat="server" ID="lblHeadline"></asp:Label><br />
            </h2>
            <br />
            <b>
                <asp:Label runat="server" ID="lblNewsAdded"></asp:Label><br />
            </b>
            <br />
            <div id="divNewsItem" runat="server">
            </div>
        </div>
    </div>
    <asp:ListView runat="server" ID="lstComments">
        <LayoutTemplate>
            <ul id="itemPlaceholder" runat="server">
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <li>
                <div>
                    <div class="comment">
                        <%#Eval("CommentItem")%>
                    </div>
                    <div class="usename">
                        Posted by <span style="color: Blue">
                            <%#Eval("CommentItem")%></span>
                    </div>
                    <div class="commentAdded">
                        <%#Eval("CommentAdded")%>
                    </div>
                    </>
                </div>
            </li>
        </ItemTemplate>
    </asp:ListView>
    <div>
        <asp:UpdatePanel runat="server" ID="updateComments">
            <ContentTemplate>
                <table>
                    <tr>
                        <td valign="top">
                            Name
                        </td>
                        <td>
                            <asp:TextBox class="textbox" runat="server" ID="txtName"></asp:TextBox><asp:RequiredFieldValidator
                                ID="RequiredFieldValidator1" ControlToValidate="txtName" runat="server" Text="*" ErrorMessage="Name is required"></asp:RequiredFieldValidator><br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            Email:
                        </td>
                        <td>
                            <asp:TextBox CssClass="textbox" runat="server" ID="txtEmail"></asp:TextBox>
                            
                            <br />
                            <asp:RegularExpressionValidator ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ID="RegularExpressionValidator1" ControlToValidate="txtEmail" runat="server" ErrorMessage="invalid email address"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEmail" ErrorMessage="email is required"></asp:RequiredFieldValidator>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            Comment
                        </td>
                        <td>
                            <asp:TextBox CssClass="textbox" MaxLength="2000" Height="200px" TextMode="MultiLine"
                                runat="server" ID="txtComment" /><asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                    runat="server" Text="*" ControlToValidate="txtComment" ErrorMessage="Comments are required"></asp:RequiredFieldValidator><br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button runat="server" ID="btnSubmit" CausesValidation="True" OnClick="btnSubmit_Click"
                                Text="Post Comment" />
                        </td>
                    </tr>
                </table>
                <div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
