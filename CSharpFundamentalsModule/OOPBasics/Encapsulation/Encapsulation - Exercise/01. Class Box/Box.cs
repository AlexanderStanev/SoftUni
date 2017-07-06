using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length
    {
        get { return length; }
        private set
        {
            if (value > 0)
            {
                length = value;
            }

            else
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
        }
    }

    public double Width
    {
        get { return width; }
        private set
        {
            if (value > 0)
            {
                width = value;
            }

            else
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
        }
    }

    public double Height
    {
        get { return height; }
        private set
        {
            if (value > 0)
            {
                height = value;
            }

            else
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
        }
    }

    public double CalculateSurfaceArea()
    {
        return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
    }

    public double CalculateLateralSurfaceArea()
    {
        return 2 * (this.Length * this.Height + this.Width * this.Height);
    }

    public double CalculateVolume()
    {
        return this.Length * this.Width * this.Height;
    }
}
