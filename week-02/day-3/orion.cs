InitializeComponent();
            var background = new FoxDraw(canvas);
            background.FillColor(Colors.Black);
            background.StrokeColor(Colors.Transparent);
            background.DrawRectangle(0, 0, Width, Height);

            Color[] colors = { Colors.Wheat, Colors.LightBlue, Colors.LightGoldenrodYellow, Colors.LightYellow };
            Random color = new Random();

            var orionHead = new FoxDraw(canvas);
            orionHead.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionHead.StrokeColor(Colors.White);
            orionHead.DrawEllipse(30, 0, 2, 2);

            var orionRightShoulder = new FoxDraw(canvas);
            orionRightShoulder.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionRightShoulder.StrokeColor(Colors.White);
            orionRightShoulder.DrawEllipse(0, 10, 3, 3);

            var orionLeftShoulder = new FoxDraw(canvas);
            orionLeftShoulder.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionLeftShoulder.StrokeColor(Colors.White);
            orionLeftShoulder.DrawEllipse(40, 18, 2, 2);

            var orionUppermost = new FoxDraw(canvas);
            orionUppermost.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionUppermost.StrokeColor(Colors.White);
            orionUppermost.DrawEllipse(0, 0, 2, 2);

            var orionBeltLeft = new FoxDraw(canvas);
            orionBeltLeft.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionBeltLeft.StrokeColor(Colors.White);
            orionBeltLeft.DrawEllipse(30, 45, 2, 2);

            var orionBeltMiddle = new FoxDraw(canvas);
            orionBeltMiddle.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionBeltMiddle.StrokeColor(Colors.White);
            orionBeltMiddle.DrawEllipse(25, 47, 3, 3);

            var orionBeltRight = new FoxDraw(canvas);
            orionBeltRight.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionBeltRight.StrokeColor(Colors.White);
            orionBeltRight.DrawEllipse(20, 49, 3, 3);

            var orionLeftLeg = new FoxDraw(canvas);
            orionLeftLeg.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionLeftLeg.StrokeColor(Colors.White);
            orionLeftLeg.DrawEllipse(46, 70, 2, 2);

            var orionRightLeg = new FoxDraw(canvas);
            orionRightLeg.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionRightLeg.StrokeColor(Colors.White);
            orionRightLeg.DrawEllipse(10, 76, 3, 3);

            var orionBowUppermost = new FoxDraw(canvas);
            orionBowUppermost.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionBowUppermost.StrokeColor(Colors.White);
            orionBowUppermost.DrawEllipse(70, 0, 2, 2);

            var orionTop = new FoxDraw(canvas);
            orionTop.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionTop.StrokeColor(Colors.White);
            orionTop.DrawEllipse(72, 8, 2, 2);

            var orionMiddle = new FoxDraw(canvas);
            orionMiddle.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionMiddle.StrokeColor(Colors.White);
            orionMiddle.DrawEllipse(73, 12, 2, 2);

            var orionBottom = new FoxDraw(canvas);
            orionBottom.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionBottom.StrokeColor(Colors.White);
            orionBottom.DrawEllipse(72, 16, 2, 2);

            var orionBottomM = new FoxDraw(canvas);
            orionBottomM.FillColor(colors[color.Next(0, colors.Length - 1)]);
            orionBottomM.StrokeColor(Colors.White);
            orionBottomM.DrawEllipse(70, 20, 3, 3);
