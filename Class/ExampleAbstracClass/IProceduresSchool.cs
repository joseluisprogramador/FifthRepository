using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleAbstracClass
{
    public interface IProceduresSchool
    {
        public abstract void AddSchool(string SchoolName);
        public abstract void DeleteSchool(string StudenName);
        public abstract void QuerySchool(string StudentName);
    }
}
