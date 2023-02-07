
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1Gen.ApplicationCore.IRepository.Practica1
{
public abstract class GenericUnitOfWorkRepository
{
public IClienteRepository clienterepository {
        set; get;
}
public IFacturaRepository facturarepository {
        set; get;
}
public IReservaRepository reservarepository {
        set; get;
}
public ILineaFacturaRepository lineafacturarepository {
        set; get;
}
public ICocheRepository cocherepository {
        set; get;
}
}
}
