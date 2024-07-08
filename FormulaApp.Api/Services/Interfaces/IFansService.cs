using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaApp.Api.Models;

namespace FormulaApp.Api.Services.Interfaces
{
    public interface IFansService
    {
        Task<List<Fans>> GetAllFans();
    }
}