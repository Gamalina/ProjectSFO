using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectSFOLibrary.Model;

namespace ProjectSFO.Pages.Shared
{
    public class SuccesesModel : PageModel
    {
        public string? PageTitle { get; set; }
        public SolutionData? SolutionData { get; set; }


        public void OnGet()
        {
            SolutionData = new SolutionData
            {
                BECSolutions = new string[] { "CUBIA", "Kronos2", "Bi2Cloud", "I*Net", "DevOps", "DAR", "Swift(BEC)", "Swift(DN)", "EFP", "Calpyso", "AML", "Proscan" },
                BankDataSolutions = new string[] { "Swift(BD)", "Murex", "Geneva", "Ringkjøbing" },
                SDCSolutions = new string[] { "Corebank", "Swift(SDC)" },
                NykreditSolutions = new string [] { "MitHjem", "Elbilen", "Sparinvest", "Dataplatform" },
                JyskebankSolutions = new string[] { "Linux Monitor", "JB Omada" },
                SilkeborgSolutions = new string[] { "Microfocus"},
            };

            PageTitle = "Succeses";
        }
    }
}
