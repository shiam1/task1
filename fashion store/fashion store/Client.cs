using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashion_store
{
    public class Client
    {
        private readonly IPublisher<string> shoesPublisher;
        private readonly IPublisher<string> makeUpPublisher;
        private readonly Subscriber<string> shoesSub;
        private readonly Subscriber<string> makeUpSub;

        public Client()
        {
            shoesPublisher = new Publisher<string>();
            makeUpPublisher = new Publisher<string>();

            Console.WriteLine("There is our customer's type and the notifications corresponding ");



            
            makeUpSub = new Subscriber<string>(makeUpPublisher);
            makeUpSub.Publisher.DataPublisher += publisher_DataPublisher1;

            

            shoesSub = new Subscriber<string>(shoesPublisher);
            shoesSub.Publisher.DataPublisher += publisher_DataPublisher2;

            shoesPublisher.PublishData("Hi , there is anew offer on our fashion products ");
            makeUpPublisher.PublishData("we add anew product in our make up store , take a look ");
        }

        

        public  void publisher_DataPublisher1(object sender, MessageArgument<string> e)
        {
            Console.WriteLine("make up interested in :");
            Console.WriteLine(e.Message);
        }


        void publisher_DataPublisher2(object sender, MessageArgument<string> e)
        {
            Console.WriteLine("shoes interested in :");
            Console.WriteLine(e.Message);
        }
    }
}
