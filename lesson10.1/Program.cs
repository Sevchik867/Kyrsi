namespace lesson10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hub = new SmartHomeHub();

            hub.TriggerMotion("Front Door", priority: 2);
            Console.WriteLine();
            hub.TriggerDoorOpened("Back Door", priority: 3);
            Console.WriteLine();
            hub.TriggerTemperatureAlert(30.5, priority: 3);
            Console.WriteLine();
            hub.TriggerFireAlarm("Kitchen", priority: 5);
            Console.WriteLine();
        }
    }
}
