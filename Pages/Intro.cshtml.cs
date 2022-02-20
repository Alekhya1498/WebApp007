using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp007.Models;

namespace WebApp007.Pages
{
    public class IntroModel : PageModel
    {

        public string Output { get; set; }
        public void OnGet()
        {
        }
        public void OnPostSubmit(Numbermodel numbers)
        {
            if (numbers.FirstNumber != null && numbers.SecondNumber != null)
            {
                this.Output = string.Format("First number: {0} \n Second number: {1}", numbers.FirstNumber, numbers.SecondNumber);
            }
            else
            {
                this.Output = string.Empty;
            }
        }
    }
}
