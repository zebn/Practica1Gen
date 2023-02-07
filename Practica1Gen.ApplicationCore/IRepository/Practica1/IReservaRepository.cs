
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;

namespace Practica1Gen.ApplicationCore.IRepository.Practica1
{
public partial interface IReservaRepository
{
ReservaEN ReadOIDDefault (int id
                          );

void ModifyDefault (ReservaEN reserva);

System.Collections.Generic.IList<ReservaEN> ReadAllDefault (int first, int size);



int CrearReserva (ReservaEN reserva);

void BorrarReserva (int id
                    );
}
}
