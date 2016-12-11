using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Represents data about event.
    /// </summary>
    public class EventData
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }
    }
}
