using ChainOfResp.DAL;
using ChainOfResp.Models;

namespace ChainOfResp.ChainofRespPattern
{
    public class Manager : Employee
    {
        private readonly Context _context;

        public Manager(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeName = "Metehan Sönmez";
                customerProcess.Description = "Talep ettiğiniz tutar şube müdürü tarafından ödendi";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();

            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeName = "Metehan Sönmez";
                customerProcess.Description = "Talep ettiğiniz tutar şube müdürü tarafından ödenemedi işlem bölge müdürüne aktarıldı";
                _context.CustomerProcesses.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(customerViewModel);
            }
        }
    }
}
