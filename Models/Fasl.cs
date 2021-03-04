using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diwaan.Models
{
    public class Fasl
    {
        public int Id { get; set; }

        public string ArabicName { get; set; }
        public string Transliteration { get; set; }
        public List<Harf> Huruufs { get; set; }


        public Fasl()
        {
            this.Id = 1;
            ArabicName = "Arabic Name";
            Transliteration = "Trans";
            Huruufs = new List<Harf>
            {
                new Harf{Id = 1,Name = "Name 1", FaslId = 1,Abyaats = new List<Bait>
                {
                    new Bait{Id = 1,Text = "text 1",FaslId = 1,HarfId = 1},
                    new Bait{Id = 2,Text = "text 2",FaslId = 1,HarfId = 1},
                }
                },
                new Harf{Id = 2,Name = "Name 2", FaslId = 1,Abyaats = new List<Bait>
                {
                    new Bait{Id = 1,Text = "text 1",FaslId = 1,HarfId = 2},
                    new Bait{Id = 2,Text = "text 2",FaslId = 1,HarfId = 2},
                }
                },
                 new Harf{Id = 3,Name = "Name 3", FaslId = 1,Abyaats = new List<Bait>
                {
                    new Bait{Id = 1,Text = "text 1",FaslId = 1,HarfId = 3},
                    new Bait{Id = 2,Text = "text 2",FaslId = 1,HarfId = 3},
                }
                }


            };

        }

        public Fasl(int id)
        {
            this.Id = 1;
            ArabicName = "Arabic Name";
            Transliteration = "Trans";
            Huruufs = new List<Harf>
            {
                new Harf{Id = 1,Name = "Name 1", FaslId = 1,Abyaats = new List<Bait>
                {
                    new Bait{Id = 1,Text = "text 1",FaslId = 1,HarfId = 1},
                    new Bait{Id = 2,Text = "text 2",FaslId = 1,HarfId = 1},
                }
                },
                new Harf{Id = 2,Name = "Name 2", FaslId = 1,Abyaats = new List<Bait>
                {
                    new Bait{Id = 1,Text = "text 1",FaslId = 1,HarfId = 2},
                    new Bait{Id = 2,Text = "text 2",FaslId = 1,HarfId = 2},
                }
                },
                 new Harf{Id = 3,Name = "Name 3", FaslId = 1,Abyaats = new List<Bait>
                {
                    new Bait{Id = 1,Text = "text 1",FaslId = 1,HarfId = 3},
                    new Bait{Id = 2,Text = "text 2",FaslId = 1,HarfId = 3},
                }
                }


            };

        }
    }
}
