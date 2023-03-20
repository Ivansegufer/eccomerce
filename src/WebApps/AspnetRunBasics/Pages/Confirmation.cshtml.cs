using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspnetRunBasics
{
    public class ConfirmationModel : PageModel
    {
        public string Message { get; set; }

        public void OnGetContact()
        {
            Message = "Tu email fue enviado correctamente.";
        }

        public void OnGetOrderSubmitted()
        {
            Message = "Tu orden se ha enviado correctamente.";
        }
    }
}