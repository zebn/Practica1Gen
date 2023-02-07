
using System;
using System.Text;
using Practica1Gen.ApplicationCore.CEN.Practica1;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.Exceptions;
using Practica1Gen.ApplicationCore.IRepository.Practica1;
using Practica1Gen.ApplicationCore.CP.Practica1;
using Practica1Gen.Infraestructure.EN.Practica1;


/*
 * Clase Reserva:
 *
 */

namespace Practica1Gen.Infraestructure.Repository.Practica1
{
public partial class ReservaRepository : BasicRepository, IReservaRepository
{
public ReservaRepository() : base ()
{
}


public ReservaRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ReservaEN ReadOIDDefault (int id
                                 )
{
        ReservaEN reservaEN = null;

        try
        {
                SessionInitializeTransaction ();
                reservaEN = (ReservaEN)session.Get (typeof(ReservaNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaEN;
}

public System.Collections.Generic.IList<ReservaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ReservaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ReservaEN>();
                        else
                                result = session.CreateCriteria (typeof(ReservaNH)).List<ReservaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ReservaEN reserva)
{
        try
        {
                SessionInitializeTransaction ();
                ReservaNH reservaNH = (ReservaNH)session.Load (typeof(ReservaNH), reserva.Id);

                reservaNH.Inicio = reserva.Inicio;


                reservaNH.Final = reserva.Final;




                session.Update (reservaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearReserva (ReservaEN reserva)
{
        ReservaNH reservaNH = new ReservaNH (reserva);

        try
        {
                SessionInitializeTransaction ();
                if (reserva.Cliente != null) {
                        // Argumento OID y no colección.
                        reservaNH
                        .Cliente = (Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN)session.Load (typeof(Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN), reserva.Cliente.DNI);

                        reserva.Cliente.Reserva
                        .Add (reserva);
                }

                session.Save (reservaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return reservaNH.Id;
}

public void BorrarReserva (int id
                           )
{
        try
        {
                SessionInitializeTransaction ();
                ReservaNH reservaNH = (ReservaNH)session.Load (typeof(ReservaNH), id);
                session.Delete (reservaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in ReservaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
