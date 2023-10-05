<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="meetingroom.aspx.cs" Inherits="WebApplication6.meetingroom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title style="font-family: Arial, sans-serif;">Meeting Room Management System - VUEDATA TECH</title>
</head>
<body style="font-family: Arial, sans-serif; background-color: #f0f0f0; margin: 0; padding: 0;">
    <form id="form1" runat="server">
        <div style="margin: 20px; padding: 20px; background-color: #fff; border: 1px solid #ccc; border-radius: 5px;">
            <asp:HiddenField ID="hfEmployee_id" runat="server" />
            <table style="width: 100%;">
                <tr>
                    <td>
                        <asp:Label Text="Employee Name" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtemployee" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Meeting Rooms" runat="server" />
                    </td>
                    <td colspan="2">
                        <label for="txtmeetingroom"></label>
                        <asp:DropDownList ID="txtmeetingrooms" runat="server">
                            <asp:ListItem Text="Click" Value="Cubical Room" />
                            <asp:ListItem Text="Inspiration Chamber" Value="Inspiration Chamber" />
                            <asp:ListItem Text="War room" Value="War room" />
                            <asp:ListItem Text="Cubical Room" Value="Cubical Room" />
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label Text="Booking(Date,Time)" runat="server" />
                    </td>
                    <td colspan="2">
                        <asp:TextBox ID="txtBooking_meetDate_meetTime" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Button Text="Save" ID="btnSave" runat="server" OnClick="btnSave_Click" style="background-color: Green; color: #fff; padding: 5px 10px; border: none; border-radius: 5px; cursor: pointer;" />
                        <asp:Button Text="Delete" ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="background-color: Red; color: #fff; padding: 5px 10px; border: none; border-radius: 5px; cursor: pointer;" />
                        <asp:Button Text="Clear" ID="btnClear" runat="server" OnClick="btnClear_Click" style="background-color: Blue; color: #fff; padding: 5px 10px; border: none; border-radius: 5px; cursor: pointer;" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Label Text="" ID="lblSuccessMessage" runat="server" style="color: Green;" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Label Text="" ID="lblErrorMessage" runat="server" style="color: Red;" />
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Employee_name" HeaderText="Employee name" />
                    <asp:BoundField DataField="meeting_rooms" HeaderText="Meeting Rooms" />
                    <asp:BoundField DataField="Booking_meetDate_meetTime" HeaderText="Booking" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:linkButton Text="Select" ID="lnkSelect" CommandArgument='<%# Eval("Employee_id") %>' runat="server"  OnClick="lnkSelect_OnClick" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

