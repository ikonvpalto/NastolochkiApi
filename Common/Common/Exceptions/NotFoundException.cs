﻿using System.Net;

namespace Kvpbldsck.NastolochkiAPI.Common.Contract.Exceptions;

public sealed class NotFoundException : BaseHttpException
{
    public NotFoundException(string message)
        : base(message, HttpStatusCode.NotFound)
    {
    }

    public NotFoundException(string message, Exception innerException)
        : base(message, innerException, HttpStatusCode.NotFound)
    {
    }
}
