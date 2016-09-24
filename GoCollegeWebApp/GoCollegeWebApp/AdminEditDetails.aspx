<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEditDetails.aspx.cs" Inherits="GoCollegeWebApp.AdminEditDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>GoCollege</title>
<meta name="viewport" content="width=device-width, initial-scale=1" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="keywords" content="GoCollege, Collge"/>

<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
<link href="css/bootstrap.min.css" rel='stylesheet' type='text/css' />
<!--<link href="css/bootstrap.css" rel='stylesheet' type='text/css' />--> 
<!-- Custom Theme files -->
<link href="css/style.css" rel='stylesheet' type='text/css' />
<link href="css/font-awesome.css" rel="stylesheet"> 
<script src="js/jquery.min.js"> </script>
<script src="js/bootstrap.min.js"> </script>
  
<!-- Mainly scripts -->
<script src="js/jquery.metisMenu.js"></script>
<script src="js/jquery.slimscroll.min.js"></script>
<!-- Custom and plugin javascript -->
<link href="css/custom.css" rel="stylesheet">
<script src="js/custom.js"></script>
<script src="js/screenfull.js"></script>
		<script>
		    $(function () {
		        $('#supported').text('Supported/allowed: ' + !!screenfull.enabled);

		        if (!screenfull.enabled) {
		            return false;
		        }



		        $('#toggle').click(function () {
		            screenfull.toggle($('#container')[0]);
		        });



		    });
		</script>

<!----->

</head>
<body>
  	<div class="validation-system">
 		
 		<div class="validation-form">
 	<!---->
  	    
        <form id="adminEditDetails" runat="server">
 <%--           <div class="col-lg-4"></div>
            <div class="col-lg-4"></div>
            <div class="col-lg-4"></div>--%>

         	<div class="vali-form">
             <div class="clearfix"> </div>        

            <div class="col-md-6 form-group1 ">
              <label class="control-label">Name</label>
                <asp:TextBox ID="adminName" runat="server" placeholder="Firstname" required=""></asp:TextBox>
            </div>
      
             <div class="clearfix"> </div>        
            
            <div class="col-md-6 form-group1 ">
              <label class="control-label">Email</label>
                <asp:TextBox ID="adminEmail" runat="server" placeholder="Email" required=""></asp:TextBox>
            </div>

             <div class="clearfix"> </div>                           
            <div class="col-md-6 form-group1 ">
              <label class="control-label">Mobile Number</label>
            <asp:TextBox ID="adminMobile" runat="server" placeholder="Mobile Number" required=""></asp:TextBox>
            </div>
            <div class="clearfix"> </div>
            <div class="col-md-6 form-group1">
              <label class="control-label">New password</label>

            <asp:TextBox ID="adminPassword" runat="server" placeholder="New Password" required=""></asp:TextBox>

            </div>
             <div class="clearfix"> </div>        

            <div class="col-md-6 form-group1 ">
              <label class="control-label">Confirm password</label>
            <asp:TextBox ID="adminConfirmPassword" runat="server" placeholder="Confirm Password" required=""></asp:TextBox>

            </div>
        
             <div class="clearfix"> </div>
            <div class="col-md-6 form-group1 ">
              <label class="control-label">Address</label>
                <asp:T

              <textarea runat="server" id="adminAddress" placeholder="Enter your full address" required="">Your Address</textarea>
     
           </div>
    
          
            <div class="col-md-12 form-group ">
              <button type="submit" class="btn btn-primary">Submit</button>
              <button type="reset" class="btn btn-default">Reset</button>
            </div>
          <div class="clearfix"> </div>
        </form>
    
 	<!---->
 </div>

</div>

         <%--// JS--%> 
    <script src="js/jquery.nicescroll.js"></script>
	<script src="js/scripts.js"></script>
 
</body>
</html>
