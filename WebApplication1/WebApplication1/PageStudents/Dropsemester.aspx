<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PageStudents/student.Master" CodeBehind="Dropsemester.aspx.cs" Inherits="WebApplication1.Dropsemester" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class=" w3-cell-row ">
        <div class="w3-white w3-center navbar navbar-expand-lg w3-margin-top w3-margin-bottom w3-padding-24" style=" float: none;
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
            <h2 style="float: none;
    margin: 0 auto; font-family:'Amiri'">نموذج تقديم سحب فصل دراسي  </h2><br />
            

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
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:large;">عدد الساعات المسجلة:<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"  ControlToValidate="txtNumHours"
  ForeColor="Red"></asp:RequiredFieldValidator>
          </label>
          
          &nbsp;<asp:TextBox ID="txtNumHours" runat="server" CssClass="form-control" style="float:right; font-family:'Amiri';" TextMode="Number"></asp:TextBox>
            
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
      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">المساقات التي سجلها الطالب:</label>
      
       
      </div>
    </div>
    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class="form-group float-right row w3-responsive" style="direction:rtl; margin-right:3%;" >
       <asp:GridView ID="gvCourses" class="w3-table w3-striped w3-border w3-center" style="direction:rtl;float:right;   font-family:'Amiri'; text-align:center;" runat="server" AutoGenerateColumns="False" DataKeyNames="SubjectID" width="1000px" CellPadding="4" ForeColor="Black" GridLines="None" Font-Names="Agency FB">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns >
                                        <asp:BoundField  DataField="SubjectName" HeaderText="اسم المساق" SortExpression="SubjectName" />
                                        <asp:BoundField DataField="SubjectID" HeaderText="رقم المساق" SortExpression="SubjectID" />
                                        

                                        <asp:TemplateField ShowHeader="False">
                                            <EditItemTemplate>
                                            </EditItemTemplate>
                                            <ItemStyle Width="24px" />
                                           
                                        </asp:TemplateField>
                                           
                                    </Columns>
                                    <EditRowStyle BackColor="#2461BF" />
                                    <EmptyDataTemplate>
                                        <asp:Label ID="lblNoUser" runat="server" Font-Bold="True" ForeColor="Red">لا يوجد مواد مسجلة للطالب  </asp:Label>
                                    </EmptyDataTemplate>
                                    <FooterStyle BackColor="#1A7BB9" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#1A7BB9" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                </asp:GridView>
      
     </div>  
        </div>
 
  

    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right col-5" style="direction:rtl; margin-right:0.5%;" >

      <label for="exampleInpuStudentsNum"  style="float:right;  font-family:'Amiri'; font-size:x-large;">أرغب بسحب الفصل و ذلك للأسباب التالية:<asp:RequiredFieldValidator runat="server" ForeColor="Red" ID="rq4" ControlToValidate="txtReasons" ErrorMessage="*"></asp:RequiredFieldValidator>

          </label>
      
       
      &nbsp;</div>
    </div>

  <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; ">
      <div class=" w3-row form-group float-right " style="direction:rtl; margin-right:0.5%; margin-left:3%; width:950px;" >
      <asp:TextBox ID="txtReasons" runat="server"   CssClass="form-control w3-margin-right col-12 " Height="100px"   align="right"></asp:TextBox>
      
       
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
      <div class=" w3-row form-group float-right " style="direction:rtl; float: none;
    margin: 0 auto; " >
          <asp:Button ID="btnSend" runat="server" OnClick="Button1_Click" Text="حفظ" class="btn btn-lg btn-primary" align="center" />
      
       
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






