Color[][] colors = {
                new Color[]{ Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet },
                new Color[]{ Colors.Violet, Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo },
                new Color[]{ Colors.Indigo, Colors.Violet, Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue },
                new Color[]{ Colors.Blue, Colors.Indigo, Colors.Violet, Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green },
                new Color[]{ Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet, Colors.Red, Colors.Orange, Colors.Yellow },
                new Color[]{ Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet, Colors.Red, Colors.Orange },
                new Color[]{ Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet, Colors.Red }
            };
            Color[] colores = { Colors.Red, Colors.Orange, Colors.Yellow, Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };
            //string[] rainbow = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", };
            //Color color = (Color)ColorConverter.ConvertFromString(rainbow[]);
            int[] size = new int[] { 100, 200, 300, 400, 500, 600, 700 };

            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {

                    InitializeComponent();
                    var rectie = new FoxDraw(canvas);
                    rectie.FillColor(colores[(i+j)%7]);
                    rectie.StrokeColor(colores[(i + j) % 7]);
                    rectie.DrawRectangle(j*100, i*100, 100, 100);
