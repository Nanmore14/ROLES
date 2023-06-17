﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{

      //  entidad Roles
     public class ROLES
     {
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
        
        public ROLES()
        {
            Rol = string.Empty;
        }
         
     }
}
