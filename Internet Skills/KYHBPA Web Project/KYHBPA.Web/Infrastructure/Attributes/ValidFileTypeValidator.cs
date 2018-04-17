﻿using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYHBPA
{
    public class ValidFileTypeValidator
        : ValidationAttribute, IClientValidatable
    {
        private string _errorMessage = "{0} must be one of the following file types: {1}";

        /// <summary>
        /// Valid file extensions
        /// </summary>
        public string[] ValidFileTypes { get; private set; }

        /// <param name="validFileTypes">Valid file extensions(without the dot)</param>
        public ValidFileTypeValidator(
            params string[] validFileTypes)
        {
            ValidFileTypes = validFileTypes;
        }

        public override bool IsValid(
            object value)
        {
            var file = value as HttpPostedFileBase;

            if (value.IsNull() || string.IsNullOrEmpty(file.FileName))
            {
                return true;
            }

            if (ValidFileTypes != null)
            {
                var fileNameParts = file.FileName.Split('.');
                var validFileTypeFound = ValidFileTypes.Any(validFileType => fileNameParts[fileNameParts.Length - 1] == validFileType);

                if (!validFileTypeFound)
                {
                    ErrorMessage = string.Format(_errorMessage, "{0}", ValidFileTypes.ToConcatenatedString(","));
                    return false;
                }
            }

            return true;
        }

        public override string FormatErrorMessage(
            string name)
        {
            return string.Format(_errorMessage, name, ValidFileTypes.ToConcatenatedString(","));
        }

        public System.Collections.Generic.IEnumerable<ModelClientValidationRule> GetClientValidationRules(
              ModelMetadata metadata
            , ControllerContext context)
        {
            var clientValidationRule = new ModelClientValidationRule()
            {
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
                ValidationType = "validfiletype"
            };

            clientValidationRule.ValidationParameters.Add("filetypes", ValidFileTypes.ToConcatenatedString(","));

            return new[] { clientValidationRule };
        }
    }
}