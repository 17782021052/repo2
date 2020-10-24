<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="layui.users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="关键字"></asp:Label><asp:TextBox ID="TB_key" runat="server" Width="177px"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" Width="142px" /><br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="账户" />
                    <asp:BoundField DataField="user_name" HeaderText="姓名" />
                    <asp:BoundField DataField="gender" HeaderText="性别" />
                    <asp:BoundField DataField="mobile_phone" HeaderText="电话" />
                    <asp:BoundField DataField="create_time" HeaderText="创建时间" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
