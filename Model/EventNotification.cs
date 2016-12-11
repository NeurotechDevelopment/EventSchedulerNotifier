using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Represents notification for a given event.
    /// </summary>
    public class EventNotification
    {
        /// <summary>
        /// Event to which this notification is bound.
        /// Cannot be null.
        /// </summary>
        public EventData Event { get; set; }

        /// <summary>
        /// Date and time when notification should first triggered.
        /// </summary>
        public DateTime StartAt { get; set; }

        /// <summary>
        /// Number of times notification should be repeated.
        /// 0 means infinite times.
        /// </summary>
        public uint Repeats { get; set; }

        /// <summary>
        /// Interval between repeated notifications.
        /// </summary>
        public TimeSpan Frequency { get; set; }

        /// <summary>
        /// A collection of notifiers to bring user attention.
        /// Must be greater than 0.
        /// </summary>
        public IEnumerable<IEventNotifier> Notifiers { get; set; }
    }
}
