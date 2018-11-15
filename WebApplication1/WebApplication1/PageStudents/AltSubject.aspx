<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/PageStudents/student.Master" CodeBehind="AltSubject.aspx.cs" Inherits="WebApplication1.AltSubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class=" w3-cell-row ">
        <div class="w3-white w3-center navbar navbar-expand-lg w3-margin-top w3-margin-bottom w3-padding-24" style=" float: none;
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
            <h2 style="float: none;
    margin: 0 auto; font-family:'Amiri'">نموذج مساق بديل للتخرج   </h2><br />
            

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
          <asp:Label ID="labNumStudent" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>
      
    
     </div>  
          <div class="col-1">

          </div>
           <div class="form-group float-right col-5" style="direction:rtl; " >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large">اسم الطالب</label>
          <asp:Label ID="labNameStudent" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>

      
     </div>  
           <div class="col-1">

          </div>
      </div>
   
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:3%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">القسم</label>
          <asp:Label ID="labSection" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>
      
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
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:3%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">التخصص</label>
          <asp:Label ID="labMager" runat="server" CssClass="form-control" Text="Label" style="float:right; font-family:'Amiri';"></asp:Label>
      
     </div>  
          <div class="col-1">

          </div>
           <div class="form-group float-right col-5" style="direction:rtl; " >
      
     </div>  
           <div class="col-1">

          </div>
      </div>
   
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >

      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">معلومات المساق الأصيل:</label>
      
       
      </div>
    </div>

    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right  w3-responsive" style="direction:rtl; margin-right:3%;" >
 <table class=" w3-responsive float-right w3-table w3-striped w3-border" style="direction:rtl;float:right;   font-family:'Amiri';">
    <tr class="bg-primary  w3-center w3-margin" style="font-size:x-large;">
      <th class="w3-center">الرقم</th>
       
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;"> اسم المساق الأصيل</th>
        
      <th  class="w3-center"  style=" float: none; 
    margin: 0 auto;">رقم المساق الأصيل</th>
        
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;">نوع المساق الأصيل</th>
      
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;">الساعات المعتمدة للأصيل</th>
    </tr>
    <tr style="font-size:large;">

      <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"  ControlToValidate="txtNumberCourse1"
  ForeColor="Red"></asp:RequiredFieldValidator>1- </td>
      <td><span>
          <asp:DropDownList ID="ddlCourse1" runat="server" CssClass="form-control  w3-margin-right " width="200px"  OnSelectedIndexChanged="ddlCourse1_SelectedIndexChanged" AutoPostBack="true">
          </asp:DropDownList>
         </span></td>
      <td>
          <asp:TextBox ID="txtNumberCourse1" runat="server" CssClass="form-control  w3-margin-right " width="200px"  OnTextChanged="txtNumberCourse1_TextChanged" AutoPostBack="true"></asp:TextBox>
        <td>  
            <asp:Label ID="labTypeCourse1"  CssClass="form-control w3-margin-right " width="200px" runat="server"  Height="35px" Text=""></asp:Label>
      <td>
          <asp:Label ID="labHoursCourse1" CssClass="form-control w3-margin-right " width="200px" runat="server" Height="35px" Text=""></asp:Label>
      </td>
    </tr>

  </table>
       
      </div>


    </div>

    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >

      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">معلومات المساق البديل:</label>
      
       
      </div>
    </div>


    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right  w3-responsive" style="direction:rtl; margin-right:3%;" >
 <table class=" w3-responsive float-right w3-table w3-striped w3-border" style="direction:rtl;float:right;   font-family:'Amiri';">
    <tr class="bg-primary  w3-center w3-margin" style="font-size:x-large;">
      <th class="w3-center">الرقم</th>
       
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;">اسم المساق البديل</th>
        
      <th  class="w3-center"  style=" float: none; 
    margin: 0 auto;">رقم المساق البديل</th>
      
      <th  class="w3-center" style=" float: none; 
    margin: 0 auto;">الساعات المعتمدة للبديل</th>
    </tr>
    <tr style="font-size:large;">

      <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"  ControlToValidate="txtAlternativeNum1C1"
  ForeColor="Red"></asp:RequiredFieldValidator>1- </td>
      <td><span>

          <asp:DropDownList ID="ddlAlternativeCourse1" runat="server"  CssClass="form-control  w3-margin-right " width="250px"  OnSelectedIndexChanged="ddlAlternativeCourse1_SelectedIndexChanged" AutoPostBack="true">
          </asp:DropDownList>

          
         </span></td>
      <td>
          <asp:TextBox ID="txtAlternativeNum1C1" runat="server"  CssClass="form-control  w3-margin-right " width="250px" OnTextChanged="txtAlternativeNum1C1_TextChanged" AutoPostBack="true" ></asp:TextBox>
        <td>  
            
                <asp:Label ID="labHoursAlternative" runat="server" CssClass="form-control w3-margin-right " width="250px" Hight="35px"></asp:Label>
     
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
      <div class="form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">التاريخ: </label>
      <asp:Label ID="labDate" runat="server" CssClass="w3-margin-right" Text="Label" style="float:right;   font-family:'Amiri'; font-size:x-large;"></asp:Label>
      
     </div>  
          <div class="col-1">

          </div>
           <div class="form-group float-right col-5" style="direction:rtl; " >
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">التوقيع:</label>
         <asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="RequiredFieldValidator3" ControlToValidate="fuSignature" ErrorMessage="*"></asp:RequiredFieldValidator>

      <asp:FileUpload ID="fuSignature" runat="server" />
       
          <asp:Label ID="errorLabel" runat="server" style="float:right;  font-family:'Amiri'; font-size:large;" Visible="False" ForeColor="#FF3300"></asp:Label>
      
       
     </div>  
           <div class="col-1">

          </div>
      </div>
    
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-12"   style=" float: none; direction:rtl; 
    margin: 0 auto;">
      
       
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

