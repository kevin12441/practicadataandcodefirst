﻿using System;
using System.Collections.Generic;

namespace Practicadata.Models;

public partial class TiposDeDocumento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}
