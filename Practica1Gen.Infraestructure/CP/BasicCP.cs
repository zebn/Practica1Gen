

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using Practica1Gen.Infraestructure.Repository.Practica1;
using Practica1Gen.ApplicationCore.CP.Practica1;
using Practica1Gen.Infraestructure.Repository;

namespace Practica1Gen.Infraestructure.CP
{
public class BasicCPNHibernate : GenericBasicCP
{
protected ISession session;

protected ITransaction tx;


protected BasicCPNHibernate(SessionCPNHibernate sessionCP, UnitOfWorkRepository unitRepo) : base (sessionCP, unitRepo)
{
        session = (ISession)sessionCP.CurrentSession;
}
}
}

