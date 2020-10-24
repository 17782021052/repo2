<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="layui.user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="关键字"></asp:Label><asp:TextBox ID="TB_key" runat="server" Width="177px"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="搜索" OnClick="Button1_Click" Width="142px" /><br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="账户" />
                <asp:BoundField DataField="user_name" HeaderText="姓名" />
                <asp:BoundField DataField="gender" HeaderText="性别" />
                <asp:BoundField DataField="mobile_phone" HeaderText="电话" />
                <asp:BoundField DataField="create_time" HeaderText="创建时间" />
                <asp:CommandField ShowEditButton="True" HeaderText="编辑" />
                <asp:CommandField ShowDeleteButton="True" HeaderText="删除" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</asp:Content>
