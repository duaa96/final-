<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login"  EnableEventValidation="false"%>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl">
<head runat="server">
     <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Login</title>

    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet">

    <link href="css/animate.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">

</head>
<body style=" background-image: url('img/Pic.jpg'); width="100%" >
       <form id="frm1" runat="server">
        <div class="middle-box text-center loginscreen animated fadeInDown">
        <div class="row">

           <br/>  <br/>  <br/>  <br/>
                <div class="ibox-content">
                    <form class="m-t" role="form" action="index.html">
                         <img src="img/logo.png" width="200 px" align="center"/>
                        <div>
                            <p style="color:#0077C0">
                                <b>
                          تسجيل الدخول
                                    </b>
                            </p>
                            </div>
                        <div class="form-group">
                           <asp:TextBox ID="txtUsername" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                             <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        </div>
                       <div class="form-group">
                           <table border ="0" dir="rtl" align="right">
                               <tr>
                                <td> <label>  </label> </td>
                                <td>  </td>
                                <td>  <asp:RadioButton ID="rdbStudent" runat="server"  Text=" طالب" GroupName="login"/> 
                                    <br/>

                                    <asp:RadioButton ID="rdbEmployee" runat="server"  Text ="موظف" GroupName="login"  />
                                </td>
                                 <td> </td>
                                 </tr>
                             



                               </table>

                           </div>
                        <asp:Button ID="btnLogin" runat="server" class="btn btn-primary block full-width m-b" Text="تسجيل الدخول" OnClick="btnLogin_Click1" />
                        <div class="form-group">
                            <asp:Label ID="lbWrong" runat="server" Visible="False" Font-Bold="True" ForeColor="#CC0000"></asp:Label>  

                </div>
                       

                       

                        <p class="text-muted text-center">
                            
                        </p>
                       
                    </form>
                    <p class="m-t">
                       <br/><br/><br/>
                    </p>
                </div>
           
        </div>
       
        </div>


</form>
