using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Circle : Shape
{

    private int x;
	private int y;
	private int size;

    public Circle(int x, int y, int size)
    {
		this.x = x;
		this.y = y;
		this.size = size;
    }

    public override void Draw(Graphics Canvas)
    {
		Pen pen = new Pen(Color.Black);
        Canvas.DrawEllipse(pen, this.x, this.y, this.size, this.size);
    }

}
