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
    public partial class AltSubject : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ID = Convert.ToInt32(Session["ID"].ToString());
                fillDataForm(ID);
                fillddl();
            }

        }
        private void fillddl()
        {
            RegistredCourses obj1 = new RegistredCourses();
            int ID = Convert.ToInt32(Session["ID"].ToString());
            DataTable tb1 = obj1.dtSearchNotRegisterSubject(ID);

            Subjects obj2 = new Subjects();
            DataTable tb2 = obj2.dtSearchStudentSubjectNotRegester(ID);

            ddlAlternativeCourse1.DataSource = tb2;
            ddlAlternativeCourse1.DataTextField = "SubjectName";
            ddlAlternativeCourse1.DataValueField = "SubjectID";
            ddlAlternativeCourse1.DataBind();


            ddlCourse1.DataSource = tb1;
            ddlCourse1.DataTextField = "SubjectName";
            ddlCourse1.DataValueField = "SubjectID";
            ddlCourse1.DataBind();

            ddlCourse1.Items.Insert(0, new ListItem("<اختر مادة>", "0"));
            ddlAlternativeCourse1.Items.Insert(0, new ListItem("<اختر مادة>", "0"));
        }

        private void fillDataForm(int ID)
        {
            Studnets objStu = new Studnets();
            DataRow Stu = objStu.drSearchStudent(ID);
            if (Stu != null)
            {
                labCollage.Text = Stu["CollageName"].ToString();
                labNameStudent.Text = Stu["StudentName"].ToString();
                labNumStudent.Text = Stu["UniversityID"].ToString();
                labSection.Text = Stu["SectionName"].ToString();
                labMager.Text = Stu["Mager"].ToString();
            }
            labDate.Text = DateTime.Today.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            bool Result=false;
            //Define Avariable 
            int CourseNum1 = 0;
            int AlternativeCourseNum1 = 0;
            String TypeCouseNum1 = "";
            String Reason = "";
          
            int ID = Convert.ToInt32(Session["ID"].ToString());

            string Path = "C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/Test/";
            string Data= txtNumberCourse1.Text.ToString()+ txtAlternativeNum1C1.Text.ToString()+ txtReason.Text.ToString()+
            labHoursCourse1.Text.ToString() + labHoursAlternative.Text.ToString();
            if (fuSignature.HasFile)
            {
                string Private = fuSignature.FileName.ToString();
                Path = Path + Private;
                fuSignature.SaveAs(Server.MapPath("Test") + "/" + fuSignature.FileName);
                //  Path = "/Test/" + fuSignatureStudent.FileName;
                SignatureStudents newSig = new SignatureStudents();
                string strencrypt = newSig.encrypet(Data,Path,ID);
                Result = newSig.Decreypt(strencrypt,ID);

            }

            if (Result == true)
            {
                //Check input Data
                if (txtNumberCourse1.Text != String.Empty)
                    CourseNum1 = Convert.ToInt32(txtNumberCourse1.Text.ToString());

                if (txtAlternativeNum1C1.Text != String.Empty)
                    AlternativeCourseNum1 = Convert.ToInt32(txtAlternativeNum1C1.Text.ToString());
                if (labTypeCourse1.Text != String.Empty)
                    TypeCouseNum1 = labTypeCourse1.Text.ToString();

                if (txtReason.Text != String.Empty)
                    Reason = txtReason.Text.ToString();
                AlternativeSub obj = new AlternativeSub();
                if (obj.AddAlternativeSubject(ID, CourseNum1, TypeCouseNum1, AlternativeCourseNum1, Reason, 0, 0, 0, 0, 3) == 1)
                {
                    ddlCourse1.SelectedIndex = -1;
                    ddlAlternativeCourse1.SelectedIndex = -1;
                    txtReason.Text = "";
                    ddlAlternativeCourse1.SelectedIndex = -1;
                    txtAlternativeNum1C1.Text = "";
                    txtNumberCourse1.Text = "";
                    labTypeCourse1.Text = "";
                    labHoursCourse1.Text = "";
                    labHoursAlternative.Text = "";


                }
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Text = "التوقيع المدخل خاطئ";
                errorLabel.Visible = true;
            }

        }



        protected void ddlCourse1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCourse1.SelectedIndex != 0 && ddlCourse1.SelectedIndex != -1)
            {
                txtNumberCourse1.Text = ddlCourse1.SelectedValue.ToString();
               
            }
            Subjects obj = new Subjects();
            int SubjectID = Convert.ToInt32(txtNumberCourse1.Text.ToString());
             DataRow dr = obj.drSearchStudentSubjectTypAndHours(SubjectID);
              if (dr != null)
                 {
                      labTypeCourse1.Text = dr["Type"].ToString();
                      labHoursCourse1.Text = dr["Hours"].ToString();
                   }
        }

        protected void ddlAlternativeCourse1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAlternativeCourse1.SelectedIndex != 0 && ddlAlternativeCourse1.SelectedIndex != -1)
            {
                txtAlternativeNum1C1.Text = ddlAlternativeCourse1.SelectedValue.ToString();
            }
            Subjects obj = new Subjects();
            int SubjectID = Convert.ToInt32(txtAlternativeNum1C1.Text.ToString());
            DataRow dr = obj.drSearchStudentSubjectTypAndHours(SubjectID);
            if (dr != null)
            {
                labHoursAlternative.Text = dr["Hours"].ToString();
            }


        }

        protected void txtNumberCourse1_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberCourse1.Text != string.Empty)
            {
                ddlCourse1.SelectedValue = txtNumberCourse1.Text;
                
            }
            else
                ddlCourse1.SelectedIndex = -1;

       
        }

        protected void txtAlternativeNum1C1_TextChanged(object sender, EventArgs e)
        {
            if (txtAlternativeNum1C1.Text != string.Empty)
                ddlAlternativeCourse1.SelectedValue = txtAlternativeNum1C1.Text;
            else
                ddlAlternativeCourse1.SelectedIndex = -1;
        }


    
}
}