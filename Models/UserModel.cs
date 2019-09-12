using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class UserModel
    {
        
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }    
        public string UserNumber { get; set; }  
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }


    }
}
