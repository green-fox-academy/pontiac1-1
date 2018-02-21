var x = new int[] { 20, 100, 300, 320 };
            var y = new int[] { 100, 300, 30, 120 };
            var w = new int[] { 40, 55, 120, 80 };
            var h = new int[] { 10, 50, 100, 160 };
            var c = new string[] { "Green", "Blue", "Yellow", "Red" };

            for (int i = 0; i < 4; i++)
            {
                InitializeComponent();
                var rect = new FoxDraw(canvas);
                rect.StrokeColor(Colors.Red);
                rect.FillColor(Colors.Transparent);
                rect.DrawRectangle(x[i], y[i], w[i], h[i]);
            }
