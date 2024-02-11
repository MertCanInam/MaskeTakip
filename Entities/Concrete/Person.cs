using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;
// Class internal olursa farklı paketlerden çekilemez 
// import buradaki using gibi bir şey
public class Person
{
   
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public long NationalIdentity { get; set; }
    public int DateOfBirthYear { get; set; }
  

}
