using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vue.Models
{
    public class Guestbook
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "請輸入名字")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "請輸入內容")]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
