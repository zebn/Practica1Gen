
using System;
using System.Text;
using System.Collections.Generic;
using Practica1Gen.ApplicationCore.Exceptions;
using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;
using Practica1Gen.ApplicationCore.CEN.Practica1;



namespace Practica1Gen.ApplicationCore.CP.Practica1
{
public partial class ReservaCP : GenericBasicCP
{
public ReservaCP(GenericSessionCP currentSession, GenericUnitOfWorkRepository unitRepo)
        : base (currentSession, unitRepo)
{
}
}
}
