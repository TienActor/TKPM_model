using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDrawable
{
    public class JsonExportVisitor :IShapeVisitor
    {
        private List<Shape> shapes = new List<Shape>();

        public void Visit(RectangleShape rectangle)
        {
            // Add rectangle to the list or perform JSON serialization
            shapes.Add(rectangle);
        }

        public string Export()
        {
            return JsonConvert.SerializeObject(shapes); // cai đặt newtonsoft.json
        }
    }
}
