using System.Reflection;

namespace Logging.DispatchProxy;

public class LoggingProxy<T> : System.Reflection.DispatchProxy
{
    private T Target { set; get; }

    public static T SetProxy<T>(T target) where T : class
    {
        var proxy = Create<T, LoggingProxy<T>>() as LoggingProxy<T>;
        proxy.Target = target;
        return proxy as T;
    }
    protected override object? Invoke(MethodInfo? targetMethod, object?[]? args)
    {
       Console.WriteLine("call proxy");
       return targetMethod.Invoke(Target, args);
    }
}