<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="layui.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="css/layui.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .div1{
            width:100%;
            text-align:center;
        }
    </style>

</head>
<body>
    <form class="layui-form" action="" lay-filter="example" runat="server" style="width: 100%; height: 100%;text-align:center;background-color:yellow">
        <div class="div1">
            <div class="layui-form-item" style="text-align: center">
                <label class="layui-form-label">账号框</label>
                <div class="layui-input-block" style="width: 300px">
                    <%--<input type="text" name="username" lay-verify="title" autocomplete="off" placeholder="请输入标题" class="layui-input">--%>
                    <asp:TextBox ID="TextBox2" runat="server" name="username" lay-verify="title" autocomplete="off" placeholder="请输入账号" class="layui-input"></asp:TextBox>
                </div>
            </div>
            <div class="layui-form-item" style="text-align: center">
                <label class="layui-form-label">密码框</label>
                <div class="layui-input-block" style="width: 300px">
                    <%--<input type="password" name="password" placeholder="请输入密码" autocomplete="off" class="layui-input">--%>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" name="password" placeholder="请输入密码" autocomplete="off" class="layui-input"></asp:TextBox>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
