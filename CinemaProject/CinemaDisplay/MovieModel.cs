using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDisplay
{
    class MovieModel
    {
        private int id;
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }   

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public MovieModel(String title, int id)
        {
            this.title = title;
            this.id = id;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            MovieModel p = obj as MovieModel;
            if ((System.Object)p == null)
            {
                return false;
            }
            return compare(this, p);
        }

        public bool Equals(MovieModel p)
        {
            if ((object)p == null)
            {
                return false;
            }

            return compare(this, p);
        }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }

        private static Boolean compare(MovieModel first, MovieModel second)
        {
            return (first.id == second.id);
        }
    }
}
