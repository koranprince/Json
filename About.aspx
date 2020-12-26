<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Jason_LLC.About" %>

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
    <style>
   #ko{
       background-color:darkgray;
   }
</style>
<style type="text/css">
    .jumbotron{
    margin-bottom: 20px;
    background-image: url("Images/Header%20Photo%20About%20page.jpg");
    background-size: cover;
    
    }
    


</style>

<style>
   .carousel-inner > .item > img {
    margin: 0 auto;
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
    <div class="container">
    <div id="Jason Pictures" class="carousel slide" data-ride="carousel">
        
        <div class="carousel-inner">
            <div class="item active">
                <img src="Images/login.jpg" alt="Dentist" width="300" height="300" class="img-rounded" />
            </div>
            <div class="item">
                <img src="Images/Header%20Photo%20About%20page.jpg" alt="Building" width="300" height="300" class="img-rounded" />
            </div>
            <div class="item">
                <img src="Images/IMG_2433 (2).jpg"  alt="Building" width="300" height="300" class="img-rounded" />
            </div>
            <div class="item">
                <img src="Images/IMG_2430 (2).jpg"  alt="Building" width="300" height="300" class="img-rounded" />
            </div>
            <div class="item">
                <img src="Images/clean%20(2).jpg"  alt="Building" width="300" height="300" class="img-rounded" />
            </div>
        </div>
    </div>
       </div>

  <div class="container">
    
<p  style=" text-align:center"    >Microfiber Cleaning Services LLC is a janitorial cleaning company. We are a company committed to solving any cleaning issue that our customers may have.
    We are not just any cleaning company. Microfiber Cleaning Services LLC caters to its customers. 
    We will come up with the perfect plan that fits each customer. 
    Our pricing is the best in the industry. We will work with each customer.</p>
    
      </div>
</body>
</html>
