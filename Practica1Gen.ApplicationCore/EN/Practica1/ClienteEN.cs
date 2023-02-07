
using System;
// Definición clase ClienteEN
namespace Practica1Gen.ApplicationCore.EN.Practica1
{
public partial class ClienteEN
{
/**
 *	Atributo dNI
 */
private string dNI;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo direccion
 */
private string direccion;



/**
 *	Atributo telefono
 */
private string telefono;



/**
 *	Atributo factura
 */
private System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN> factura;



/**
 *	Atributo reserva
 */
private System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN> reserva;



/**
 *	Atributo pass
 */
private String pass;






public virtual string DNI {
        get { return dNI; } set { dNI = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Direccion {
        get { return direccion; } set { direccion = value;  }
}



public virtual string Telefono {
        get { return telefono; } set { telefono = value;  }
}



public virtual System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN> Factura {
        get { return factura; } set { factura = value;  }
}



public virtual System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}





public ClienteEN()
{
        factura = new System.Collections.Generic.List<Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN>();
        reserva = new System.Collections.Generic.List<Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN>();
}



public ClienteEN(string dNI, string nombre, string direccion, string telefono, System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN> factura, System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN> reserva, String pass
                 )
{
        this.init (DNI, nombre, direccion, telefono, factura, reserva, pass);
}


public ClienteEN(ClienteEN cliente)
{
        this.init (DNI, cliente.Nombre, cliente.Direccion, cliente.Telefono, cliente.Factura, cliente.Reserva, cliente.Pass);
}

private void init (string DNI
                   , string nombre, string direccion, string telefono, System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN> factura, System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN> reserva, String pass)
{
        this.DNI = DNI;


        this.Nombre = nombre;

        this.Direccion = direccion;

        this.Telefono = telefono;

        this.Factura = factura;

        this.Reserva = reserva;

        this.Pass = pass;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ClienteEN t = obj as ClienteEN;
        if (t == null)
                return false;
        if (DNI.Equals (t.DNI))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.DNI.GetHashCode ();
        return hash;
}
}
}
