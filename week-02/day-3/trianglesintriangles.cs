for (int i = 0; i <= 300; i+=50)
{
    InitializeComponent();
    var x = new FoxDraw(canvas);
    var start = new Point(200+i, 600-i);
    var end = new Point(800-i, 600-i);
    x.StrokeColor(Colors.Black);
    x.FillColor(Colors.Black);
    x.DrawLine(start, end);
}

for (int j = 0; j < 300; j+=50)
{
    InitializeComponent();
    var y = new FoxDraw(canvas);
    var start2 = new Point(800-j, 600);
    var end2 = new Point(500-j, 300+j);
    y.StrokeColor(Colors.Black);
    y.FillColor(Colors.Black);
    y.DrawLine(start2, end2);

}


    InitializeComponent();
    var z = new FoxDraw(canvas);
    var start3 = new Point(200, 600);
    var end3 = new Point(Width / 2, 300);
    z.StrokeColor(Colors.Black);
    z.FillColor(Colors.Black);
    z.DrawLine(start3, end3);
