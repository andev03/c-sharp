using ModelValidationExample.custom_validator;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.models {
    public class Person {
        [Required]
        public string? PersonName {
            get; set;
        }
        public string? Email {
            get; set;
        }
        public string? Phone {
            get; set;
        }
        public string? Password {
            get; set;
        }
        public string? ConfirmPassword {
            get; set;
        }
        public double Price {
            get; set;
        }

        [MinimumYearValidator]
        public double DateOfBirth {
            get; set;
        }

        public DateTime? FromDate {
            get; set;
        }

        [DateRangeValidator("FromDate", ErrorMessage = "'From Date' should be older than or equal to 'To Date'")]
        public DateTime? ToDate {
            get; set;
        }

        public List<string?> Tags {
            get; set;
        } = new List<string?>();
        public override string? ToString() {
            return $"Person object - Person name: {PersonName}, Email: {Email}, Phone: {Phone}, " +
                $"Confirm Password: {ConfirmPassword}, Price: {Price}";
        }
    }
}
