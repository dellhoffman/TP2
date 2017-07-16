﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estacionamento.Apresentacao.ServicoEstacionamento {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicoEstacionamento.IEstacionamento")]
    public interface IEstacionamento {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamento/Checkin", ReplyAction="http://tempuri.org/IEstacionamento/CheckinResponse")]
        void Checkin(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamento/Checkin", ReplyAction="http://tempuri.org/IEstacionamento/CheckinResponse")]
        System.Threading.Tasks.Task CheckinAsync(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamento/Checkout", ReplyAction="http://tempuri.org/IEstacionamento/CheckoutResponse")]
        double Checkout(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamento/Checkout", ReplyAction="http://tempuri.org/IEstacionamento/CheckoutResponse")]
        System.Threading.Tasks.Task<double> CheckoutAsync(string placa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamento/VagasRestantes", ReplyAction="http://tempuri.org/IEstacionamento/VagasRestantesResponse")]
        int VagasRestantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstacionamento/VagasRestantes", ReplyAction="http://tempuri.org/IEstacionamento/VagasRestantesResponse")]
        System.Threading.Tasks.Task<int> VagasRestantesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstacionamentoChannel : Estacionamento.Apresentacao.ServicoEstacionamento.IEstacionamento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstacionamentoClient : System.ServiceModel.ClientBase<Estacionamento.Apresentacao.ServicoEstacionamento.IEstacionamento>, Estacionamento.Apresentacao.ServicoEstacionamento.IEstacionamento {
        
        public EstacionamentoClient() {
        }
        
        public EstacionamentoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstacionamentoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstacionamentoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstacionamentoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Checkin(string placa) {
            base.Channel.Checkin(placa);
        }
        
        public System.Threading.Tasks.Task CheckinAsync(string placa) {
            return base.Channel.CheckinAsync(placa);
        }
        
        public double Checkout(string placa) {
            return base.Channel.Checkout(placa);
        }
        
        public System.Threading.Tasks.Task<double> CheckoutAsync(string placa) {
            return base.Channel.CheckoutAsync(placa);
        }
        
        public int VagasRestantes() {
            return base.Channel.VagasRestantes();
        }
        
        public System.Threading.Tasks.Task<int> VagasRestantesAsync() {
            return base.Channel.VagasRestantesAsync();
        }
    }
}