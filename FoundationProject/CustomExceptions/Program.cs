// See https://aka.ms/new-console-template for more information
namespace CustomExceptions;

[System.Serializable]
public class ProgramException : System.Exception
{
    public ProgramException() { }
    public ProgramException(string message) : base(message) { }
    public ProgramException(string message, System.Exception inner) : base(message, inner) { }
    protected ProgramException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

