using Shapes.Abstractions;
using System;
using System.Windows.Forms;

//Author: Josh Kunz
//8/31/2020

namespace Shapes.Shapes
{
    //class definition for Sphere with the abstractions of the Shape class
    public class Sphere : Shape
    {
        //property for radius, with private setter
        public float radius { get; private set; }

        //Constructor with radius argument, calls the setter so that it can check for negative values.
        public Sphere(float radius)
        {
            //call setter to check for negative values.
            setRadius(radius);
        }

        //setter method for radius.
        //checks if value is negative
        //if it is negative it will set it to 0
        //otherwise sets it to the passed in value
        private void setRadius(float radius) => this.radius = radius >= 0 ? radius : 0;

        //returns the surface area of this sphere
        public override float surfaceArea()
        {
            //formula: 4 x PI x radius^2

            //store radius squared into a variable
            var radiusSquared = Math.Pow(radius, 2);

            //convert and return the formula as a float
            return (float)(4 * Math.PI * radiusSquared);
        }

        public override float volume()
        {
            //formula: 4/3 x PI x radius^3

            //store radius cubed in a variable
            var radiusCubed = Math.Pow(radius, 3);

            //since storing 4/3 rounds it down to 1 as an integer I will store it as a const 1.333333
            const float FOURTHIRDS = 1.333333f;

            //return and convert the formula into float
            return (float)(FOURTHIRDS * Math.PI * radiusCubed);
        }

        //method to display the details of the sphere
        public override void render()
        {
            //show the dialog window with the details
            MessageBox.Show($"Radius:{radius} Volume:{volume()} Surface Area:{surfaceArea()}", "Sphere Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
