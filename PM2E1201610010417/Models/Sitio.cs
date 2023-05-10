using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM2E1201610010417.Models
{
    internal class Sitio
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string desc { get; set; }
        public string descorta { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public byte[] save_image { get; set; }

        public override string ToString()
        {
            return this.desc + " | " + this.descorta +" | " + this.latitud + " " + this.longitud + " " + save_image;
        }
    }
}
