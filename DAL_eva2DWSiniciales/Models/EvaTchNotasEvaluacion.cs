﻿using System;
using System.Collections.Generic;

namespace DAL_eva2DWSiniciales.Models;

public partial class EvaTchNotasEvaluacion
{
    public string MdUuid { get; set; } = null!;

    public DateTime? MdFch { get; set; }

    public long IdNotaEvaluacion { get; set; }

    public string CodAlumno { get; set; } = null!;

    public int? NotaEvaluacion { get; set; }

    public string CodEvaluacion { get; set; } = null!;

    public virtual EvaCatEvaluacion CodEvaluacionNavigation { get; set; } = null!;
}
