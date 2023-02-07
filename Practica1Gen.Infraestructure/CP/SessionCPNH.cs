

using System;
using System.Collections.Generic;
using System.Text;
using Practica1Gen.ApplicationCore.CP.Practica1;
using Practica1Gen.Infraestructure.Repository.Practica1;
using NHibernate;

namespace Practica1Gen.Infraestructure.CP
{
public class SessionCPNHibernate : GenericSessionCP
{
ISession session;
ITransaction tx;
public SessionCPNHibernate(object currentSession) : base (currentSession)
{
        this.session = (ISession)currentSession;
}

public SessionCPNHibernate() : base ()
{
        this.session = NHibernateHelper.OpenSession ();
}
public override void SessionInitializeTransaction ()
{
        if (session == null) {
                session = NHibernateHelper.OpenSession ();
        }
        tx = session.BeginTransaction ();
}

public override void Commit ()
{
        if (session != null)
                tx.Commit ();
}

public override void RollBack ()
{
        if (session != null && session.IsOpen)
                tx.Rollback ();
}

public override void SessionClose ()
{
        if (session != null && session.IsOpen) {
                session.Close ();
                session.Dispose ();
                session = null;
        }
}
}
}


