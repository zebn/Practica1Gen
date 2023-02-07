
using System;
// Definición clase LineaFacturaEN
namespace Practica1Gen.ApplicationCore.EN.Practica1
{
public partial class LineaFacturaEN
{
/**
 *	Atributo numLinea
 */
private int numLinea;



/**
 *	Atributo precio
 */
private double precio;



/**
 *	Atributo reserva
 */
private Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN reserva;



/**
 *	Atributo factura
 */
private Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN factura;






public virtual int NumLinea {
        get { return numLinea; } set { numLinea = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN Reserva {
        get { return reserva; } set { reserva = value;  }
}



public virtual Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN Factura {
        get { return factura; } set { factura = value;  }
}





public LineaFacturaEN()
{
}



public LineaFacturaEN(int numLinea, double precio, Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN reserva, Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN factura
                      )
{
        this.init (NumLinea, precio, reserva, factura);
}


public LineaFacturaEN(LineaFacturaEN lineaFactura)
{
        this.init (NumLinea, lineaFactura.Precio, lineaFactura.Reserva, lineaFactura.Factura);
}

private void init (int numLinea
                   , double precio, Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN reserva, Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN factura)
{
        this.NumLinea = numLinea;


        this.Precio = precio;

        this.Reserva = reserva;

        this.Factura = factura;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaFacturaEN t = obj as LineaFacturaEN;
        if (t == null)
                return false;
        if (NumLinea.Equals (t.NumLinea))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.NumLinea.GetHashCode ();
        return hash;
}
}
}
