using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiModel
{
    public class TipoGraficos
    {
        public string chartType { get; set; }
        public string chartId { get; set; }
        public string chartWidth { get; set; }
        public string chartHeight { get; set; }
        public string dataFormat { get; set; }
        public string dataSource { get; set; }
        public string renderAt { get; set; }
        public string bgColor { get; set; }
        public string bgOpacity { get; set; }
    }
}
