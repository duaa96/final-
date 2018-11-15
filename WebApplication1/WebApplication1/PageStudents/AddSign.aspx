<%@ Page Title="" Language="C#" MasterPageFile="~/PageStudents/student.Master" AutoEventWireup="true" CodeBehind="AddSign.aspx.cs" Inherits="WebApplication1.AddSign" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class=" w3-cell-row ">
        <div class="w3-white w3-center navbar navbar-expand-lg w3-margin-top w3-margin-bottom w3-padding-24" style=" float: none;
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
            <h2 style="float: none;
    margin: 0 auto; font-family:'Amiri'">اضغط على الزر لإنشاء توقيعك الخاص  </h2>

        </div>
        
    </div>
     <div class="wrapper wrapper-content animated fadeInRight">


        <div class="row">
             <asp:Button ID="Button2" runat="server" OnClick="btnSave_Click" Text="انشاء توقيع " class="btn btn-primary btn-lg w3-margin-top" align="center" style="float: none;
    margin: 0 auto;" />
            
         </div>



</div>


</asp:Content>
