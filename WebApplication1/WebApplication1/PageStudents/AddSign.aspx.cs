using DidiSoft.Pgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddSign : System.Web.UI.Page
    {
        // static int ID = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
           int  ID = Convert.ToInt32(Session["ID"].ToString());
           
        }

        public static void CreateSignature(string privateKeyPassword, string userId, int ID)
        {
            string path = "C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/Sig/key.store";
            KeyStore ks = new KeyStore(@path, "changeit");

            // userId = "rsa_demo@didisoft.com";
            // privateKeyPassword = "private key password";

            HashAlgorithm[] hashing = { HashAlgorithm.SHA1,
                                        HashAlgorithm.MD5,
                                        HashAlgorithm.SHA256,
                                        HashAlgorithm.SHA384,
                                        HashAlgorithm.SHA512};

            CompressionAlgorithm[] compression =
                                    { CompressionAlgorithm.ZIP,
                                      CompressionAlgorithm.ZLIB,
                                      CompressionAlgorithm.UNCOMPRESSED};

            CypherAlgorithm[] cypher = { CypherAlgorithm.CAST5,
                                         CypherAlgorithm.AES_128,
                                         CypherAlgorithm.AES_192,
                                         CypherAlgorithm.AES_256,
                                         CypherAlgorithm.BLOWFISH};

            ks.GenerateKeyPair(2048,
                                userId,
                                KeyAlgorithm.RSA,
                                privateKeyPassword,
                                compression,
                                hashing,
                                cypher);
            ExportDemo(path, userId,ID);
        }

        public static void ExportDemo(string path, string userId, int ID)
        {
            

            // initialize the KeyStore
            KeyStore ks = new KeyStore(@path, "changeit");

            // should the exported files be ASCII or binary
            bool asciiArmored = true;

            // export public key having the specified userId
            // all public sub keys are exported too





















            ks.ExportPublicKey(@"C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/Sig/" + ID+".asc", userId, asciiArmored);

            // export secret key having the specified userId, this is usually our own key
            // all secret sub keys are exported too
            ks.ExportPrivateKey(@"C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/Sig/" + ID+"pr" + ".asc", userId, asciiArmored);

            // export both public and secret key with all sub keys in one file
            // the file is in ASCII armored format by default
            // ks.ExportKeyRing(@"DataFiles\keypair.asc", "support@didisoft.com");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Session["ID"].ToString());
            Studnets loginStudent = new Studnets();
            DataRow loginS = loginStudent.drSearchStudentEmail(ID);
            string password = null;
            string Email = null;
            if (loginS != null)
            {
                 password=loginS["Password"].ToString();
                 Email = loginS["Email"].ToString();
            }
            //string password ="1234";
            //string Email = "duaa.tan @gmail.com";
            CreateSignature(password, Email,ID);
            string PublicKey = "C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/Sig/" + ID+".asc";
            string PrivateKey = "Sig/" + ID+ "pr" + ".asc";
            string PublicKey1 = "Sig/" + ID + ".asc" ;
            GetKey objKey = new GetKey();
            objKey.AddKeyStudent(PublicKey , ID);
            downloadfile(PrivateKey);
            



        }



      public void  downloadfile (string filePath)
        {
            Response.AddHeader("Content-Disposition", "attachment;filename=\"" + filePath + "\"");
            Response.TransmitFile(Server.MapPath(filePath));
           // System.IO.File.Delete("C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/" + filePath);
            Response.Flush();

            System.IO.File.Delete("C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/" + filePath);
            System.IO.File.Delete("C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/PageStudents/Sig/key.store");
            Response.End();
            // var filestream = new System.IO.FileStream(@"C:/Users/Dua'a-Orcas/Desktop/WebApplication1/WebApplication1/WebApplication1/Sig/" + filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
            //  filestream.Close();
            // System.IO.File.Delete(filePath);

        }
    }
}