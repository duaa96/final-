<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/PageStudents/student.Master" CodeBehind="PullCourse.aspx.cs" Inherits="WebApplication1.PullCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class=" w3-cell-row ">
        <div class="w3-white w3-center navbar navbar-expand-lg w3-margin-top w3-margin-bottom w3-padding-24" style=" float: none;
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
            <h2 style="float: none;
    margin: 0 auto; font-family:'Amiri'">نموذج تقديم سحب مساق  </h2><br />
            

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
          <asp:Label ID="labStudentNmuber" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>
      
    
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
      <div class=" w3-row form-group float-right col-12" style="direction:rtl; margin-right:0.5%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">السيد رئيس القسم المحترم ارجو الموافقة على سحب المساق /المساقات المذكورة ادناه:</label>
      
       
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
    margin: 0 auto;">موعدالمساق</th>
    </tr>
    <tr style="font-size:large;">

      <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"  ControlToValidate="txtTimeCourse1"
  ForeColor="Red"></asp:RequiredFieldValidator><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"  ControlToValidate="txtNumCourse1"
  ForeColor="Red"></asp:RequiredFieldValidator>1- </td>
      <td><span>
          
          <asp:DropDownList ID="ddlNameCourse1" runat="server" OnSelectedIndexChanged="ddlNameCourse1_SelectedIndexChanged" CssClass="form-control w3-margin-right w3-margin-left" width="200px" AutoPostBack="true">
          </asp:DropDownList>
          </span></td>
      <td>
          <asp:TextBox ID="txtNumCourse1" runat="server" CssClass="form-control  w3-margin-right " width="200px"  OnTextChanged="txtNumCourse1_TextChanged" AutoPostBack="true"></asp:TextBox>
          
        <td>  <asp:Label ID="labTeacher1"  CssClass="form-control w3-margin-right " width="200px"  Height="35px" runat="server" ></asp:Label></td>
      <td>
        <asp:TextBox ID="txtTimeCourse1"   CssClass="form-control w3-margin-right " width="200px" runat="server">  </asp:TextBox>
      </td>
    </tr>
    <tr  style="font-size:large;">
      <td>2-</td>
      <td>
          <asp:DropDownList ID="ddlNameCourse2" runat="server" CssClass="form-control w3-margin-right" width="200px" OnSelectedIndexChanged="ddlNameCourse2_SelectedIndexChanged" AutoPostBack="true">
          </asp:DropDownList>
          </td>

          <td> 
              <asp:TextBox ID="txtNumCourse2" runat="server" CssClass="form-control w3-margin-right " Rows="2" width="200px" OnTextChanged="txtNumCourse2_TextChanged" AutoPostBack="true"></asp:TextBox>
</td>
        <td>  <asp:Label ID="labTeacher2" CssClass="form-control w3-margin-right " Height="35px" width="200px"   runat="server"></asp:Label></td>
      <td><asp:TextBox ID="txtTimeCourse2"   CssClass="form-control w3-margin-right " width="200px" runat="server">  </asp:TextBox></td>
    </tr>
    <tr  style="font-size:large;">
      <td>3-</td>
      <td>
          

          <asp:DropDownList ID="ddlNameCourse3" runat="server" CssClass="form-control w3-margin-right" width="200px" OnSelectedIndexChanged="ddlNameCourse3_SelectedIndexChanged" AutoPostBack="true">
          </asp:DropDownList>
        </td>
      <td>  
          
          <asp:TextBox ID="txtNumCourse3" runat="server" CssClass="form-control w3-margin-right " Rows="2" width="200px" OnTextChanged="txtNumCourse3_TextChanged" AutoPostBack="true"></asp:TextBox>
</td>
        <td>  <asp:Label ID="labTeacher3" CssClass="form-control w3-margin-right " Height="35px" width="200px"   runat="server"></asp:Label></td>
      <td><asp:TextBox ID="txtTimeCourse3"   CssClass="form-control w3-margin-right " width="200px" runat="server">  </asp:TextBox></td>
    </tr>
       
  </table>
       
      </div>


    </div>

    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >

      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">وذلك للأسباب التالية:<asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="rq4" ControlToValidate="txtReason" ErrorMessage="*"></asp:RequiredFieldValidator>

          </label>&nbsp;</div>
    </div>
  <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right " style="direction:rtl; margin-right:0.5%; margin-left:3%; width:950px;" >
      <asp:TextBox ID="txtReason" runat="server"   CssClass="form-control w3-margin-right col-12 " Height="100px"   align="right"></asp:TextBox>
      
       
      </div>
    </div>
    
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">عدد الساعات المسجلة:<asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="RequiredFieldValidator5" ControlToValidate="txtNmberHours" ErrorMessage="*"></asp:RequiredFieldValidator>
      
          &nbsp;</label><asp:TextBox ID="txtNmberHours" runat="server" CssClass="w3-margin-right form-control" style="float:right;   font-family:'Amiri'; font-size:large;" TextMode="Number"></asp:TextBox>
      
     </div>  
          <div class="col-1">

          </div>
           <div class="form-group float-right col-5" style="direction:rtl; " >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">عدد الساعات بعد السحب:
          <asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="RequiredFieldValidator4" ControlToValidate="txtNumHourAfter" ErrorMessage="*"></asp:RequiredFieldValidator>

               </label>
         
               &nbsp;<asp:TextBox ID="txtNumHourAfter" runat="server" CssClass="w3-margin-right form-control" style="float:right;   font-family:'Amiri'; font-size:large;" TextMode="Number"></asp:TextBox>
       
     </div>  
           <div class="col-1">

          </div>
      </div>
   
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
           <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">التاريخ:</label>
    
      <asp:Label ID="labDate"  style="float:right;  font-family:'Amiri'; font-size:x-large;" runat="server" Text="Label"></asp:Label>
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
          <asp:Button ID="btnSave" runat="server" Text="حفظ" OnClick="btnSave_Click" class="btn btn-lg btn-primary" align="center" />
      
       
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
