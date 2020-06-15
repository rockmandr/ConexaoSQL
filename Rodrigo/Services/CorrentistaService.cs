using System;
using System.Collections.Generic;
using SqlCsharp.Models;

namespace SqlCsharp.Services
{
    public class CorrentistaService : Correntista
    {
        public static List<CorrentistaService> GetCorrentistaServices()
        {
            var listaCorrentistaServices = new List<CorrentistaService>()
            {
                new CorrentistaService {Id = 1, Nome = "Rodrigo", DataNascimento = "07/02/2000", Cpf = "111111111111" }
            };

            return listaCorrentistaServices;
        }
    }
}