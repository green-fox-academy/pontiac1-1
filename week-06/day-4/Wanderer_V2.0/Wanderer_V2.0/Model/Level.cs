using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.IO;

namespace Wanderer_V2._0.Model
{
    public class Level
    {
        protected string wallUriPath;
        protected string lvlPath;
        protected string[] level;

        public Level(int lvl)
        {
            //read lvl.txt
            lvlPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\levels\level_"+lvl;
            level = File.ReadAllLines(lvlPath);

            //pull-in texture
            wallUriPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\box.jpg";
            var box = new Image();
            box.Source = new BitmapImage(new Uri(wallUriPath));
        }
    }
}
