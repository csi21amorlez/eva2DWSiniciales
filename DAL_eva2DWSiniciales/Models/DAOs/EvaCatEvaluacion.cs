using System;
using System.Collections.Generic;

namespace DAL_eva2DWSiniciales.Models.DAOs;

public partial class EvaCatEvaluacion
{
    public string CodEvaluacion { get; set; } = null!;

    public string DescEvaluacion { get; set; } = null!;

    public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();
}
