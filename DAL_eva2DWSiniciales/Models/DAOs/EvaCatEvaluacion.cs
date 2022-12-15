using System;
using System.Collections.Generic;

namespace DAL_eva2DWSiniciales.Models.DAOs;

//EvaCatEvaluacion -- Clase DAO de la tabla catalogo de evaluaciones de la base de datos 

public partial class EvaCatEvaluacion
{
    public string CodEvaluacion { get; set; } = null!;

    public string DescEvaluacion { get; set; } = null!;

    public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();
}
