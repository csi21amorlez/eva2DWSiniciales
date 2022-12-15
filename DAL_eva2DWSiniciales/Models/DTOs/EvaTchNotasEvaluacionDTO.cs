using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_eva2DWSiniciales.Models.DTOs
{

    //EvaTchNotasEvaluacionDTO --> Clase DTO que usaremos para trabajar con los datos obtenidos de la clave DAO EvaTchNotasEvaluacion
    public class EvaTchNotasEvaluacionDTO
    {
        //Codigo del alumno
        public string CodAlumno { get; set; } = null!;
        //Nota de la evaluacion
        public int? NotaEvaluacion { get; set; }
        //Codigo de evaluacion
        public string DescEvaluacion { get; set; } = null!;

    }
}
