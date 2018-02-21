var x = new int[] { 20, 100, 300};
            var y = new int[] { 20, 100, 300};


            for (int i = 0; i < 3; i++)
            {
                InitializeComponent();
                var rect = new FoxDraw(canvas);
                rect.StrokeColor(Colors.Red);
                rect.FillColor(Colors.Transparent);

                rect.DrawRectangle(300-(x[i]/2), 300-(y[i]/2), x[i], y[i]);
            }
