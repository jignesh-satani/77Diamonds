using System.ComponentModel.DataAnnotations;

namespace _77Diamonds.ViewModel
{
    public struct Enum
    {
        public enum UserType
        {
            [Display(Name = "Admin")]
            Admin = 0,
            [Display(Name = "Customer")]
            Customer = 1
        }
    }
}
