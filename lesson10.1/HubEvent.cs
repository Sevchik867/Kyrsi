using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10._1
{
    public enum HubEventType
    {
        Motion,
        FireAlarm,
        DoorOpened,
        TemperatureAlert,
        Custom
    }
    class HubEvent
    {
        public HubEventType EventType { get; }
        public DateTime Timestamp { get; }
        public int Priority { get; } // 1..5
        public string Message { get; }

        public HubEvent(HubEventType eventType, int priority, string message = null)
        {
            if (priority < 1 || priority > 5) throw new ArgumentOutOfRangeException(nameof(priority), "Priority must be between 1 and 5.");
            EventType = eventType;
            Priority = priority;
            Message = message ?? string.Empty;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Timestamp:yyyy-MM-dd HH:mm:ss}] Type={EventType}, Priority={Priority}, Message=\"{Message}\"";
        }
    }
}
