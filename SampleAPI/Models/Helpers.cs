using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAPI.Helpers
{
    public class Helpers
    {
    }

    public class RegisterHelpers
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }

    public class UserPages
    {
        public string username { get; set; }
        public bool page1 { get; set; }
        public bool page2 { get; set; }
        public bool page3 { get; set; }
    }
}
