using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaApp.Api.Models;
using FormulaApp.Api.Services.Interfaces;

namespace FormulaApp.Api.Services
{
    public class FansService : IFansService
    {
        public Task<List<Fans>> GetAllFans()
        {
            throw new NotImplementedException();
        }
    }
}