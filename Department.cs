using Azure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzas1220
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Lecture> Lectures { get; set; }
        public List<Student> Students { get; set; }
       
     

        public Department() { }

        public Department(string name, string description) 
        
        {
            Name = name;
            Description = description;
            Lectures = new List<Lecture>();
            Students = new List<Student>();
        }
/*        public Department(Guid id)
        {
            Id = id;
        }*/

    }
}
