using Shapes.Shapes;

//Agile
//Fall Semester

//Shapes Part 1

//Author: Josh Kunz
//8/31/2020

//I left this project as a .NET Framework 4.5.2, and not the newer stuff so hopefully you don't have to download anything extra for grading this.

namespace Shapes
{
    //class auto generated for a console application, contains the Main method to start the program.
    public class Program
    {
        public static void Main()
        {
            //create a new instance of a cuboid, and pass it in the parameters for it's dimensions
            var cuboid = new Cuboid(10, 10, 10);

            //render the cuboid
            cuboid.render();

            //create a new cylinder and give it some dimensions
            var cylinder = new Cylinder(30, 10);

            //render the details of the cylinder
            cylinder.render();

            //create a sphere and pass in the radius
            var sphere = new Sphere(30);

            //render the sphere's details.
            sphere.render();
        }
    }
}
