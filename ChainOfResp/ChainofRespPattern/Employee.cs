using ChainOfResp.Models;

namespace ChainOfResp.ChainofRespPattern
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee employee)
        {
            this.NextApprover = employee;
            //parametreden gelen değeri fielda atar bir sonrakine set etmiş oluyoruz
        }
        public abstract void ProcessRequest(CustomerViewModel customerViewModel); //işlemin kimden başlayacağını bilidirecek
    }
}

//Burayı Abstract class yapıcaz çünkü tüm çalışanlar özünde bir Employee olucak
//Protected o sınıftan ve o sınıfı miras alanlardan erişim sağlanıyor
