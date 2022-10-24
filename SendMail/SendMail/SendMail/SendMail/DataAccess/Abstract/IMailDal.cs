using SendMail.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail.DataAccess.Abstract
{
  public interface IMailDal: IEntityRepository<Mail>
  {
  }
}
