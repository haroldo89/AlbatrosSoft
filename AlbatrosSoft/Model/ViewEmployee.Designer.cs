//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlbatrosSoft.Model
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class ViewEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string MobilePhone1 { get; set; }
        public string MobilePhone2 { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> Document { get; set; }
    }
}
