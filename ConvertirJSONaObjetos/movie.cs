using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirJSONaObjetos
{
    class movie
    {
        private string name;
        private DateTime releaseDate;
        private string[] genres;

        public string Name { get => name; set => name = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string[] Genres { get => genres; set => genres = value; }
    }
}
