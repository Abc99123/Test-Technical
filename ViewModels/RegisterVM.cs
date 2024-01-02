using System.ComponentModel.DataAnnotations;

namespace CustomIdentity.ViewModels
{
    public class RegisterVM
    {
        public string? Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public int? PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public string? UploadFoto { get; set; }

    }
}
