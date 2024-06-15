using System.ComponentModel.DataAnnotations;

namespace mywebsite.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این فیلد اجباری است")]
        [MinLength(4 , ErrorMessage ="حداقل طول نام کاربری باید 4 کاراکتر باشد!")]
        [MaxLength(10 , ErrorMessage ="حداکثر طول نام کاربری 10 کاراکتر است!")]
        public string username { get; set; }
        [EmailAddress(ErrorMessage ="ایمیل وارد شده معتبر نیست")]
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string email { get; set; }
        public string category { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(5, ErrorMessage = "حداقل طول پیام باید 5 کاراکتر باشد!")]
        [MaxLength(60, ErrorMessage = "حداکثر طول پیام 60 کاراکتر است!")]
        public string message { get; set; }
    }
}
