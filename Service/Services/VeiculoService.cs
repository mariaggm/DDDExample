using Domain.Command;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service.Services
{
    public class VeiculoService : IVeiculoService
    {
        public void GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(VeiculoCommand command)
        {
            if (command == null)
                return "Todos os campos sao obrigatorios";

            int AnoAtual = DateTime.Now.Year;
            if (AnoAtual - command.Anofabricacao >= 5)
                return "O ano do veiculo é menor que o permitido";

            if (command.TipoVeiculo != ETipoVeiculo.SUVs
                && command.TipoVeiculo != ETipoVeiculo.Hatchs
                && command.TipoVeiculo != ETipoVeiculo.Sedans
            )
                return "o tipo de veiculo não é permitido";


            return "cadastro realizado com sucesso";

        }
        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
