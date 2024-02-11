using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager( IApplicantService applicantService)
    {
       _applicantService = applicantService; 
    }

    public void GiveMask(Person person)
    {
        if (_applicantService.checkPerson(person))
            Console.WriteLine( person.FirstName + " : " +"Masker verildi");
        else
            Console.WriteLine(person.FirstName + " : " +"Maske verilmedi");

    }

    public void GiveMask()
    {
        throw new NotImplementedException();
    }
}
