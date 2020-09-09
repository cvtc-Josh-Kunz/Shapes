using Shapes.Abstractions;
using System;
using System.Windows.Forms;

//Author: Josh Kunz
//8/31/2020

namespace Shapes.Shapes
{
    //class definition using the Shape's abstractions
    public class Cylinder : Shape
    {
        //Doing it like this bypasses the need for a getter method, keeping the setter private but allowing access to read the value.
        public float radius { get; private set; }
        public float height { get; private set; }

        //constructor taking in the radius and height values and assigning them using
        //our setter methods which checks for negative values.
        public Cylinder(float radius, float height)
        {
            //call the set methods
            setHeight(height);
            setRadius(radius);
        }

        #region Setters
        //Setters for checking negative values, and if they are below 0, it will assign it 0
        private void setRadius(float radius) => this.radius = radius >= 0 ? radius : 0;
        private void setHeight(float height) => this.height = height >= 0 ? height : 0;
        #endregion

        public override float surfaceArea()
        {
            //get the top and bottom surface area
            var topBottomArea = Math.PI * Math.Pow(radius, 2) * 2;

            //now get the lateral surface area
            var lateralArea = 2 * Math.PI * radius * height;

            //return the surface area as float
            return (float)(topBottomArea + lateralArea);
        }

        //method for getting the volume of the cylinder
        public override float volume()
        {
            //formula = pi * radius^2 * height

            //store the radius squared in a variable
            var radiusSquared = Math.Pow(radius, 2);

            //return the volume as float
            return (float)(Math.PI * radiusSquared * height);
        }

        //renders the dialog with the details of the cylinder
        public override void render()
        {
            MessageBox.Show($"Height:{height} Volume:{volume()} Surface Area:{surfaceArea()}", "Cylinder Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
