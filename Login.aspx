<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Jason_LLC.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script> 
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
        
   <asp:Label  ID="Warn" class="label label-danger"  runat="server">Wrong Username or Password!</asp:Label>
   
    <div class="container">
     <div class="form-group">
            
            <asp:Label ID="Label1" ForeColor="White" runat="server">Username:</asp:Label>
         <asp:TextBox ID="UserName"  class="form-control"  placeholder="Enter Username" runat="server"></asp:TextBox>
            
        </div>
        <div class="form-group">
           <asp:Label ForeColor="White"  for="pwd" runat="server">Password:</asp:Label>
            <asp:TextBox TextMode="Password" ID="Password" class="form-control" placeholder="Enter Password"  runat="server"></asp:TextBox>
                     
        </div>
        
        <asp:Button ID="Button1" type="submit" class="btn btn-success" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
         </form>
</body>
</html>
