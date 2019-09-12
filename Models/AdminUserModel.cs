using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intelligent_Retail2.Models
{
    public class AdminUser
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="必须填写用户名")]
        public string AdminUserName { get; set; }
        [MinLength(8,ErrorMessage ="密码至少满足8位")]
        public string AdminPassword { get; set; }
        [Required(ErrorMessage ="必须填写编号")]
        public string AdminUserNumber { get; set; }
        [Required(ErrorMessage ="必须填写手机号")]
        public string AdminUserPhone { get; set; }
        [Required(ErrorMessage ="必须填写邮箱")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "邮件格式不正确")]
        public string AdminUserEmail { get; set; }
        public string AdminUserRole { get; set; }
    }
}
