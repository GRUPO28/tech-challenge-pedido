﻿namespace Pedidos.Common.Exceptions;

public abstract class NotificationException : Exception
{
    protected NotificationException(string message) : base(message)
    { }
}

