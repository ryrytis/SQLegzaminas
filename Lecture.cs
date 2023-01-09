using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzas1220
{
    public class Lecture
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Department> Departments { get; set; }


        public Lecture()
        {
        }

        public Lecture(string code, string name)
        {
            Id = Guid.NewGuid();
            Code = code;
            Name = name;
            Departments = new List<Department>();

        }
    }
}
