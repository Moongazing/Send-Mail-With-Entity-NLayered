using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMail.Entities.Concrete
{
  public class TrashMail
  {
    public int Id { get; set; }
    public string Sender { get; set; }
    public string SendTo { get; set; }
    public string Subject { get; set; }
    public string CC { get; set; }
    public string Body { get; set; }
    public DateTime SentDate { get; set; }
    public DateTime DeleteTime { get; set; }
    public string Status { get; set; }
  }
}
