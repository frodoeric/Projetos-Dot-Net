using System.Diagnostics;

namespace PerformanceCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!PerformanceCounterCategory.Exists("FourthCoffeeOrders"))
            {
                var counters = new CounterCreationDataCollection();
                var totalOrders = new CounterCreationData();
                totalOrders.CounterName = "# Orders";
                totalOrders.CounterHelp = "Total number of orders placed";
                totalOrders.CounterType = PerformanceCounterType.NumberOfItems32;
                counters.Add(totalOrders);
                var ordersPerSecond = new CounterCreationData();
                ordersPerSecond.CounterName = "# Orders/Sec";
                ordersPerSecond.CounterHelp = "Number of orders placed per second";
                ordersPerSecond.CounterType = PerformanceCounterType.RateOfCountsPerSecond32;
                counters.Add(ordersPerSecond);
                PerformanceCounterCategory.Create("FourthCoffeeOrders", "A custom category for demonstration",
                PerformanceCounterCategoryType.SingleInstance, counters);
            }

            OrderCoffee();
        }

        public static void OrderCoffee()
        {
            // Get a reference to the custom performance counters.
            var counterOrders = new PerformanceCounter("FourthCoffeeOrders", "# Orders", false);
            var counterOrdersPerSec = new PerformanceCounter("FourthCoffeeOrders", "# Orders/Sec", false);
            
            // Update the performance counter values at appropriate points in your code.
            for (int i = 0; i < 100000000; i++)
            {
                counterOrders.Increment();
                counterOrdersPerSec.Increment();
            }

        }
    }
}
