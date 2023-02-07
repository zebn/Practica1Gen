

using System;
using System.Text;
using System.Collections.Generic;

using Practica1Gen.ApplicationCore.Exceptions;

using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
/*
 *      Definition of the class CocheCEN
 *
 */
public partial class CocheCEN
{
private ICocheRepository _ICocheRepository;

public CocheCEN(ICocheRepository _ICocheRepository)
{
        this._ICocheRepository = _ICocheRepository;
}

public ICocheRepository get_ICocheRepository ()
{
        return this._ICocheRepository;
}

public int CrearCoche (Practica1Gen.ApplicationCore.Enumerated.Practica1.CategoriaCocheEnum p_categoria)
{
        CocheEN cocheEN = null;
        int oid;

        //Initialized CocheEN
        cocheEN = new CocheEN ();
        cocheEN.Categoria = p_categoria;

        cocheEN.Estado = Practica1Gen.ApplicationCore.Enumerated.Practica1.EstadoCocheEnum.libre;

        //Call to CocheRepository

        oid = _ICocheRepository.CrearCoche (cocheEN);
        return oid;
}

public void BorrarCoche (int numLicencia
                         )
{
        _ICocheRepository.BorrarCoche (numLicencia);
}

public void Modificar (int p_Coche_OID, Practica1Gen.ApplicationCore.Enumerated.Practica1.CategoriaCocheEnum p_categoria, Practica1Gen.ApplicationCore.Enumerated.Practica1.EstadoCocheEnum p_estado)
{
        CocheEN cocheEN = null;

        //Initialized CocheEN
        cocheEN = new CocheEN ();
        cocheEN.NumLicencia = p_Coche_OID;
        cocheEN.Categoria = p_categoria;
        cocheEN.Estado = p_estado;
        //Call to CocheRepository

        _ICocheRepository.Modificar (cocheEN);
}

public CocheEN DamePorOID (int numLicencia
                           )
{
        CocheEN cocheEN = null;

        cocheEN = _ICocheRepository.DamePorOID (numLicencia);
        return cocheEN;
}

public System.Collections.Generic.IList<CocheEN> DameTodos (int first, int size)
{
        System.Collections.Generic.IList<CocheEN> list = null;

        list = _ICocheRepository.DameTodos (first, size);
        return list;
}
}
}
