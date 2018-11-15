<%@ Page Title="" Language="C#" MasterPageFile="~/PageStudents/student.Master" AutoEventWireup="true" CodeBehind="AddSign.aspx.cs" Inherits="WebApplication1.AddSign" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2 align="center">انشاء او تجديد توقيعك الخاص  </h2>

        </div>
        <div class="col-lg-2">
        </div>
    </div>
     <div class="wrapper wrapper-content animated fadeInRight">


        <div class="row">
            <div class="col-lg-12">
                <div class="ibox float-e-margins">
                    <div class="ibox-content">
                        <table border="0" align="center">
                            <tr>
                                <td align="center"> 
                                      <asp:Button ID="Button1" runat="server" OnClick="btnSave_Click" Text="انشاء توقيع " class="btn btn-primary" align="center" />
                                    </td>

                                </tr>

                            </table>

                    </div>
                
                </div>
            </div>
         </div>



</div>


</asp:Content>
