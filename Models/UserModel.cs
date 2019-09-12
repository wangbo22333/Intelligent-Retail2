using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class User
    {
        
        public int ID { get; set; }
        public string UserNickName { get; set; }
        //public string PassWord { get; set; }    
        public string UserOpenID { get; set; }  
        public string UserPhone { get; set; }
        public string UserGender { get; set; }
        

    }
}
