using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDrawable
{
    public interface IShapeVisitor
    {
        void Visit(Myrectangle rectangle);
        // Add methods for other shapes, like VisitCircle, VisitDot, etc.
    }



    public class RectangleShape : Shape
    {
        // Existing properties and methods

        public override void Accept(IShapeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
