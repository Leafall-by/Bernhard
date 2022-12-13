using System;

public class CameraNotFoundException : Exception 
{
    public CameraNotFoundException(string message) : base(message) {}
}
