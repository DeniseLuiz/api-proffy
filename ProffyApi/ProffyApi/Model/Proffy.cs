using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProffyApi.Model
{
    public class Proffy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public int Whatsapp { get; set; }
        public string Biografy { get; set; }
        public string Subject { get; set; }
        public double Cost { get; set; }
        public int Weekday { get; set; }
        public int TimeFrom { get; set; }
        public int TimeTo { get; set; }
    }
}
