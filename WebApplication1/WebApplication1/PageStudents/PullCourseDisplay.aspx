<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PageStudents/student.Master"  CodeBehind="PullCourseDisplay.aspx.cs" Inherits="WebApplication1.PageStudents.PullCourseDisplay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class=" w3-white w3-center navbar navbar-expand-lg  " style=" float: none; direction:rtl; 
    margin: 0 auto; margin-right:7%; margin-left:3%; margin-top:10%; ">
      <div class="form-group float-right row w3-responsive" style="direction:rtl; margin-right:3%; width:100%;" >
               <asp:Label ID="errorLabel" runat="server" style="float:right;  float:none; margin:0 auto;  font-family:'Amiri'; font-size:large;" Visible="False" ForeColor="#FF3300"></asp:Label>
    <asp:GridView ID="gvPullCourse"    style="width:1100px; margin-top" runat="server"   OnRowDeleting="gvPullCoursedelete_RowDeleting" AutoGenerateColumns="False" DataKeyNames="ID" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gvPullCourseView_RowCommand">



        <AlternatingRowStyle BackColor="White" ForeColor="#284775" /> 
        <Columns >
            <asp:BoundField  DataField="ID" HeaderText="رقم الطلب" SortExpression="ID" />
            <asp:BoundField DataField="Date" HeaderText="تاريخ تقديم الطلب" SortExpression="Date" />
            <asp:BoundField DataField="HeadAccept" HeaderText="رئيس القسم" SortExpression="HeadAccept" />
            <asp:BoundField DataField="DeanAccept" HeaderText="العميد" SortExpression="DeanAccept" />
            <asp:BoundField DataField="RegestrationAccept" HeaderText="التسجيل" SortExpression="RegestrationAccept" />
                                        

             <asp:TemplateField ShowHeader="False">
                   <ItemTemplate>
                       <asp:Button ID="btnedit" runat="server" Text="عرض" CommandName="display" CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'/>
                   </ItemTemplate>          
             </asp:TemplateField> 
             <asp:TemplateField ShowHeader="False">
                   <ItemTemplate>
                         <asp:Button ID="btnedit1" runat="server" Text="تعديل" CommandName="edit1" CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'/>
                   </ItemTemplate>          
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                   <ItemTemplate>
                         <asp:Button ID="btnedit2" runat="server" Text="حذف" CommandName="delete" CommandArgument='<%# DataBinder.Eval(Container, "RowIndex") %>'/>
                   </ItemTemplate>          
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                </EditItemTemplate>
                 <ItemStyle Width="24px" />
                                           
            </asp:TemplateField>
            </Columns>
       
        <EditRowStyle BackColor="#999999" />
         <EmptyDataTemplate>
               <asp:Label ID="lblNoUser" runat="server" Font-Bold="True" ForeColor="Red">لا يوجد طلبات مقدمة </asp:Label>
        </EmptyDataTemplate>
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333"  />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </div>
  </div>
    
</asp:Content>