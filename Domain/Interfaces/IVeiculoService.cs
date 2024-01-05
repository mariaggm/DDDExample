using Domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IVeiculoService
    {
        //a interface é um contrato, apenas usamos para adicionar metodos, não é feita implementaçao de nada

        Task PostAsync(VeiculoCommand command);
        void PostAsync();
        void GetAsync();
    }
}
