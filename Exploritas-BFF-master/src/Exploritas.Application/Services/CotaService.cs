using AutoMapper;
using Exploritas.Application.ViewModels;
using Exploritas.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exploritas.Application.Services
{
    public class CotaService: ICotaService
    {

        private readonly ICotaRepository _cotaRepository;
        private readonly IMapper _mapper;

        public CotaService(ICotaRepository cotaRepository, IMapper mapper)
        {
            _cotaRepository = cotaRepository;
            _mapper = mapper;
        }

        public async Task<List<CotaViewModel>> BuscarAsync()
        {
            var cotas = _mapper.Map<List<CotaViewModel>>(await _cotaRepository?.ObterTodos());

            return cotas;
        }
        public async Task<List<CotaViewModel>> ObterPorData(DateTime data)
        {
            var cota = _mapper.Map<List<CotaViewModel>>(await _cotaRepository?.ObterPor(c=>c.Data.Month==data.Month && c.Data.Year == data.Year)).OrderByDescending(c=>c.Data).FirstOrDefault();

            return new List<CotaViewModel> { cota };
        }
    }
}
