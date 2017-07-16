using System.ServiceModel;

namespace ServicoEstacionamento
{
    [ServiceContract]
    public interface IEstacionamento
    {
        [OperationContract]
        void Checkin(string placa);

        [OperationContract]
        double Checkout(string placa);

        [OperationContract]
        int VagasRestantes();
    }
}
