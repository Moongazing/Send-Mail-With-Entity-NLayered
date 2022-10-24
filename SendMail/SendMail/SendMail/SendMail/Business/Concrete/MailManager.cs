using SendMail.Business.Abstract;
using SendMail.DataAccess.Abstract;
using SendMail.DataAccess.Concrete.Entity_Framework;
using SendMail.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail.Business.Concrete
{
  public class MailManager : IMailService
  {
    private IMailDal _mailService;

    public MailManager(IMailDal mailService)
    {
      _mailService = mailService;
    }
    public void Add(Mail mail)
    {
      _mailService.Add(mail);
    }

    public void AddTrash(Mail mail)
    {
      throw new NotImplementedException();
    }

    public void Delete(Mail mail)
    {
      _mailService.Delete(mail);
    }

    public List<Mail> GetAll()
    {
      return _mailService.GetAll();
      
    }

    public List<Mail> GetMailByAdress(string text)
    {
      return _mailService.GetAll(p => p.SendTo.ToLower().Contains(text.ToLower()));
    }

    public List<Mail> GetMailsByStatus(string status)
    {
      return _mailService.GetAll(p => p.Status == status);
    }

    public List<Mail> GetMailsTasks(int categoryId)
    {
      throw new NotImplementedException();
    }

    public void Update(Mail mail)
    {
      _mailService.Update(mail);
    }
  }
}
