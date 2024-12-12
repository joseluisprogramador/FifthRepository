using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleAbstracClass
{
    public interface IStudent
    {
        public abstract string? StudentName { get; set; }
        public abstract string? StudentCourse { get; set; }
        
    }
}
