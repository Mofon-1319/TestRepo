<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="LoginMP.aspx.cs" Inherits="BusBookingSystem.LoginMP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table {
            background-color:;
            height: 80px;
            width: 340px;
        }
        .text {
            height: 100px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainForm" runat="server">
    <table align="center">

        <tr class="text">
            <td  style="color:crimson; font-size:x-large" >UserId</td>
            <td>&nbsp;
                    <asp:TextBox ID="userId" runat="server" Placeholder="Enter UserId" Height="29px" Width="180px"></asp:TextBox>
            </td>
        </tr>

        <tr class="text">
            <td style="color:crimson; font-size:x-large">Password</td>
            <td>&nbsp;
                    <asp:TextBox ID="password" TextMode="Password" runat="server" Placeholder="Enter Password" Height="29px" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="Login" Height="35px" Width="114px" OnClick="loginButton_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
