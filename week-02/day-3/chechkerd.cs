Color[] colores = { Colors.White, Colors.Black};
            //string[] rainbow = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", };
            //Color color = (Color)ColorConverter.ConvertFromString(rainbow[]);
            int[] size = new int[] { 100, 200, 300, 400, 500, 600, 700 };

            for (int i = 0; i <= 14; i++)
            {
                for (int j = 0; j <= 14; j++)
                {

                    InitializeComponent();
                    var rectie = new FoxDraw(canvas);
                    rectie.FillColor(colores[(i+j)%2]);
                    rectie.StrokeColor(colores[(i + j) % 2]);
                    rectie.DrawRectangle(j*50, i*50, 50, 50);
                }
            }
