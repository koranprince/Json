<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeApp.aspx.cs" Inherits="Jason_LLC.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            text-decoration: underline;
        }
    </style>
</head>
<body>
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
    <form class="container" id="form1" runat="server">
        <div class="auto-style1" style="text-align: center">
            <strong>Application For Employment</strong></div>
   
    
 <div  class="auto-style2 container"

><strong>Personal Information</strong></div>


   
 <div class="container" style="height: 270px"

>
     <br />
     Name:<asp:TextBox ID="Name" runat="server" Height="16px" style="margin-left: 8px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     Address: <asp:TextBox ID="Address" runat="server" Height="16px" style="margin-left: 3px"></asp:TextBox>
     <br />
     <br />
     <br />
     City:<asp:TextBox ID="City" runat="server" Height="16px" style="margin-left: 8px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     State:<asp:TextBox ID="State" runat="server" Height="16px" style="margin-left: 5px"></asp:TextBox>
     <br />
     <br />
     Zip:
     <asp:TextBox ID="Zip" runat="server" Height="16px" style="margin-left: 12px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     Phone Number:
     <asp:TextBox ID="PhoneNumber" runat="server" Height="16px" style="margin-left: 6px" Width="100px"></asp:TextBox>
     <br />
     <br />
     
    Positions:<br />
&nbsp;<asp:DropDownList ID="PositionDrop" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
         <asp:ListItem  >Select Position</asp:ListItem>
         <asp:ListItem value ="House Keeper" >House Keeper</asp:ListItem>
        <asp:ListItem value ="Supervisor" >Supervisor</asp:ListItem>

     </asp:DropDownList>
     <br />
     <br />
     <br />
     <br />
 </div>

 <div class="container" style="height: 301px" id="div">
     <strong><span class="auto-style2">Employment History</span>

     <br />
     <br />
     <br />
     </strong>Employer:<strong>
     <asp:TextBox ID="Employer" runat="server" Height="16px" style="margin-left: 12px" Width="128px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;
     <br />
     <span class="auto-style2">
     <br />
     Dates Employed<br />
     </span><br />
     Start:
     <asp:TextBox ID="StartDate" runat="server" Height="16px" style="margin-left: 12px"></asp:TextBox>
     &nbsp;End:<asp:TextBox ID="EndDate" runat="server" Height="16px" style="margin-left: 12px"></asp:TextBox>
     <br />
     <br />
     </strong>

     <br />
     <br />
     <br />
     <br />
     Work Phone:
     <asp:TextBox ID="WorkPhone" runat="server" Height="16px" style="margin-left: 2px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;
     Address: <asp:TextBox ID="WorkAddress" runat="server" Height="16px" style="margin-left: 12px"></asp:TextBox>
     <br />
     <br />
     <br />
     City:
     <asp:TextBox ID="WorkCity" runat="server" Height="16px" style="margin-left: 2px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     State:
     <asp:TextBox ID="WorkState" runat="server" Height="16px" style="margin-left: 1px"></asp:TextBox>
     <br />
     <br />
     <br />
     <br />
     Zip:
     <asp:TextBox ID="WorkZip" runat="server" Height="16px" style="margin-left: 2px"></asp:TextBox>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     Position:
     <asp:TextBox ID="WorkPos" runat="server" Height="16px" style="margin-left: 3px"></asp:TextBox>
     <br />
     <br />
     <br />
     Supervisor:<asp:TextBox ID="Sup" runat="server" Height="16px" style="margin-left: 5px"></asp:TextBox>
     <br />
     <br />
     Reason for Leaving:
     <br />
     <asp:TextBox ID="RFL" runat="server" Height="43px" style="margin-left: 12px"></asp:TextBox>
     <br />
     <br />
     <br />
    <div style="text-align: center">
     <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
     </div>
     </div>
 </form>



    </body>
</html>
