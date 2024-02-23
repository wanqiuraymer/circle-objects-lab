using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjectLab
{
    internal class Circle
    {
        private double radius;
        public  double Radius {  get; set; }
        public Circle(double radius) 
        { 
            this.Radius = radius;
        }
        public double CalculateDiameter() 
        {
            double diameter = Radius * 2;
            return diameter; 
        }
        public double CalculateCircumference() 
        {  
            double circumference = 2*Math.PI*Radius;
            return circumference; 
        }
        public double CalculateArea() 
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area; 
        }
        public void Grow() 
        {
            Radius = Radius * 2; 
        }
        public double GetRadius() 
        { 
            
            return Radius; 
        }
    }
}
