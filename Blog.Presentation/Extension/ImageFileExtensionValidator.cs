using System.ComponentModel.DataAnnotations;

namespace Blog.Presentation.Extension
{
   
        public class ImageFileExtensionValidator : ValidationAttribute
        {
            protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
            {
                IFormFile file = value as IFormFile;
                if (file != null)
                {
                    string[] fileExtensions = { ".jpg", ".jpeg", ".png" };
                    var fileExtension = Path.GetExtension(file.FileName);
                    var result = fileExtensions.Any(x => x.EndsWith(fileExtension));
                    if (!result) { return new ValidationResult("File extension must be .jpg, .jpeg or .png format"); }
                }
                return ValidationResult.Success;
            }
        }
}
