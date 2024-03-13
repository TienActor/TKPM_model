using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDrawable
{
    internal class CsvExportVisitor:IShapeVisitor
    {

        private StringBuilder csv = new StringBuilder();

        public void Visit(RectangleShape rectangle)
        {
            // Add rectangle data to CSV
            csv.AppendLine(rectangle.SerializeAsCsv());
        }

        public string Export()
        {
            return csv.ToString();
        }
    }
}
