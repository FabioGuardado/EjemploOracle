﻿using System;
using System.Collections.Generic;

namespace EjemploOracle.DataAccess.Models
{
    public partial class Categorium
    {
        public decimal Id { get; set; }
        public string? Nombre { get; set; }

        public static implicit operator Task<object>(Categorium v)
        {
            throw new NotImplementedException();
        }
    }
}
