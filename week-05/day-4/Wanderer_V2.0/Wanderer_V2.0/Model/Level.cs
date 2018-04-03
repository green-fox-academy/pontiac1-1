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
        public string uripath;
        //public int lvl;
        protected string lvlPath;
        public string levelContent;

        public Level(int lvl = 1)
        {
            //read lvl.txt
            lvlPath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\levels\level_"+lvl+".txt";
            levelContent = File.ReadAllText(lvlPath);

            uripath = @"C:\Users\Test\Documents\fox\greenfox\pontiac1-1\week-06\day-4\Wanderer_V2.0\Wanderer_V2.0\Assets\box.png";
        }
    }
}
