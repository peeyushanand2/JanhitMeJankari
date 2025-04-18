using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.C_Concepts;

public record Adress(string Name, int MobileNo, float Salary);
public sealed class Singleton
{
    //
    //Eager Initialization Singleton
    //The Singleton instance is created at the time the class is loaded, even if the instance is never used.
    // private static readonly Singleton _instance = new Singleton();

    ///Lazy Initialization Singleton (Thread-Safe)
    /////This method is ideal when you want to delay the creation of the Singleton until it is actually needed, which can save resources if the instance is never used.
    // private static readonly Lazy<Singleton> singleton1=new Lazy<Singleton>(() => new Singleton());

    //Thread-Safe Singleton with Double-Check Locking
    // This method ensures that the Singleton instance is created lazily and that multiple threads do not create multiple instances simultaneously.
    // It uses a lock statement to synchronize the creation of the instance.
    private static Singleton instance = null;
    private static readonly object _lock = new object();
    private Singleton()
    {
    }
    public static Singleton GetSingleton()
    {
        if (instance == null)
        {
            lock (_lock)
            {
                if (instance == null) 
                {
                   
                   return instance =new Singleton();
                }
            }
        }
        //Lazy
        // return singleton1.Value;
        return instance;
    }
    public void Log()
    {
        Console.WriteLine("Logging here ");
    }
}

