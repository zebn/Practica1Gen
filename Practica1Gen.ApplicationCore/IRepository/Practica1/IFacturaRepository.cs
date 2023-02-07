
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;

namespace Practica1Gen.ApplicationCore.IRepository.Practica1
{
public partial interface IFacturaRepository
{
FacturaEN ReadOIDDefault (int id
                          );

void ModifyDefault (FacturaEN factura);

System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size);



int CrearFactura (FacturaEN factura);



void Modficar (FacturaEN factura);


FacturaEN DanePorOID (int id
                      );


System.Collections.Generic.IList<FacturaEN> DameTODO (int first, int size);
}
}
