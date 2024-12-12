using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleClass
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Names { get; set; }
        public string? LastName { get; set; }
        public byte CurrentAge { get; set; }
        public string? CivilStatus { get; set; }
        public string? Profession { get; set; }
        public int CurrentSalary { get; set; }
        public long Phone { get; set; }
        public string? Email { get; set; }
        public void Disabilty(bool disability, string disabilityName = "None")
        {
            string Information =
                disability ? $"The disability has people is : {disabilityName}" : disabilityName;
            Console.WriteLine(Information);

        }

        protected string ProductInformation(string Post)
        {
 
            bool IsPost =
                 Post == "counter" ||
                 Post == "financier" ||
                 Post == "pathner" ||
                 Post == "boss" ? true : false;

            if (IsPost)
            {
                Console.WriteLine($"Welcome : {Post}");
                (string Report, int Amount,int Price, DateTime Date, int TotalSales) Sales = ("Ventas", 35, 1200, DateTime.Now,42000);
                return $"Total Sales Register : {Sales.TotalSales}";
            }
            else
            {
                return "Only authorized personnel can access";
            }

        }

        public string Information(string Post)
        {
            return ProductInformation(Post);
        }

    }
}
