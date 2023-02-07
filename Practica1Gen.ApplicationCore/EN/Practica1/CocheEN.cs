
using System;
// Definición clase CocheEN
namespace Practica1Gen.ApplicationCore.EN.Practica1
{
public partial class CocheEN
{
/**
 *	Atributo numLicencia
 */
private int numLicencia;



/**
 *	Atributo categoria
 */
private Practica1Gen.ApplicationCore.Enumerated.Practica1.CategoriaCocheEnum categoria;



/**
 *	Atributo estado
 */
private Practica1Gen.ApplicationCore.Enumerated.Practica1.EstadoCocheEnum estado;



/**
 *	Atributo reserva
 */
private Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN reserva;






public virtual int NumLicencia {
        get { return numLicencia; } set { numLicencia = value;  }
}



public virtual Practica1Gen.ApplicationCore.Enumerated.Practica1.CategoriaCocheEnum Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual Practica1Gen.ApplicationCore.Enumerated.Practica1.EstadoCocheEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN Reserva {
        get { return reserva; } set { reserva = value;  }
}





public CocheEN()
{
}



public CocheEN(int numLicencia, Practica1Gen.ApplicationCore.Enumerated.Practica1.CategoriaCocheEnum categoria, Practica1Gen.ApplicationCore.Enumerated.Practica1.EstadoCocheEnum estado, Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN reserva
               )
{
        this.init (NumLicencia, categoria, estado, reserva);
}


public CocheEN(CocheEN coche)
{
        this.init (NumLicencia, coche.Categoria, coche.Estado, coche.Reserva);
}

private void init (int numLicencia
                   , Practica1Gen.ApplicationCore.Enumerated.Practica1.CategoriaCocheEnum categoria, Practica1Gen.ApplicationCore.Enumerated.Practica1.EstadoCocheEnum estado, Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN reserva)
{
        this.NumLicencia = numLicencia;


        this.Categoria = categoria;

        this.Estado = estado;

        this.Reserva = reserva;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CocheEN t = obj as CocheEN;
        if (t == null)
                return false;
        if (NumLicencia.Equals (t.NumLicencia))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NumLicencia.GetHashCode ();
        return hash;
}
}
}
