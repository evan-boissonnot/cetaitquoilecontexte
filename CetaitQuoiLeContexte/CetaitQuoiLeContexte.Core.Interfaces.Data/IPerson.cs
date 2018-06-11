using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Interfaces.Data
{
    public interface IPerson : Boissonnot.Framework.Core.Interfaces.Data.IParentModel
    {
        /// <summary>
        /// Prénom de la personne
        /// </summary>
        [Display(Name = "Pseudo")]
        [Required]
        string Name { get; set; }

        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        [Display(Name = "Email")]
        [Required]
        string Email { get; set; }
    }
}
