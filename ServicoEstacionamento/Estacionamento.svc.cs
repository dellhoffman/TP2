using Estacionamento.Negocio;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System;

namespace ServicoEstacionamento
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class Estacionamento : IEstacionamento
    {
        public void Checkin(string placa)
        {
            Operacoes.Checkin(placa);
        }

        public double Checkout(string placa)
        {
            return Operacoes.Checkout(placa);
        }

        public int VagasRestantes()
        {
            return Operacoes.VagasRestantes();
        }
    }
}
