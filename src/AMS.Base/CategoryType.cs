using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AMS.Base
{
    /// <summary>
    /// aaa
    /// </summary>
    public enum CategoryType
    {
        [Display(Name = "常规栏目")]
        General,
        [Display(Name = "单页栏目")]
        Page,
        [Display(Name = "链接栏目")]
        Link
    }
}
