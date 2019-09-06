using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ski_Report.Models
{
    public class SubscribeModel
    {

    [Required]
    public string Email { get; set; }
    }
}
