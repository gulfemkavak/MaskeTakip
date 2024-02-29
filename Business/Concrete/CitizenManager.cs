using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;
//çıplak class kalmasın
//bir classı yazmaya başladığımızda onun interfaceini oluşturduğundan emin ol önce interfacele başlanır aslında
public class CitizenManager : IApplicantService
{
    //is encapsulation propertyleri bir nesnenin içine koyup kullanmak  yeni bir prop eklediğimde de sıkıntı çıkmıyor böylece. nesneyi merkezileştirmek?
    public void ApplyForMask(Citizen citizen)
    {

    }

    public List<Citizen> GetList()
    {
        return null;
    }
    public bool CheckPerson(Citizen citizen)
    {
        //mernis kontrolü yapılacak
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(citizen.NationalIdentity, citizen.FirstName, citizen.LastName, citizen.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }
}