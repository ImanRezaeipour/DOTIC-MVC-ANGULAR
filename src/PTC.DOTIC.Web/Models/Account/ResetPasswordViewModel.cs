using System.ComponentModel.DataAnnotations;
using PTC.DOTIC.Security;

namespace PTC.DOTIC.Web.Models.Account
{
    public class ResetPasswordViewModel
    {
        /// <summary>
        /// Encrypted tenant id.
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Encrypted user id.
        /// </summary>
        [Required]
        public string UserId { get; set; }

        [Required]
        public string ResetCode { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }
    }
}