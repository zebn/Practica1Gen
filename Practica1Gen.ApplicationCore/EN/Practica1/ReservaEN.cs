
using System;
// Definición clase ReservaEN
namespace Practica1Gen.ApplicationCore.EN.Practica1
{
public partial class ReservaEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo inicio
 */
private Nullable<DateTime> inicio;



/**
 *	Atributo final
 */
private Nullable<DateTime> final;



/**
 *	Atributo coche
 */
private Practica1Gen.ApplicationCore.EN.Practica1.CocheEN coche;



/**
 *	Atributo lineaFactura
 */
private Practica1Gen.ApplicationCore.EN.Practica1.LineaFacturaEN lineaFactura;



/**
 *	Atributo cliente
 */
private Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN cliente;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> Inicio {
        get { return inicio; } set { inicio = value;  }
}



public virtual Nullable<DateTime> Final {
        get { return final; } set { final = value;  }
}



public virtual Practica1Gen.ApplicationCore.EN.Practica1.CocheEN Coche {
        get { return coche; } set { coche = value;  }
}



public virtual Practica1Gen.ApplicationCore.EN.Practica1.LineaFacturaEN LineaFactura {
        get { return lineaFactura; } set { lineaFactura = value;  }
}



public virtual Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN Cliente {
        get { return cliente; } set { cliente = value;  }
}





public ReservaEN()
{
}



public ReservaEN(int id, Nullable<DateTime> inicio, Nullable<DateTime> final, Practica1Gen.ApplicationCore.EN.Practica1.CocheEN coche, Practica1Gen.ApplicationCore.EN.Practica1.LineaFacturaEN lineaFactura, Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN cliente
                 )
{
        this.init (Id, inicio, final, coche, lineaFactura, cliente);
}


public ReservaEN(ReservaEN reserva)
{
        this.init (Id, reserva.Inicio, reserva.Final, reserva.Coche, reserva.LineaFactura, reserva.Cliente);
}

private void init (int id
                   , Nullable<DateTime> inicio, Nullable<DateTime> final, Practica1Gen.ApplicationCore.EN.Practica1.CocheEN coche, Practica1Gen.ApplicationCore.EN.Practica1.LineaFacturaEN lineaFactura, Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN cliente)
{
        this.Id = id;


        this.Inicio = inicio;

        this.Final = final;

        this.Coche = coche;

        this.LineaFactura = lineaFactura;

        this.Cliente = cliente;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ReservaEN t = obj as ReservaEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
