//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokeTrumps
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainerPokemon
    {
        public short PokemonID { get; set; }
        public short TrainerID { get; set; }
        public bool Team { get; set; }
        public bool Favourite { get; set; }
    
        public virtual Pokemon Pokemon { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
