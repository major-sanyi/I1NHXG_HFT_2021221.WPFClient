﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

#nullable disable

namespace VegyesBolt.Data
{
    public partial class Vasarlasok
    {
        public double VasarloId { get; set; }
        public double TermekId { get; set; }
        public DateTime VasarlasDatuma { get; set; }
        public double? Mennyiseg { get; set; }

        public virtual Termekek Termek { get; set; }
        public virtual Vasarlok Vasarlo { get; set; }
    }
}