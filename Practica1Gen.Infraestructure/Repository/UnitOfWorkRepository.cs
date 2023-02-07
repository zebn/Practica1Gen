

using Practica1Gen.ApplicationCore.IRepository.Practica1;
using Practica1Gen.Infraestructure.Repository.Practica1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1Gen.Infraestructure.Repository
{
public class UnitOfWorkRepository : GenericUnitOfWorkRepository
{
public UnitOfWorkRepository()
{
        this.clienterepository = new ClienteRepository ();
        this.facturarepository = new FacturaRepository ();
        this.reservarepository = new ReservaRepository ();
        this.lineafacturarepository = new LineaFacturaRepository ();
        this.cocherepository = new CocheRepository ();
}
}
}

