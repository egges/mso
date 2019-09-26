using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Star : Shape
{

	private int x;
	private int y;
	private int width;
	private int height;

	public Star (int x, int y, int width, int height)
	{
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
	}

	public override void Draw (Graphics Canvas)
	{
		Pen pen = new Pen (Color.Black);

		int numPoints = 5;
		Point[] pts = new Point[numPoints];
		double rx = width / 2;
		double ry = height / 2;
		double cx = x + rx;
		double cy = y + ry;

		double theta = -Math.PI / 2;
		double dtheta = 4 * Math.PI / numPoints;
		int i;
		for (i = 0; i < numPoints; i++) 
		{
			pts [i] = new Point (
				Convert.ToInt32(cx + rx * Math.Cos (theta)),
				Convert.ToInt32(cy + ry * Math.Sin (theta)));
			theta += dtheta;
		}

		for (i = 0; i < numPoints; i++) 
		{
			Canvas.DrawLine(pen,pts[i].X,
                                pts[i].Y,
                                pts[(i+1) % numPoints].X,
                                pts[(i+1) % numPoints].Y);
		}
		
	}
}


