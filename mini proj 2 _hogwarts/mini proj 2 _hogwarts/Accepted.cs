using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_proj_2__hogwarts
{
    internal class Accepted : Human
    {
        public int RoomNum { get; set; }
        // public List<> Curriculum { get; set; }  kelas dars ezafeh she
        public enum Pet
        {
            l, cat, rat
        }
        //public  Group { get; set; } kelas gorooh besaz
        public bool Baggage { get; set; }
        public enum Role
        {
            teacher, student
        }
        public List<string> Letter { get; set; }
    }
}
