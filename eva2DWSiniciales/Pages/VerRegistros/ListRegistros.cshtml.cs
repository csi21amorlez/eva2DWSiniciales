﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL_eva2DWSiniciales.Models.DAOs;
using DAL_eva2DWSiniciales.Models.DTOs;


namespace eva2DWSiniciales.Pages.VerRegistros
{
    public class ListRegistrosModel : PageModel
    {
        private readonly DAL_eva2DWSiniciales.Models.BdEvaluacionContext _context;

        public ListRegistrosModel(DAL_eva2DWSiniciales.Models.BdEvaluacionContext context)
        {
            _context = context;
        }

        public IList<EvaTchNotasEvaluacionDTO> EvaTchNotasEvaluacion { get;set; } = default!;

        public async Task OnGetAsync()
        {
            
            if (_context.EvaTchNotasEvaluacions != null)
            {
                EvaTchNotasEvaluacion = Casteador.DAOtoDTOList(await (_context.EvaTchNotasEvaluacions
                .Include(e => e.CodEvaluacionNavigation).ToListAsync()));
            }
        }
    }
}