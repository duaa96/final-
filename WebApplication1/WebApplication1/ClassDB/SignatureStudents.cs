using DidiSoft.Pgp;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication1.PageStudents
{
    public class SignatureStudents
    {


        public String encrypet(string InputText, string path,int ID)
        {
            String plainString = InputText;

            // create an instance of the library
            PGPLib pgp = new PGPLib();
            Studnets loginStudent = new Studnets();
            DataRow loginS = loginStudent.drSearchStudentEmail(ID);
            string password = null;
            if (loginS != null)
            {
                password = loginS["Password"].ToString();

            }
            String signedString = "";
            try
            {
                signedString = pgp.SignString(plainString,
                                                     new FileInfo(path),
                                                    password);
            }
            catch
            {
                return "false";
            }
            return signedString;
        }

        public Boolean Decreypt(string encrypt,int ID)
        {
            //Get Public File
            GetKey objKey = new GetKey();
            DataRow drKey = objKey.drSearchStudentKey(ID);
            string PublicKey1 = drKey[0].ToString();

            // obtain an OpenPGP signed message
            String signedString = encrypt;

            // Extract the message and check the validity of the signature
            String plainText;

            // create an instance of the library
            PGPLib pgp = new PGPLib();
            SignatureCheckResult signatureCheck;
            try
            {
                 signatureCheck = pgp.VerifyString(signedString,
                                                  new FileInfo(PublicKey1), out plainText);
            }
            catch
            {
                return false;
            }
          


            string strData1 = plainText;
            // Print the results
            Console.WriteLine("Extracted plain text message is " + plainText);
            if (signatureCheck == SignatureCheckResult.SignatureVerified)
            {
                // Console.WriteLine("Signature OK");
                return true;
            }
            else if (signatureCheck == SignatureCheckResult.SignatureBroken)
            {
                //Console.WriteLine("Signature of the message is either broken or forged");
                return false;
            }
            else if (signatureCheck == SignatureCheckResult.PublicKeyNotMatching)
            {
             //   Console.WriteLine("The provided public key doesn't match the signature");
                return false;
            }
            else if (signatureCheck == SignatureCheckResult.NoSignatureFound)
            {
              //  Console.WriteLine("This message is not digitally signed");
                return false;
            }
            return false;
        }
    }
}