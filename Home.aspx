<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Jason_LLC.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <title></title>
      <style>
   #bg{
       background-color:darkgray;
   }
</style>
 
 
</head>
<body id="bg">
 <nav class="navbar navbar-inverse">
       <div class="container-fluid">
           <div class="navbar-header">
              <a class="navbar-brand" href="Login.aspx">Micro Fiber Cleaning</a>
           </div>
           <div>
           <ul class="navbar navbar-nav">
               <li class="active"><a href="Home.aspx">Home</a></li>
               </ul>
               <ul class="navbar navbar-nav">
               <li><a href="EmployeeApp.aspx">Careers</a></li>
                    </ul>
               <ul class="navbar navbar-nav">
               <li><a href="About.aspx">About</a></li>
                    </ul>
               <ul class="nav navbar-nav navbar-right">
               <li><a href="Login.aspx"><span class="glyphicon glyphicon-log-in"></span> Login</a></li></ul>
               </div>
       </div>
   </nav>
    <form id="form1" runat="server">
        <div>
            Welcome Jason</div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
