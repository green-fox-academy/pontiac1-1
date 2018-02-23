InitializeComponent();
            var background = new FoxDraw(canvas);
            background.FillColor(Colors.Black);
            background.DrawRectangle(0, 0, 700, 700);


            Random generalrandom = new Random();
            double numofstars = generalrandom.Next(180, 300);

            for (int i = 0; i <= numofstars; i++)
            {
                InitializeComponent();

                double sizex = generalrandom.Next(1, 3);
                double sizey = sizex;
                double posx = generalrandom.Next(0, 700);
                double posy = generalrandom.Next(0, 700);
                Color[] starcolors = { Colors.Wheat, Colors.LightBlue, Colors.LightGoldenrodYellow, Colors.LightYellow };
                var star = new FoxDraw(canvas);
                star.FillColor(starcolors[generalrandom.Next(0, starcolors.Length-1)]);
                star.StrokeColor(Colors.White);
                star.DrawEllipse(posx, posy, sizex, sizey);
            }
