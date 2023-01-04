using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.Domain.Entities
{
    public class ProfileViews
    {
        [Key]
       public int Id { get; set; }
        public string Name { get; set; }    
        public string Mobile { get; set; }
        public string Location { get; set; }
        public string URL { get; set; }

    }
}
