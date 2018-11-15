<%@ Page Title="" Language="C#" MasterPageFile="~/PageStudents/student.Master" AutoEventWireup="true" CodeBehind="Absenceexcuse.aspx.cs" Inherits="WebApplication1.Absenceexcuse"  EnableEventValidation="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2 align="center">نموذج تقديم عذر الغياب عن امتحان نهائي </h2>

        </div>
        <div class="col-lg-2">
        </div>
    </div>

    <div class="wrapper wrapper-content animated fadeInRight">
       

        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-content">
                       
                        <h3 style="text-align:center;" >نموذج رقم 14</h3> 

  <div align="center">
    &nbsp;<h  style="text-align:center; font-size: 20px;align-items: center;">كلية</h>&nbsp;<asp:Label ID="labCollage" runat="server"></asp:Label>
      </div>
                        
      <table width="90%"  border="1"  class="table5" align="center" dir="rtl"  >
  <tbody style="float:center;">
   
 <tr  style="font-size:18px; height:40px;  background-color:#F0F0F0;">
      
      <td style="width:270px ">&nbsp;من العام الجامعي<asp:Label ID="labYear" runat="server" Text="Label"></asp:Label>
      </td>
      <td style="width:270px"> 
          الفصل الدراسي<asp:Label ID="labSemester" runat="server" Text="Label"></asp:Label>
      </td>
    </tr>
  
  
  </tbody>
</table>
      &nbsp;


   <br>
<div align="right" dir="rtl">
    
  <a style="font-size:25px;" dir="rtl" align="right">السيد الدكتور عميد كلية&nbsp;
      المحترم</a>&nbsp;</a><asp:Label ID="labDean" runat="server" Text="Label"></asp:Label>
          <br><br><br>
    </div>


      <table width="90%"  border="1"  class="table5"  align="center" dir="rtl" >
  <tbody style="float:center;">
   

    <tr  style="font-size:18px; height:40px;  background-color:#F0F0F0;">
          <td style="width:100px"> 
              قسم<asp:Label ID="labSectionStudent" runat="server" Text="Label"></asp:Label>
          </td>

      <td style="width:270px"> 
          صاحب الرقم الجامعي<asp:Label ID="labNumberStudent" runat="server" Text="Label"></asp:Label>
          </td>
      <td style="width:270px">&nbsp;انا الطالب/ة<asp:Label ID="labStudentName" runat="server" Text="Label"></asp:Label>
          </td>
      
    </tr>
  </tbody>
</table>


<br/>
<a style="font-size: 20px; float:right; ">لقد تغيبت عن الامتحان النهائي للمساقات المذكورة أدناه:</a>
<br><br>
<table  border="1"  class="table5"  >
  <tbody style="float:right;">
    <tr  class="tr" style="background-color:#09A2BB; color:#FBFBFB; font-size:20px; height:40px; float:right; text-align: center;" >
      <th style="width:240px ;border:hidden" >موعد الامتحان النهائي</th>
      <th style="width:240px; border:hidden" >مدرس المساق</th>
      <th style="width:240px ;border:hidden" >رقم المساق</th>
      <th style="width:240px ;border:hidden" >اسم المساق</th>
      <th style="width:130px ;border:hidden"> الرقم</th>

    </tr>
    <tr>
        <th style="width:270px ; border:hidden" >
            <asp:TextBox ID="txtDateCourse1" runat="server"></asp:TextBox>
        </th>
      <th style="width:270px; border:hidden" >
          <asp:Label ID="labTeacher1" runat="server"></asp:Label>
        </th>
      <th style="width:270px; border:hidden" >
                                <span class="clear">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCourseNum1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
          </span>
          <asp:TextBox ID="txtCourseNum1" runat="server" OnTextChanged="txtCourseNum1_TextChanged" AutoPostBack="true"></asp:TextBox>
        </th>
      <th style="width:270px; border:hidden" >
          <asp:DropDownList ID="ddlCourse1" runat="server" OnSelectedIndexChanged="ddlCourse1_SelectedIndexChanged" AutoPostBack="true">
          </asp:DropDownList>
        </th>
      <th style="width:270px; border:hidden"> 1</th>
    </tr>
     <tr>
        <th style="border-style: hidden; border-color: inherit; border-width: medium;" class="auto-style1" >
            <asp:TextBox ID="txtDateCourse2" runat="server"></asp:TextBox>
         </th>
      <th style="border-style: hidden; border-color: inherit; border-width: medium;" class="auto-style1" >
          <asp:Label ID="labTeacher2" runat="server"></asp:Label>
         </th>
      <th style="border-style: hidden; border-color: inherit; border-width: medium;" class="auto-style1" >
          <asp:TextBox ID="txtCourseNum2" runat="server" OnTextChanged="txtCourseNum2_TextChanged" AutoPostBack="true"></asp:TextBox>
         </th>
      <th style="border-style: hidden; border-color: inherit; border-width: medium;" class="auto-style1" >
          <asp:DropDownList ID="ddlCourse2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse2_SelectedIndexChanged">
          </asp:DropDownList>
         </th>
      <th style="border-style: hidden; border-color: inherit; border-width: medium;" class="auto-style1"> 2</th>
    </tr>
     <tr>
        <th style="width:270px; border:hidden" >
            <asp:TextBox ID="txtDateCourse3" runat="server"></asp:TextBox>
         </th>
      <th style="width:270px; border:hidden" >
          <asp:Label ID="labTeacher3" runat="server"></asp:Label>
         </th>
      <th style="width:270px; border:hidden" >
          <asp:TextBox ID="txtCourseNum3" runat="server" OnTextChanged="txtCourseNum3_TextChanged" AutoPostBack="true" ></asp:TextBox>
         </th>
      <th style="width:270px; border:hidden" >
          <asp:DropDownList ID="ddlCourse3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse3_SelectedIndexChanged">
          </asp:DropDownList>
         </th>
      <th style="width:270px; border:hidden"> 3</th>
    </tr>
     <tr>
        <th style="width:270px; border:hidden" >
            <asp:TextBox ID="txtDateCourse4" runat="server"></asp:TextBox>
         </th>
      <th style="width:270px; border:hidden" >
          <asp:Label ID="labTeacher4" runat="server"></asp:Label>
         </th>
      <th style="width:270px; border:hidden" >
          <asp:TextBox ID="txtCourseNum4" runat="server" OnTextChanged="txtCourseNum4_TextChanged" AutoPostBack="true"></asp:TextBox>
         </th>
      <th style="width:270px; border:hidden" >
          <asp:DropDownList ID="ddlCourse4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse4_SelectedIndexChanged">
          </asp:DropDownList>
         </th>
      <th style="width:270px; border:hidden"> 4</th>
    </tr>
     
  </tbody>
</table>

  
<br/>
     <div dir="rtl">
     
     <a style="font-size: 25px; text-align: right;float:right; padding-right: 20px;">وذلك للاسباب التاليه</a>
     <br>
     &nbsp;<asp:TextBox ID="txtReason" runat="server" Height="48px" Width="903px" align="right"></asp:TextBox>
     <br>
     <a style="font-size: 25px; text-align: right;float:right; padding-right: 20px;">مرفقات</a>
     <br>
     &nbsp;<br>
          <asp:FileUpload ID="fuDetiels1" runat="server" />
          <br />
          <br />
          <asp:FileUpload ID="fuDetiels2" runat="server" />
          <br />
          <br />
     <br>
     <table width="90%"  border="1"  class="table5" align="center"  >
  <tbody style="float:center;">
   
 <tr  style="font-size:18px; height:40px;  background-color:#F0F0F0;">
      
      <td style="width:270px ">&nbsp;التاريخ<asp:Label ID="labDate" runat="server" Text="Label"></asp:Label>
      </td>
      <td style="width:270px"> توقيع الطالب<asp:FileUpload ID="fuSignatureStudent" runat="server" />
      </td>
    </tr>
  
  
  </tbody>
</table>
      &nbsp;<br>
     &nbsp;<br>
         <div align="center">
          <asp:Button ID="Button1" runat="server" OnClick="btnSave_Click" Text="حفظ" class="btn btn-primary" align="center" />
             </div>
<br/>


                             </div>
                    </div>


                        <br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/><br/>



            
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="js/jquery-2.1.1.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/plugins/metisMenu/jquery.metisMenu.js"></script>
    <script src="js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

    <!-- Custom and plugin javascript -->
    <script src="js/inspinia.js"></script>
    <script src="js/plugins/pace/pace.min.js"></script>

    <!-- iCheck -->
    <script src="js/plugins/iCheck/icheck.min.js"></script>
    <script>
        $(document).ready(function () {
            $('.i-checks').iCheck({
                checkboxClass: 'icheckbox_square-green',
                radioClass: 'iradio_square-green',
            });
        });
    </script>








</asp:Content>
