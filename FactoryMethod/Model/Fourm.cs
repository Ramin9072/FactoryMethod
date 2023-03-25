using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Model
{
    public class Fourm
    {
        public Topic OpenTopic(long id,string title)
        {
            if (IsClosed) throw new Exception($"Fourm {Title} closed !!!");
            return new Topic(title, id, this.Id ) ;// Save on Db
        }

        public long Id { get; set; }
        public bool IsClosed { get; set; }
        public string Title { get; set; }

    }

    public class Topic 
    {
        internal Topic(string title, long ownerId , long fourmId)
        {
            Title = title;
            OwnerId = ownerId;
            FourmnId = fourmId;
        }

        public string Title { get; set; }
        public long OwnerId { get; set; }
        public long FourmnId { get; set; }
    }
}
