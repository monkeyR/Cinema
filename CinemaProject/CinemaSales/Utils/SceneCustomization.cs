using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CinemaSales.Utils
{
    class ScenesCustomization
    {
        private enum CustomizationType { Products = 1, Movies = 2, ProductsMovies = 3 }

        private bool productScenes;
        public bool HasProductsScenes
        {
            get { return productScenes; }
        }

        private bool moviesScenes;
        public bool HasMoviesScenes
        {
            get { return moviesScenes; }
        }

        /// throws Exception
        public ScenesCustomization()
        {
            initialize();
        }

        private void initialize()
        {
            CustomizationType type = GetSceneCustomizationTypeFromConfig();
            productScenes = HasProductsScenesMethod(type);
            moviesScenes = HasMoviesScenesMethod(type);
        }

        private bool HasProductsScenesMethod(CustomizationType type)
        {
            int valueType = (int)type;
            return ((valueType & (int)CustomizationType.Products) == (int)CustomizationType.Products);
        }

        private bool HasMoviesScenesMethod(CustomizationType type)
        {
            int valueType = (int)type;
            return ((valueType & (int)CustomizationType.Movies) == (int)CustomizationType.Movies);
        }

        // throws Exception
        private CustomizationType GetSceneCustomizationTypeFromConfig()
        {
            String scenes = ConfigurationManager.AppSettings["sceneType"];
            int sceneTypeValue = int.Parse(scenes);
            return (CustomizationType)sceneTypeValue;
        }
    }
}
