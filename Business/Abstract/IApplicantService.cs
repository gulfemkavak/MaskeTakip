using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

//interface: birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar
public interface IApplicantService
{
    void ApplyForMask(Citizen citizen);


    List<Citizen> GetList();

    bool CheckPerson(Citizen citizen);

}
