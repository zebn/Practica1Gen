

using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1Gen.ApplicationCore.CP.Practica1
{
public abstract class GenericSessionCP
{
public GenericSessionCP (object currentSession)
{
        this.CurrentSession = currentSession;
}

public GenericSessionCP()
{
}

public object CurrentSession {
        set; get;
}

public abstract void SessionInitializeTransaction ();

public abstract void Commit ();

public abstract void RollBack ();

public abstract void SessionClose ();
}
}

