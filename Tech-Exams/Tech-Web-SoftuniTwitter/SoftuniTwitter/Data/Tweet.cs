using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SoftuniTwitter.Data
{
    public class Tweet
    {
        public int Id { get; set; }
        
        [Range(2,240)]
        public string Text { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }

        public IdentityUser User { get; set; } //прави релация между юзъра на туйта и туйта
    }
}
