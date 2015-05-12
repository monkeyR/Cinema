using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Common
{
    public class ShowModel
    {
        private static int maxTitleLength = 18;
        private static String movieDateFormat = "HH:mm";
        public CinemaModel.Halls hall;
        public CinemaModel.Shows show;
        public String movieTitle;

        public override string ToString()
        {
            String toBeReturned = StringUtils.getTrunctedTextWithEllipsis(movieTitle, maxTitleLength);
            toBeReturned += Environment.NewLine;
            toBeReturned += show.dateStart.ToString(movieDateFormat);
            toBeReturned += " - ";
            toBeReturned += show.dateEnd.ToString(movieDateFormat);
            return toBeReturned;
        }
    }
}
