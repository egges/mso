using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

public class Parser
{
	public static List<Shape> ParseShapes(string Filename)
	{
		// Load xml documents
		XmlDocument doc = new XmlDocument();
		doc.Load(Filename);
		
		// Parse all shapes
		List<Shape> shapes = new List<Shape>();
		foreach(XmlNode shape in doc.SelectNodes("/shapes/*"))
		{
			string type = shape.Name;
			int x; int y; int width; int height;
			switch(type)
            {

                case "rectangle":
					x = int.Parse(shape.Attributes["x"].Value);
					y = int.Parse(shape.Attributes["y"].Value);
					width = int.Parse(shape.Attributes["width"].Value);
					height = int.Parse(shape.Attributes["height"].Value);
                    shapes.Add(new Rectangle(x, y, width, height));
                    break;
                case "circle":
					x = int.Parse(shape.Attributes["x"].Value);
					y = int.Parse(shape.Attributes["y"].Value);
					int size = int.Parse(shape.Attributes["size"].Value);
                    shapes.Add(new Circle(x, y, size));
                    break;
				case "star":
					x = int.Parse(shape.Attributes["x"].Value);
					y = int.Parse(shape.Attributes["y"].Value);
					width = int.Parse(shape.Attributes["width"].Value);
					height = int.Parse(shape.Attributes["height"].Value);
					shapes.Add (new Star(x,y,width,height));
					break;
            }
		}
		
		return shapes;
	}
}