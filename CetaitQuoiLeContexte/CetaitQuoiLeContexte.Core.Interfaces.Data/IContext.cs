﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CetaitQuoiLeContexte.Core.Interfaces.Data
{
    public interface IContext : Boissonnot.Framework.Core.Interfaces.Data.IParentModel
    {
        /// <summary>
        /// Contenu du context
        /// </summary>
        [Display(Name = "Phrase")]
        [Required]
        string Message { get; set; }

        /// <summary>
        /// Auteur du contexte
        /// </summary>
        IPerson Author { get; set; }

        /// <summary>
        /// Id de l'auteur
        /// </summary>
        int AuthorId { get; set; }

        /// <summary>
        /// Date de création
        /// </summary>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Provenance
        /// </summary>
        [Display(Name = "Contexte")]
        string From { get; set; }

        /// <summary>
        /// Titre formatté pour passer en paramètre get, en url
        /// </summary>
        string HtmlTitle { get; set; }
    }
}
