using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication.Examples
{
    internal class ManuallyRaisingEventsWithExceptionHandling : Example
    {
        public class Pub
        {   
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                var exceptions = new List<Exception>();

                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
        }

        public override void Run()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Host.WriteLine("Subscriber 1 called");

            p.OnChange += (sender, e) => { throw new Exception(); };

            p.OnChange += (sender, e) => Host.WriteLine("Subscriber 3 called");

            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Host.WriteLine(ex.InnerExceptions.Count);
            }
        }
    }
}
