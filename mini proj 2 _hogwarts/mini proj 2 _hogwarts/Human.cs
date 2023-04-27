using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_proj_2__hogwarts
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Birthday { get; set; }
        public string Sex { get; set; } 
        public string Father { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public enum Race 
        {
            HalfBlood, PureBlood, MuggleBlood
        }
    }
}
