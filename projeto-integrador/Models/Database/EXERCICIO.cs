
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Projeto_Integrador.Models.Database
{

using System;
    using System.Collections.Generic;
    
public partial class EXERCICIO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public EXERCICIO()
    {

        this.TREINAMENTO = new HashSet<TREINAMENTO>();

    }


    public short COD_EXERCICIO { get; set; }

    public short COD_GRUMUSC { get; set; }

    public string NOM_EXERCICIO { get; set; }

    public string SIG_EXERCICIO { get; set; }

    public Nullable<bool> STA_EXERCICIO { get; set; }

    public string TIP_EXERCICIO { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<TREINAMENTO> TREINAMENTO { get; set; }

    public virtual GRUPO_MUSCULAR GRUPO_MUSCULAR { get; set; }

}

}
