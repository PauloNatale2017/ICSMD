using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.EntitiModel
{
    public class ConfiguracaoChart
    {
        public string baseFontSize { get; set; }
        public string showBorder { get; set; }
        public string caption { get; set; }
        public string labelDistance { get; set; }
        public string subCaption { get; set; }
        public string numberPrefix { get; set; }
        public string startingAngle { get; set; }
        public string decimals { get; set; }
        public string enableMultiSlicing { get; set; }
        public string use3DLighting { get; set; }
        public string defaultCenterLabel { get; set; }
        public string pieRadius { get; set; }
        public string smartLineAlpha { get; set; }
        public string showLabels { get; set; }
        public string smartLineThickness { get; set; }
        public string showShadow { get; set; }
        public string captionFontSize { get; set; }
        public string subcaptionFontSize { get; set; }
        public string subcaptionFontBold { get; set; }
        public string centerLabelBold { get; set; }
        public string canvasBgColor { get; set; }
        public string baseFontColor { get; set; }
        public string bgColor { get; set; }
        public string doughnutRadius { get; set; }
        public string slicingDistance { get; set; }

        public string borderColor { get; set; }
        public string borderThickness { get; set; }
        public string borderAlpha { get; set; }

        public string theme { get; set; }
        public string exportEnabled { get; set; }

        public string showPlotBorder { get; set; }
        public string canvasbordercolor { get; set; }
    }
}
