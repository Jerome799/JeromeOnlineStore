<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JeromeOnlineStore._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" type="text/css" href="SS_Default.css" />
    <!--<h1><%: Title %>.</h1>-->
    <br />
    <br />
    <br />
    <h2 style="width: 100%">Welcome to Rich Kids online store</h2>
    <p class="lead">
        On this site you can browse through a plethora of bling bling clothes and shoes
        that'll have you looking like the rich kid that you always dreamed.
    </p>

    <section>
        <div>
            <asp:ListView ID="categoryList" runat="server" GroupItemCount="3" ItemType="JeromeOnlineStore.Models.Category" SelectMethod="getCategories">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td />
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td><a href="<%#:Item.pageName%>">
                                    <img width="200" height="200" src="Images/<%#:Item.imagePath%>"/></a>
                                </td>
                            </tr>
                            <tr>
                                <td align="center">
                                    <br />
                                    <a href="<%#:Item.pageName%>"><span><%#:Item.Name%> </span></a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width: 100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width: 100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>

</asp:Content>
