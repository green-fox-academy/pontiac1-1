var diagred = new FoxDraw(canvas);
diagred.StrokeColor(Colors.Green);
var start = new Point(0, 0);
var end = new Point(600, 600);
diagred.DrawLine(start, end);

var diagred2 = new FoxDraw(canvas);
diagred.StrokeColor(Colors.Red);
var start2 = new Point(600, 0);
var end2 = new Point(0, 600);
diagred.DrawLine(start2, end2);
