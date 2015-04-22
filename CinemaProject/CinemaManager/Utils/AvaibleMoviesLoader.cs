using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManager.Utils
{
    public class AvaibleMoviesLoader
    {
        public List<CinemaModel.Movies> load()
        {
            using (CinemaModel.CinemaDatabaseEntities ctx = new CinemaModel.CinemaDatabaseEntities())
            {
                var movies =
                    (from m in ctx.Movies
                     orderby m.movieID descending
                     select m
                    );

                return movies.ToList();
            }
        }
    }
}
