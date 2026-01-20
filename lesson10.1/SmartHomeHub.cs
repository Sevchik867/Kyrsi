using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10._1
{
    internal class SmartHomeHub
    {
        public event EventHandler<HubEvent> OnEvent;
        protected virtual void RaiseEvent(HubEvent e)
        {
            var handler = OnEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public void TriggerMotion(string where, int priority = 2)
        {
            var ev = new HubEvent(HubEventType.Motion, priority, $"Motion detected at {where}");
            Console.WriteLine($"Event: {ev}");
            RaiseEvent(ev);
        }

        public void TriggerFireAlarm(string location, int priority = 5)
        {
            var ev = new HubEvent(HubEventType.FireAlarm, priority, $"Fire alarm at {location}!");
            Console.WriteLine($"Event: {ev}");
            RaiseEvent(ev);
        }

        public void TriggerDoorOpened(string doorName, int priority = 2)
        {
            var ev = new HubEvent(HubEventType.DoorOpened, priority, $"{doorName} opened");
            Console.WriteLine($"Event: {ev}");
            RaiseEvent(ev);
        }

        public void TriggerTemperatureAlert(double tempCelsius, int priority = 3)
        {
            var ev = new HubEvent(HubEventType.TemperatureAlert, priority, $"Temperature {tempCelsius:F1}°C");
            Console.WriteLine($"Event: {ev}");
            RaiseEvent(ev);
        }
    }
}
