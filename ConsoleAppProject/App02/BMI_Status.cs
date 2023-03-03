using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App02
{
    public enum BMIStatus
    {
        None,
        UnderWeight,
        [Display(Name = "Normal Weight")]
        NormalWeight,
        OverWeight,
        [Display(Name = "Obese Category 2")]
        ObeseII,
        [Display(Name = "Obese Category 3")]
        ObeseIII
    }
}
