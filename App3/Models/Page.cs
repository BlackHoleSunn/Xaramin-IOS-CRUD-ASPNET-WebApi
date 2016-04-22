using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Page
    {

        public int? Next { get; set; }

        public IEnumerable<Users> Items { get; set; }
    }
}
