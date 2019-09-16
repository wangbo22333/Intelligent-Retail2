using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class User
    {
        
        public int ID { get; set; }
        [DisplayName("用户昵称")]
        public string UserNickName { get; set; }
        [DisplayName("用户微信ID")]
        public string UserOpenID { get; set; }
        [DisplayName("用户手机号")]
        public string UserPhone { get; set; }
        [DisplayName("用户性别")]
        public string UserGender { get; set; }
        

    }
}
