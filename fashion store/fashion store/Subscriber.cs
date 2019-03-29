using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashion_store
{
    public class Subscriber<T>
    {
        public IPublisher<T> Publisher { get; private set; }

        // Subscriber pass instance of particular type publisher to capture message publisher by that Publisher
        public Subscriber(IPublisher<T> publisher)
        {
            Publisher = publisher;
        }
    }

}
