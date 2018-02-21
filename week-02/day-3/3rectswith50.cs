var x = new int[] { 20, 100, 300};
            var y = new int[] { 100, 300, 30};


            for (int i = 0; i < 3; i++)
            {
                InitializeComponent();
                var rect = new FoxDraw(canvas);
                rect.StrokeColor(Colors.Red);
                rect.FillColor(Colors.Transparent);
                rect.DrawRectangle(x[i], y[i], 50, 50);
            }
