//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace login
{
    using System;
    using System.Collections.Generic;
    
    public partial class dossierAdmission
    {
        public string idAdmission { get; set; }
        public string chirurgie { get; set; }
        public Nullable<System.DateTime> dateAdmission { get; set; }
        public Nullable<System.DateTime> dateChirurgie { get; set; }
        public Nullable<System.DateTime> dateConge { get; set; }
        public string nss { get; set; }
        public string idCompanie { get; set; }
        public string refParent { get; set; }
    
        public virtual Assurance Assurance { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Parent Parent { get; set; }
    }
}
