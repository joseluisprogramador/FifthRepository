using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleAbstracClass
{
    public interface ITeacher
    {
        public abstract string? TeacherName { get; set; }
        public abstract string? TeacherProfession { get; set; }

    }
}
