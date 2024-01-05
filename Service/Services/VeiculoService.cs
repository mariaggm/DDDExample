using Domain.Command;
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

        public Task PostAsync(VeiculoCommand command)
        {
            //todo 

            //incluir vaidação, so podem cadrastrar veilucos com ate 5 anos de uso

            //todo  
            // incluir somente carros do tipo USVs, sedan e hatch

            throw new NotImplementedException();
        }

        public void PostAsync()
        {
            throw new NotImplementedException();
        }
    }
}
