﻿namespace Pedidos.Common.Exceptions;

public class DomainNotificationException : NotificationException
{
    public DomainNotificationException(string message): base(message)
    {
        
    }
}
