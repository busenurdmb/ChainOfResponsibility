using ChainOfResp.DAL;
using ChainOfResp.Models;

namespace ChainOfResp.ChainofRespPattern
{
    public class ManagerAsistant : Employee
    {
        private readonly Context _context;

        public ManagerAsistant(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 150000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeName = "Tuba Balkan";
                customerProcess.Description = "Talep ettiğiniz tutar şube müdür yardımcısı tarafından ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();

            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeName = "Tuba Balkan";
                customerProcess.Description = "Talep ettiğiniz tutar şube müdür yardımcısı tarafından ödenemedi işlem şube müdürüne aktarıldı";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(customerViewModel);
            }
        }
    }
}
