using System;
using System.Collections.Generic;

namespace DAL_eva2DWSiniciales.Models;

/*
 * EvaTchNotasEvaluacion --> Clase DAO que gestionara el acceso a la base de datos bd_evalucion, concretamente a la tabla de 
 * notas en la evaluacion
 */

public partial class EvaTchNotasEvaluacion
{
    public string MdUuid { get; set; } = null!;

    public DateTime? MdFch { get; set; }

    public long IdNotaEvaluacion { get; set; }

    public string CodAlumno { get; set; } = null!;

    public int? NotaEvaluacion { get; set; }

    public string CodEvaluacion { get; set; } = null!;
}
