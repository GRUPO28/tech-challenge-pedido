﻿namespace Pedidos.Common.Exceptions;

public class ApplicationNotificationException : NotificationException
{
    public ApplicationNotificationException(string message) : base(message)
    {
        
    }
}
