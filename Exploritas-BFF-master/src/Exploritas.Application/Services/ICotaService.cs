using Exploritas.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exploritas.Application.Services
{
    public interface ICotaService
    {
        Task<List<CotaViewModel>> BuscarAsync();
        Task<List<CotaViewModel>> ObterPorData(DateTime data);
    }
}
