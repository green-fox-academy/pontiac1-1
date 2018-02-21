int[] x = new int[] { 10, 20, 30 };
int[] y = new int[] { 30, 5, 100 };
for (int i = 0; i < 3; i++)
{
    InitializeComponent();
    var custom = new FoxDraw(canvas);
    custom.StrokeColor(Colors.Red);
    var start = new Point(x[i], y[i]);
    var end = new Point(300, 300);
    custom.DrawLine(start, end);
}


int[] a = new int[] { 10, 20, 30 };
int[] b = new int[] { 30, 5, 100 };
for (int j = 0; j < 3; j++)
{
    InitializeComponent();
    var custom = new FoxDraw(canvas);
    custom.StrokeColor(Colors.Blue);
    var start = new Point(a[j], b[j]);
    var end = new Point(a[j]+50, b[j]);
    custom.DrawLine(start, end);
}





var square = new FoxDraw(canvas);
square.StrokeColor(Colors.Green);
var topright = new Point(295, 295);
var topleft = new Point(305, 295);
var bottomright = new Point(295, 305);
var bottomleft = new Point(305, 305);
square.DrawRectangle(295, 295, 10, 10);
