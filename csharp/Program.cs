using System;

namespace csharp
{
    class Program
    {
        public struct customer
        {
            public int id;
            public String firstname;
            public String lastname;
            public CustomerStatus Status;
        }

        public enum CustomerStatus
        {
            New = 1,
	        AwaitingActivation = 2,
	        Activated = 3,
	        Deactivated = 4
        }
        static void Main(string[] args)
        {
            customer cust1 = new customer();
            cust1.id = 101;
            cust1.firstname = "Jon";
            cust1.lastname = "Wam";
            cust1.Status = CustomerStatus.New;
            
            Console.Write($"{cust1.id}: {cust1.firstname} {cust1.lastname}");
            Console.Write("\n");
            if(checkNewCust(cust1)) Console.Write($"{cust1.firstname} is a new customer");
        }

        static void Swap(ref int x, ref int y)
        {
            // swap values
            int temp = x;
            x = y;
            y = temp;
        }

        static bool checkNewCust(customer c)
        {
            if (c.Status == CustomerStatus.New) return true;
            return false;
        }
    }
}
