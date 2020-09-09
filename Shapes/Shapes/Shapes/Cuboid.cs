using Shapes.Abstractions;
using System.Windows.Forms;

//Author: Josh Kunz
//8/31/2020

//Looks redundant but Shapes in this case is a project and a directory.
namespace Shapes.Shapes
{
    public class Cuboid : Shape
    {
        //constructor with dimensions
        public Cuboid(float width, float height, float depth)
        {
            //we are going to use the set methods for these so that it
            //can account for negative values.
            setWidth(width);
            setHeight(height);
            setDepth(depth);
        }

        #region Properties
        //properties defining the size of the shape, with private setters
        public float width { get; private set; }
        public float height { get; private set; }
        public float depth { get; private set; }
        #endregion

        #region Setters
        //These setters check if the incoming values are 0 or above, and if they are not it will set them to 0
        private void setWidth(float width) => this.width = width >= 0 ? width : 0;
        private void setHeight(float height) => this.height = height >= 0 ? height : 0;
        private void setDepth(float depth) => this.depth = depth >= 0 ? depth : 0;
        #endregion

        #region Overrides
        //overrides the abstract method from the shape class, returns the surface area of this cuboid.
        public override float surfaceArea()
        {
            //Since width, height, and depth can be different we need to create variables to get the different
            //formula surfaceArea = 2lw + 2lh + 2hw
            //we are multiplying the xy by 2 because there are two of each type of sides, it's to make sure we have every side accounted for.
            var topBottomArea = width * depth * 2;
            var sideAreaLeftRight = height * depth * 2;
            var sideAreaFrontBack = height * width * 2;

            return topBottomArea + sideAreaFrontBack + sideAreaLeftRight;
        }

        //overrides the abstract method from the shape class, returns the volume of this cuboid.
        public override float volume()
        {
            //formula for cuboid volume: volume = LWH
            return depth * width * height;
        }

        //overrides the abstract method from the shape class, this will show our alert to the user.
        public override void render()
        {
            //we are going to call a method to create our alert dialog
            MessageBox.Show($"Width:{width} Height:{height} Depth:{depth} Volume:{volume()} Surface Area:{surfaceArea()}", "Cuboid Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
