using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_App.Models
{
    public class Contact
    {
        public required int ContactId { get; set; }
        public required String Name { get; set; }
        public required String Email { get; set; }
        public required String Phone { get; set; }

        public required String Address { get; set; }


    }
}
