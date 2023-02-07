
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
 * Clase Factura:
 *
 */

namespace Practica1Gen.Infraestructure.Repository.Practica1
{
public partial class FacturaRepository : BasicRepository, IFacturaRepository
{
public FacturaRepository() : base ()
{
}


public FacturaRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public FacturaEN ReadOIDDefault (int id
                                 )
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(FacturaNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                        else
                                result = session.CreateCriteria (typeof(FacturaNH)).List<FacturaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaNH facturaNH = (FacturaNH)session.Load (typeof(FacturaNH), factura.Id);

                facturaNH.Fecha = factura.Fecha;


                facturaNH.EsPagada = factura.EsPagada;


                facturaNH.EsAnulada = factura.EsAnulada;


                facturaNH.Total = factura.Total;



                session.Update (facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearFactura (FacturaEN factura)
{
        FacturaNH facturaNH = new FacturaNH (factura);

        try
        {
                SessionInitializeTransaction ();
                if (factura.LineaFactura != null) {
                        foreach (Practica1Gen.ApplicationCore.EN.Practica1.LineaFacturaEN item in factura.LineaFactura) {
                                item.Factura = factura;
                                session.Save (item);
                        }
                }
                if (factura.Cliente != null) {
                        // Argumento OID y no colección.
                        facturaNH
                        .Cliente = (Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN)session.Load (typeof(Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN), factura.Cliente.DNI);

                        factura.Cliente.Factura
                        .Add (factura);
                }

                session.Save (facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaNH.Id;
}

public void Modficar (FacturaEN factura)
{
        try
        {
                SessionInitializeTransaction ();
                FacturaNH facturaNH = (FacturaNH)session.Load (typeof(FacturaNH), factura.Id);

                facturaNH.Fecha = factura.Fecha;


                facturaNH.EsPagada = factura.EsPagada;


                facturaNH.EsAnulada = factura.EsAnulada;


                facturaNH.Total = factura.Total;

                session.Update (facturaNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
//Sin e: DanePorOID
//Con e: FacturaEN
public FacturaEN DanePorOID (int id
                             )
{
        FacturaEN facturaEN = null;

        try
        {
                SessionInitializeTransaction ();
                facturaEN = (FacturaEN)session.Get (typeof(FacturaNH), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> DameTODO (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(FacturaNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<FacturaEN>();
                else
                        result = session.CreateCriteria (typeof(FacturaNH)).List<FacturaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in FacturaRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
