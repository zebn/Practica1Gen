
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;

namespace Practica1Gen.ApplicationCore.IRepository.Practica1
{
public partial interface ICocheRepository
{
CocheEN ReadOIDDefault (int numLicencia
                        );

void ModifyDefault (CocheEN coche);

System.Collections.Generic.IList<CocheEN> ReadAllDefault (int first, int size);



int CrearCoche (CocheEN coche);

void BorrarCoche (int numLicencia
                  );






void Modificar (CocheEN coche);


CocheEN DamePorOID (int numLicencia
                    );


System.Collections.Generic.IList<CocheEN> DameTodos (int first, int size);
}
}
