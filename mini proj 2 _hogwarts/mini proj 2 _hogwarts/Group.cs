using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_proj_2__hogwarts
{
    internal class Group
    {
        public enum Type
        {
            Hufflepuff, Gryffindor, Ravenclaw, Slytherin
        }
        public int Score { get; set; }
        public List<Student> GropMember { get; set; } // danesh Amooza bayad ozve in grooh bashan?
        public List<Student> QuidditchGameMember { get; set; } // danesh Amooza bayad ozve in grooh bashan?

    }
}
