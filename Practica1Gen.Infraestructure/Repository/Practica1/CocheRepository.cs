
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
 * Clase Coche:
 *
 */

namespace Practica1Gen.Infraestructure.Repository.Practica1
{
public partial class CocheRepository : BasicRepository, ICocheRepository
{
public CocheRepository() : base ()
{
}


public CocheRepository(ISession sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public CocheEN ReadOIDDefault (int numLicencia
                               )
{
        CocheEN cocheEN = null;

        try
        {
                SessionInitializeTransaction ();
                cocheEN = (CocheEN)session.Get (typeof(CocheNH), numLicencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cocheEN;
}

public System.Collections.Generic.IList<CocheEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CocheEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CocheNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<CocheEN>();
                        else
                                result = session.CreateCriteria (typeof(CocheNH)).List<CocheEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CocheEN coche)
{
        try
        {
                SessionInitializeTransaction ();
                CocheNH cocheNH = (CocheNH)session.Load (typeof(CocheNH), coche.NumLicencia);

                cocheNH.Categoria = coche.Categoria;


                cocheNH.Estado = coche.Estado;


                session.Update (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int CrearCoche (CocheEN coche)
{
        CocheNH cocheNH = new CocheNH (coche);

        try
        {
                SessionInitializeTransaction ();

                session.Save (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cocheNH.NumLicencia;
}

public void BorrarCoche (int numLicencia
                         )
{
        try
        {
                SessionInitializeTransaction ();
                CocheNH cocheNH = (CocheNH)session.Load (typeof(CocheNH), numLicencia);
                session.Delete (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Modificar (CocheEN coche)
{
        try
        {
                SessionInitializeTransaction ();
                CocheNH cocheNH = (CocheNH)session.Load (typeof(CocheNH), coche.NumLicencia);

                cocheNH.Categoria = coche.Categoria;


                cocheNH.Estado = coche.Estado;

                session.Update (cocheNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
//Sin e: DamePorOID
//Con e: CocheEN
public CocheEN DamePorOID (int numLicencia
                           )
{
        CocheEN cocheEN = null;

        try
        {
                SessionInitializeTransaction ();
                cocheEN = (CocheEN)session.Get (typeof(CocheNH), numLicencia);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cocheEN;
}

public System.Collections.Generic.IList<CocheEN> DameTodos (int first, int size)
{
        System.Collections.Generic.IList<CocheEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CocheNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<CocheEN>();
                else
                        result = session.CreateCriteria (typeof(CocheNH)).List<CocheEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Practica1Gen.ApplicationCore.Exceptions.ModelException)
                        throw ex;
                throw new Practica1Gen.ApplicationCore.Exceptions.DataLayerException ("Error in CocheRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
