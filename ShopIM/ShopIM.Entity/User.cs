using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopIM.Entity
{
    [Table("User")]
    public class User
    {
        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
    
        [StringLength(40)]
        public string UserName {get; set;}

        [StringLength(40)]
        public string UserPassword { get; set; }

    }
}
