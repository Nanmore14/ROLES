﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class ROLPERMISO
    { 
        //  entidad RolPermisos
        public int IdRolPermiso { get; set; }
        public int IdRol { get; set; }
        public int IdPermiso { get; set; }
        public int IdRolFormulario { get; set; }
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public ROLPERMISO()
        {
            IdRolPermiso = int.Empty;
        }
      
     
    }

}
