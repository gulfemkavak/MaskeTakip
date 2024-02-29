using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;
//bir sınıf başka bir sınıfı kullanırken (entityler hariç) newliyorsa ileriye dönük değişiklik talebi geldiğinde bu uygulama direnç gösterir yani artık bu CitizenManagera bağımlılık gösterir.
public class PttManager:ISupplierService
{
    private IApplicantService _applicantService;
    
    public PttManager(IApplicantService applicantService)//Constructor new yapıldığında çalışır
    {
        _applicantService = applicantService;//classlarda fieldların altçizgiyle başlama sebebi budur contructordan onu set ederiz mesela
    }
    
    public void GiveMask(Citizen citizen)
    {
        if (_applicantService.CheckPerson(citizen))
        {
            Console.WriteLine(citizen.FirstName + " için maske verildi");
        }
        else
        {
            Console.WriteLine(citizen.FirstName + " için maske verilemedi.");
        }
    }
}
//Pttmanagerın bağımlı olduğu sınıf yerine o sınıfların interfaceini yazıyorum
//field
//Field : Bir class yada struct içinde tanımlanan her tipten değişkendir. Fieldlar onları içeren tiplerin üyeleridir. Fieldlar, birden fazla metodun erişim sağlaması gereken verileri saklarlar ve bu verinin saklanma zamanı herhangi bir metodun yaşam zamanından uzun olmalıdır.
/// <summary>
/// newlemek yerine interfaceini yazıyorum bu class başladığında lazım?
/// 