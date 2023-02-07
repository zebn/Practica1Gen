
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
 * Clase LineaFactura:
 *
 */

namespace Practica1Gen.Infraestructure.Repository.Practica1
{
public partial class LineaFacturaRepository : BasicRepository, ILineaFacturaRepository
{
public LineaFacturaRepository() : base ()
{
}


public LineaFacturaRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public LineaFacturaEN ReadOIDDefault (int numLinea
                                      )
{
        LineaFacturaEN lineaFacturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaFacturaEN = (LineaFacturaEN)session.Get (typeof(LineaFacturaNH), numLinea);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in LineaFacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaFacturaEN;
}

public System.Collections.Generic.IList<LineaFacturaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LineaFacturaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LineaFacturaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<LineaFacturaEN>();
                        else
                                result = session.CreateCriteria (typeof(LineaFacturaNH)).List<LineaFacturaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in LineaFacturaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LineaFacturaEN lineaFactura)
{
        try
        {
                SessionInitializeTransaction ();
                LineaFacturaNH lineaFacturaNH = (LineaFacturaNH)session.Load (typeof(LineaFacturaNH), lineaFactura.NumLinea);

                lineaFacturaNH.Precio = lineaFactura.Precio;



                session.Update (lineaFacturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in LineaFacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearLinea (LineaFacturaEN lineaFactura)
{
        LineaFacturaNH lineaFacturaNH = new LineaFacturaNH (lineaFactura);

        try
        {
                SessionInitializeTransaction ();
                if (lineaFactura.Reserva != null) {
                        // Argumento OID y no colección.
                        lineaFacturaNH
                        .Reserva = (Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN)session.Load (typeof(Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN), lineaFactura.Reserva.Id);

                        lineaFactura.Reserva.LineaFactura
                                = lineaFactura;
                }
                if (lineaFactura.Factura != null) {
                        // Argumento OID y no colección.
                        lineaFacturaNH
                        .Factura = (Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN)session.Load (typeof(Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN), lineaFactura.Factura.Id);

                        lineaFactura.Factura.LineaFactura
                        .Add (lineaFactura);
                }

                session.Save (lineaFacturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in LineaFacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaFacturaNH.NumLinea;
}
}
}
