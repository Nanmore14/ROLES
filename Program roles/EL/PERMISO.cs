﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{

    //  entidad Permisos
    public class PERMISO
    {
        public int IdPermiso { get; set; }
        public string? Permiso { get; set; }
        public bool Activo { get; set; }
        public int IdUsuarioRegistra { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioActualiza { get; set; }
        public DateTime FechaActualizacion { get; set; }
        
        public PERMISO() 
        {
            Permiso = string.Empty;

        }
    }
}
