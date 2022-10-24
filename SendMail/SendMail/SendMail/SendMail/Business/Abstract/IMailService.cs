using SendMail.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail.Business.Abstract
{
  public interface IMailService
  {
    void Add(Mail mail);
    void Delete(Mail mail);
    List<Mail> GetAll();
    List<Mail> GetMailsTasks(int categoryId);
    List<Mail> GetMailsByStatus(string status);
    void Update(Mail mail);
    List<Mail> GetMailByAdress(string text);
  }
}
