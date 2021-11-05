using RiverPoints.Business.Model.DBModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverPoints.Business.Model.Partials
{ 
    public partial class VMUser : User
    {
        public string UserTypeName { get; set; }
    }
}
