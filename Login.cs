using FIles_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIles_practice
{

    internal class Login
    {
        public string NAME { get; set; }
        public int Password { get; set; }


        //creating filestrem and StreamReader
        //FileStream fs;
        StreamReader sr;


        //creating a filestrewam for opening 
        FileStream fs = new FileStream(@"C:\Users\SANKIRAN\source\repos\dotNet_Day9\FIles_practice\bin\Debug\net6.0\Login.txt",
                FileMode.OpenOrCreate,
                FileAccess.Read,
                FileShare.None);
        //creating a streamReader for reading
        


        public void Check()

        {
            if (ValidateDetails(NAME,Password))
            {
                Console.WriteLine("Login Successful!");  
            }
            else { Console.WriteLine("Login Failed"); }

         }

        //function definittion of ValidateDetails
        bool ValidateDetails(string username, int password)

        {

            sr = new StreamReader(fs);   //we call and create reader object only when needed

            string line;  //--WE HAVE TO STORE THE READ DATA INTO  VARIABLE FIRST

            bool result = true;

            while ((line=sr.ReadLine()) != null)

            {

                string[] arr = line.Split(';');

                if (arr[0].Equals(username) && arr[1].Equals(password))
                {

                    result = true;

                    break;

                }

                else

                {

                    result = false;

                }

            }
            sr.Close();
            fs.Close();

            return result;  // to avoid mulitple prints we did return at last
            
        }

    }


}


