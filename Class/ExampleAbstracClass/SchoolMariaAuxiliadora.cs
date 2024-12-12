using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleAbstracClass
{
    public sealed class SchoolMariaAuxiliadora : School
    {
        public override string? TeacherName { get ; set ; }
        public override string? TeacherProfession { get ; set ; }

        private readonly DataTable oTableSchool = new();
      
        public SchoolMariaAuxiliadora()
        {
            oTableSchool.Columns.Add("SchoolName", typeof(string));
            oTableSchool.Columns.Add("TeacherProfession", typeof(string));
        }

        public SchoolMariaAuxiliadora
            (string? TeacherName,string TeacherProfession)
        {   

            this.TeacherName = TeacherName ;
            this.TeacherProfession = TeacherProfession ;
     
        }

      
        public  override void AddSchool(string SchoolName) {

            try
            {
                oTableSchool.Rows.Add(SchoolName);
                Console.WriteLine("Was Added Correctly");
            }
            catch (Exception oException)
            {
                Console.WriteLine(oException.Message);
            }
            
        }

      
        public override void DeleteSchool(string ? SchoolName = "name ?") {

            if (!string.IsNullOrEmpty(SchoolName))
            {
                if (oTableSchool.Rows.Count > 0)
                {
                    for (int i = 0; i < oTableSchool.Rows.Count; i++)
                    {
                        DataRow oRowSchool = oTableSchool.Rows[i];
                        if (oRowSchool["TeacherName"].ToString() == SchoolName)
                        {
                            oRowSchool.Delete();
                            Console.WriteLine("Row deleted Correctly");
                            break;
                        }
                        Console.WriteLine("No se econtro el nombre de la escuela");
                        break ;
                    }
                }
            }
          
        }
        public override void QuerySchool(string ? pTeacherName = "name ?") {

          
            foreach (DataRow oRowSchool in oTableSchool.Rows)
            {
                if (pTeacherName != null)
                {
                    string? TeacherName = oRowSchool["TeacherName"].ToString();
                    string? TeacherProfession = oRowSchool["TeacherProfession"].ToString();

                    if (TeacherName == pTeacherName)
                    {
                        Console.WriteLine($"Teacher Name : {TeacherName}");
                        Console.WriteLine($"Teacher Profession : {TeacherProfession}");

                    }
                }
                            
            }
        }

        public void Show()
        {
            foreach (DataRow oRowSchool in oTableSchool.Rows)
            {
                string? TeacherName = oRowSchool["TeacherName"].ToString();
                string? TeacherProfession = oRowSchool["TeacherProfession"].ToString();
                 
                Console.WriteLine($"Teacher Name : {TeacherName}");
                Console.WriteLine($"Teacher Profession : {TeacherProfession}");
  
            }
        }
        
    }
}
