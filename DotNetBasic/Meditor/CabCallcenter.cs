using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasic.Meditor;

interface ICabCallcenter
{

    void Register(ICab cab);
    void BookCab(IPassenger Passenger);

}
public class CabCallcenter : ICabCallcenter
{
    private readonly Dictionary<ICab,string> cab = new Dictionary<ICab,string>();

    void ICabCallcenter.BookCab(IPassenger Passenger)
    {
        throw new NotImplementedException();
    }

    void ICabCallcenter.Register(ICab cab)
    {
        throw new NotImplementedException();
    }
}
