using System.ComponentModel.DataAnnotations;
namespace Zadanie3.Pages.Models    
{
    public class Forms
    {
        [Display(Name = "Podaj wiek")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}."), Required(ErrorMessage = "Pole jest obowiązkowe")]
        public int yearOfBirth { get; set; }
        [ScaffoldColumn(true)]
        [StringLength(100, ErrorMessage = "Imię użytkownika. Ograniczenie do 100 liter. ")]
        public string? name { get; set; }
        

        public (string message, string method) getOutput()
        {
            int outint = yearOfBirth;
            string outMessage = "";
            string outMethod = "";
            if (outint % 4  == 0 && outint % 100 == 0)
            {
                outMessage = name + " urodził/a się w " + yearOfBirth + ". Jest to rok przestępny";
                outMethod = "success";
            }
            else
            {
                outMessage = name + " nie urodził/a się w " + yearOfBirth + ". Jest to rok przestępny";
                outMethod = "warning";
            }
            return (outMessage, outMethod);
        }
    }
}
