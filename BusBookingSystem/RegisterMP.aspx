<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="RegisterMP.aspx.cs" Inherits="BusBookingSystem.RegisterMP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainForm" runat="server">
    <table align="center" style="height: 101px; width: 557px" background-image: url("BusBack.png")>
            <tr>
                <td class="auto-style2">Name</td>
                <td class="auto-style3">&nbsp;
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="requiredName" ControlToValidate="name" ErrorMessage="Name Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td class="auto-style2">Gender</td>
                <td class="auto-style3">&nbsp;
                    <asp:DropDownList ID="sex" runat="server" >
                        <asp:ListItem Text="Select" Value="Select" Selected="False" ></asp:ListItem>
                        <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="Sex" ErrorMessage="Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone</td>
                <td class="auto-style3">&nbsp;
                    <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="requiredPhone" ControlToValidate="phone" ErrorMessage="Number Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rgvMobileNumber" runat="server" ControlToValidate="requiredPhone" ErrorMessage="Enter valid mobile number" ValidationExpression="^[6789]\d{9}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Date of Birth</td>
                <td class="auto-style3">&nbsp;
                    <asp:TextBox ID="dob" runat="server" Type="Date"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td class="auto-style4">UserId</td>
                <td class="auto-style5">&nbsp;
                    <asp:TextBox ID="userId" runat="server"></asp:TextBox>
                    </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator3" ControlToValidate="userID" Style="color: palevioletred"></asp:RequiredFieldValidator>
                     <asp:RegularExpressionValidator ID="rgvMailId" runat="server" ControlToValidate="userId" ErrorMessage="Enter valid mail id" ValidationExpression="^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,5}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td>&nbsp;
                    <asp:TextBox ID="password" runat="server" Type="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="userID" ErrorMessage="Password Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        <div align="center">
            <asp:Button ID="submitButton" runat="server" align="center" Height="35px" Text="Submit" Width="114px" OnClick="submitButton_Click"  />
        </div>
</asp:Content>
