// State interface
using System;

public interface IState
{
    void Handle(Context context);
}

// Concrete state: "Ready"
public class ReadyState : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Vending machine is ready. Please insert coins.");
        context.State = new WaitingForPaymentState(); // Transition to the next state
    }
}

// Concrete state: "Waiting for Payment"
public class WaitingForPaymentState : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Machine is waiting for payment.");
        context.State = new DispensingState(); // Transition to the next state
    }
}

// Concrete state: "Dispensing"
public class DispensingState : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Machine is dispensing the drink.");
        context.State = new ErrorState(); // Transition to the next state
    }
}

// Concrete state: "Error"
public class ErrorState : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Error: Please contact maintenance.");
    }
}

// Context: Vending machine
public class Context
{
    public IState State { get; set; }

    public Context(IState state)
    {
        State = state;
    }

    public void Request()
    {
        State.Handle(this);
    }
}

// Main program
class Program
{
    static void Main()
    {
        Context context = new Context(new ReadyState());
        context.Request(); // Vending machine is ready
        context.Request(); // Waiting for payment
        context.Request(); // Dispensing the drink

    Console.ReadKey();
    }
}
