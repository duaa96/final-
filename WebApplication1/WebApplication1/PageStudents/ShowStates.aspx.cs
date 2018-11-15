using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.PageStudents;

namespace WebApplication1
{
    public partial class ShowStates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                int ID = Convert.ToInt32(Session["ID"].ToString());
                filldata(ID);
            }

        }

        private void filldata(int ID)
        {
            Studnets objStu = new Studnets();
            DataRow Stu = objStu.drSearchStudent(ID);
            if (Stu != null)
            {
                labCollage.Text = Stu["CollageName"].ToString();
                labStudentName.Text = Stu["StudentName"].ToString();
                labStudentNumber.Text = Stu["UniversityID"].ToString();
                labSection.Text = Stu["SectionName"].ToString();
                labMager.Text = Stu["Mager"].ToString();
            }
            labDate.Text = DateTime.Today.ToString();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            bool Result = false;
            int ID = Convert.ToInt32(Session["ID"]);
            string Path = "C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/Test/";
            string Data = labDate.Text.ToString()+ labStudentNumber.Text.ToString();
            if (fuSignatureStudent.HasFile)
            {
                string Private = fuSignatureStudent.FileName.ToString();
                Path = Path + Private;
                fuSignatureStudent.SaveAs(Server.MapPath("Test") + "/" + fuSignatureStudent.FileName);
                //  Path = "/Test/" + fuSignatureStudent.FileName;
                SignatureStudents newSig = new SignatureStudents();
                string strencrypt = newSig.encrypet(Data, Path, ID);
                Result = newSig.Decreypt(strencrypt, ID);

            }

            if (Result == true) { 
            string Reason = "";
            if (txtStatus.Text != string.Empty)
                Reason = txtStatus.Text.ToString();
            ShowStatusClass obj = new ShowStatusClass();
            string Datenow = labDate.Text.ToString();
           if( obj.AddShowStatus(ID, "", "", Datenow, Reason, "", 0, "", "", 0, "", 4)==1)
            {
                txtStatus.Text = "";
            }
                errorLabel.Visible = false;

            }
            else
            {
                errorLabel.Text = "التوقيع المدخل خاطئ";
                errorLabel.Visible = true;
            }

        }
    }
}