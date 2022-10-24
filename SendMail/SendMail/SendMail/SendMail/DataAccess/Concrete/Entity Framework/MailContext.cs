using SendMail.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail.DataAccess.Concrete.Entity_Framework
{
  public class MailContext:DbContext
  {
    public DbSet<Mail> Mails { get; set; }
   
  }
}
