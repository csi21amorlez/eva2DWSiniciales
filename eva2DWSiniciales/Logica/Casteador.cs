using DAL_eva2DWSiniciales.Models.DAOs;
using DAL_eva2DWSiniciales.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eva2DWSiniciales.Logica
{
    //Converter--> Clase que gestionar la conversion de DTO a DAO y viceversa

    internal class Casteador
    {

        //DTOtoDAO --> Convierte el DTO de Notas Evaluacion en DAO para poder insertarlo en base de datos
        /*
         * Recibe un dto EvaTchNotasEvaluacionDTO y devuelve un dao con datos rellenos automaticamente 
         */
        public static EvaTchNotasEvaluacion DTOtoDAO(EvaTchNotasEvaluacionDTO dto)
        {
            Console.WriteLine("[INFO] -- Entrando en Converters.Casteador.DTOtoDAO");
            //Creamos el objeto de tipo EvaTchNotasEvaluacion
            EvaTchNotasEvaluacion dao = new EvaTchNotasEvaluacion();

            //Asignamos los valores del DTO al DAO
            dao.MdUuid = "Test";
            dao.MdFch = null;
            //Controlamos con que evaluacion estamos trabajando
            if (dto.DescEvaluacion == "Primera Evaluacion")
                dao.CodEvaluacion = "PR";
            if (dto.DescEvaluacion == "Segunda Evaluacion")
                dao.CodEvaluacion = "SG";
            if (dto.DescEvaluacion == "Tercera Evaluacion")
                dao.CodEvaluacion = "TC";
            dao.CodAlumno = dto.CodAlumno;
            dao.NotaEvaluacion = dto.NotaEvaluacion;

            Console.WriteLine("[INFO] -- Saliendo de Converters.Casteador.DTOtoDAO");
            return dao;
        }

        //DAOtoDTO --> Convierte el DAO con todos los campos en un DTO con los campos que necesitamos para trabajar
        /*
         * Recibe un Dao EvaTchNotasEvaluacion y devuelve un DTO listo para mostrar
        */
        public static EvaTchNotasEvaluacionDTO DAOtoDTO(EvaTchNotasEvaluacion dao)
        {
            Console.WriteLine("[INFO] -- Entrando en Converters.Casteador.DAOtoDTO");
            //Creamos el objeto de tipo EvaTchNotasEvaluaciondto
            EvaTchNotasEvaluacionDTO dto = new EvaTchNotasEvaluacionDTO();

            dto.CodAlumno = dao.CodAlumno;

            //Controlamos con que evaluacion estamos trabajando
            if (dao.CodEvaluacion == "PR")
                dto.DescEvaluacion = "Primera Evaluacion";
            if (dao.CodEvaluacion == "SG")
                dto.DescEvaluacion = "Segunda Evaluacion";
            if (dao.CodEvaluacion == "TC")
                dto.DescEvaluacion = "Tercera Evaluacion";
            dto.NotaEvaluacion = dao.NotaEvaluacion;

            Console.WriteLine("[INFO] -- Saliendo de Converters.Casteador.DAOtoDTO");
            return dto;
        }

        //DAOtoDTOList --> Convierte una lista de DAOs en una lista de DTOs
        /*
         * Recibe una lista List<EvaTchNotasEvaluacion> de DAOs y devuelve una List<EvaTchNotasEvaluacionDTO> de DTOs
         */
        public static List<EvaTchNotasEvaluacionDTO> DAOtoDTOList(List<EvaTchNotasEvaluacion> listDao)
        {
            List<EvaTchNotasEvaluacionDTO> listDto = new List<EvaTchNotasEvaluacionDTO>();
            Console.WriteLine("[INFO] -- Entrando en Converters.Casteador.DAOtoDTOList");
            //Leemos la lista de daos 
            foreach (EvaTchNotasEvaluacion dao in listDao)
                //Usamos el metodo DAOtoDTO para convertir los DAOs obtenidos a DTOs
                listDto.Add(DAOtoDTO(dao));
            Console.WriteLine("[INFO] -- Saliendo de Converters.Casteador.DAOtoDTOList");
            return listDto;
        }



    }
}
