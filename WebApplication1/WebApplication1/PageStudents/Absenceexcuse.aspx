<%@ Page Title="" Language="C#" MasterPageFile="~/PageStudents/student.Master" AutoEventWireup="true" CodeBehind="Absenceexcuse.aspx.cs" Inherits="WebApplication1.Absenceexcuse"  EnableEventValidation="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class=" w3-cell-row ">
        <div class="w3-white w3-center navbar navbar-expand-lg w3-margin-top w3-margin-bottom w3-padding-24" style=" float: none;
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
            <h2 style="float: none;
    margin: 0 auto; font-family:'Amiri'">نموذج تقديم عذر الغياب عن امتحان نهائي  </h2><br />
            

        </div>
        
    </div>

    <div class=" w3-white w3-center navbar navbar-expand-lg  w3-margin-top  w3-padding-24 " style=" float: none;
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
        <div class="w3-cell-row w3-white w3-center navbar navbar-expand-lg  " stle=" float: none;
                                                margin: 0 auto; margin-right:7%; margin-left:3%; ">
            <h2  style="float: none; align-items:center; margin: 0 auto; font-family:'Amiri'">معلومات الطالب </h2>
            
        </div>
       
    </div>
      <div class=" w3-white w3-center navbar navbar-expand-lg   " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%;  padding-bottom:0;">
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:3%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri' ; font-size:large;">الرقم الجامعي</label>
          <asp:Label ID="labNumberStudent" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>
      
    
     </div>  
          <div class="col-1">

          </div>
           <div class="form-group float-right col-5" style="direction:rtl; " >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large">اسم الطالب</label>
          <asp:Label ID="labStudentName" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>

      
     </div>  
           <div class="col-1">

          </div>
      </div>
   
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:3%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">القسم</label>
          <asp:Label ID="labSectionStudent" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>
      
     </div>  
          <div class="col-1">

          </div>
           <div class="form-group float-right col-5" style="direction:rtl; " >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">الكلية</label>
          <asp:Label ID="labCollage" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>
      
     </div>  
           <div class="col-1">

          </div>
      </div>
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:xx-large;">السيد عميد الكلية المحترم:</label>
      
       
      </div>
    </div>
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">لقد تغيبت عن الامتحان النهائي للمساقات المذكورة أدناه:</label>
      
       
      </div>
    </div>

    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right  w3-responsive" style="direction:rtl; margin-right:3%;" >
 <table class=" w3-responsive float-right w3-table w3-striped w3-border" style="direction:rtl;float:right;   font-family:'Amiri';">
    <tr class="bg-primary  w3-center w3-margin" style="font-size:x-large;">
      <th class="w3-center">الرقم</th>
       
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;">اسم المساق</th>
        
      <th  class="w3-center"  style=" float: none; 
    margin: 0 auto;">رقم المساق</th>
        
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;">مدرس المساق</th>
      
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;">موعد الامتحان</th>
    </tr>
    <tr style="font-size:large;">

      <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"  ControlToValidate="txtDateCourse1"
  ForeColor="Red"></asp:RequiredFieldValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"  ControlToValidate="txtCourseNum1"
  ForeColor="Red"></asp:RequiredFieldValidator>1- </td>
      <td><span><asp:DropDownList CssClass="form-control w3-margin-right w3-margin-left" width="200px" ID="ddlCourse1" runat="server" OnSelectedIndexChanged="ddlCourse1_SelectedIndexChanged" AutoPostBack="true" required="true">
          </asp:DropDownList></span></td>
      <td> <asp:TextBox ID="txtCourseNum1"  CssClass="form-control  w3-margin-right " width="200px"  runat="server" OnTextChanged="txtCourseNum1_TextChanged" AutoPostBack="true"></asp:TextBox></td>
        <td>  <asp:Label ID="labTeacher1"  CssClass="form-control w3-margin-right " width="200px"  Height="35px" runat="server" ></asp:Label></td>
      <td>
        <asp:TextBox ID="txtDateCourse1"   CssClass="form-control w3-margin-right " width="200px" runat="server">  </asp:TextBox>
      </td>
    </tr>
    <tr  style="font-size:large;">
      <td>2-</td>
      <td><asp:DropDownList CssClass="form-control w3-margin-right" runat="server" width="200px"  ID="ddlCourse2"  AutoPostBack="true" OnSelectedIndexChanged="ddlCourse2_SelectedIndexChanged">
          </asp:DropDownList></td>

          <td> <asp:TextBox ID="txtCourseNum2" runat="server" CssClass="form-control w3-margin-right " Rows="2" width="200px"  OnTextChanged="txtCourseNum2_TextChanged" AutoPostBack="true"></asp:TextBox>
</td>
        <td>  <asp:Label ID="labTeacher2" CssClass="form-control w3-margin-right " Height="35px" width="200px"   runat="server"></asp:Label></td>
      <td><asp:TextBox ID="txtDateCourse2"   CssClass="form-control w3-margin-right " width="200px" runat="server">  </asp:TextBox></td>
    </tr>
    <tr  style="font-size:large;">
      <td>3-</td>
      <td><asp:DropDownList ID="ddlCourse3" CssClass="form-control w3-margin-right" width="200px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse3_SelectedIndexChanged">
          </asp:DropDownList></td>
      <td>  <asp:TextBox ID="txtCourseNum3" runat="server" CssClass="form-control w3-margin-right " Rows="2" width="200px"  OnTextChanged="txtCourseNum3_TextChanged" AutoPostBack="true" ></asp:TextBox>
</td>
        <td>  <asp:Label ID="labTeacher3" CssClass="form-control w3-margin-right " Height="35px" width="200px"   runat="server"></asp:Label></td>
      <td><asp:TextBox ID="txtDateCourse3"   CssClass="form-control w3-margin-right " width="200px" runat="server">  </asp:TextBox></td>
    </tr>
       <tr  style="font-size:large;">
      <td>4-</td>
      <td>  <asp:DropDownList ID="ddlCourse4"  CssClass="form-control w3-margin-right" width="200px"  runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse4_SelectedIndexChanged">
          </asp:DropDownList></td>
      <td>   <asp:TextBox ID="txtCourseNum4" runat="server"  CssClass="form-control w3-margin-right " Rows="2" width="200px"  OnTextChanged="txtCourseNum4_TextChanged" AutoPostBack="true">
      </asp:TextBox></td>
        <td>  <asp:Label ID="labTeacher4"  CssClass="form-control w3-margin-right " Height="35px" width="200px"  runat="server"></asp:Label></td>
      <td> <asp:TextBox ID="txtDateCourse4"  CssClass="form-control w3-margin-right  " width= "200px" runat="server"></asp:TextBox></td>
    </tr>
  </table>
       
      </div>


    </div>

    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
         <asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="rq4" ControlToValidate="txtReason" ErrorMessage="*"></asp:RequiredFieldValidator>

      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">وذلك للأسباب التالية:</label>
      
       
      </div>
    </div>
  <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right " style="direction:rtl; margin-right:0.5%; margin-left:3%; width:950px;" >
      <asp:TextBox ID="txtReason" runat="server"   CssClass="form-control w3-margin-right col-12 " Height="100px"   align="right"></asp:TextBox>
      
       
      </div>
    </div>
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">المرفقات</label>
      
       
      </div>
    </div>
     <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5 3" style="direction:rtl; margin-right:0.5%;" >
       <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">المرفق الاول</label>
      <asp:FileUpload ID="fuDetiels1"  runat="server" />
      
       
      </div>
    </div>
     <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
       <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">المرفق الثاني </label>
      <asp:FileUpload ID="fuDetiels2" runat="server" />
      
       
      </div>
    </div>
   
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">التاريخ: </label>
      <asp:Label ID="labDate" runat="server" CssClass="w3-margin-right" Text="Label" style="float:right;   font-family:'Amiri'; font-size:x-large;"></asp:Label>
      
     </div>  
          <div class="col-1">

          </div>
           <div class="form-group float-right col-5" style="direction:rtl; " >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">التوقيع:</label>
         <asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="RequiredFieldValidator3" ControlToValidate="fuSignatureStudent" ErrorMessage="*"></asp:RequiredFieldValidator>

      <asp:FileUpload ID="fuSignatureStudent" runat="server" />
       <asp:Label ID="errorLabel" runat="server" style="float:right;  font-family:'Amiri'; font-size:large;" Visible="False" ForeColor="#FF3300"></asp:Label>
     </div>  
           <div class="col-1">

          </div>
      </div>

      <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right " style="direction:rtl; float: none;
    margin: 0 auto; " >
      <asp:Button ID="Button1" runat="server" OnClick="btnSave_Click" Text="حفظ" class="btn btn-lg btn-primary" align="center" />
      
       
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
