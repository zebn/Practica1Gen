

using System;
using System.Collections.Generic;
using Practica1Gen.ApplicationCore.IRepository.Practica1;

namespace Practica1Gen.ApplicationCore.CP.Practica1
{
public abstract class GenericBasicCP
{
protected GenericSessionCP CPSession;
protected GenericUnitOfWorkRepository unitRepo;
protected GenericBasicCP (GenericSessionCP currentSession, GenericUnitOfWorkRepository unitRepo)
{
        this.CPSession = currentSession;
        this.unitRepo = unitRepo;
}
}
}

