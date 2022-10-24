using SendMail.DataAccess.Abstract;
using SendMail.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SendMail.DataAccess.Concrete.Entity_Framework
{
  public class EfMailDal : EfEntityRepositoryBase<Mail, MailContext>, IMailDal
  {
   
  }
}
