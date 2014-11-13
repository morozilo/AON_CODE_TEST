using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AON_coding_test.Models
{
 
    /// <summary>
    /// this class represents Model for this project
    /// </summary>
    public class StringModel : IValidatableObject
    {
     
        /// <summary>
        /// Input String property
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string InputString {  set; get;}
 
        /// <summary>
        /// Start Index property
        /// </summary>
        [Required]
        [Range(1, 99,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int StartIndex {  set; get; }

     
        /// <summary>
        /// End Index property
        /// </summary>
        [Required]
        [Range(2, 100,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int EndIndex {set; get;  }

        /// <summary>
        /// this  property is used to validate values for three other properties 
        /// created for the purpose to automate unit testing of the Model
        /// since data annotation validation is not cought duriuit testing
        /// </summary>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           
            if (String.IsNullOrEmpty(InputString))
            {

                yield return new ValidationResult("Input string is empty", new[] { "InputString" });

            }

            if (!String.IsNullOrEmpty(InputString) && (StartIndex > EndIndex)) 
            {
                yield return new ValidationResult("Invalid start position value", new[] { "StartIndex" });

            }

            if (!String.IsNullOrEmpty(InputString)  && (StartIndex > InputString.Length))
            {
                yield return new ValidationResult("Invalid start position value", new[] { "StartIndex" });

            }


            if (!String.IsNullOrEmpty(InputString) && EndIndex > InputString.Length)
            {
                yield return new ValidationResult("Invalid end position value", new[] { "EndIndex" });

            }
           
            
        }
    }
}