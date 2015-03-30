using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Common
{
    public class ResourcesApp
    {
        private static string path = "Images";
        public static Bitmap GetImg(string name, bool returnNull = false, string type = ".png")
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                ResourcesApp.SetPath(Common.ResourcesApp.SolutionPath() + "/Images");
            }


            string Path = @ResourcesApp.path + "/" + name + type;
            if (File.Exists(Path))
            {
                return (new Bitmap(@ResourcesApp.path + "/" + name + type));
            }
            else
            {
                if (returnNull) return null;
                else
                {
                    if (File.Exists(@ResourcesApp.path + "/default.png"))
                    {
                        return (new Bitmap(@ResourcesApp.path + "/default.png"));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public static String SolutionPath()
        {
            return Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        }

        public static void SetPath(string path)
        {
            ResourcesApp.path = path;
        }
    }
}
