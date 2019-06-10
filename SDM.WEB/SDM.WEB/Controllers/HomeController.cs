using Domain.Entities.EntitiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using FusionCharts;
using FusionCharts.Charts;

namespace SDM.WEB.Controllers
{
    public class HomeController : Controller
    {

        private readonly Domain.Core.Repository.CadastroRepository _cadastrar = new Domain.Core.Repository.CadastroRepository();

        public ActionResult Index()
        {
           
            //SERVICE.Atumatizations.Importa _import = new SERVICE.Atumatizations.Importa();
            //List<Cadastro> entityList = _import.ImportExcel("");
            //foreach (var item in entityList){
            //    _cadastrar.Add(item); 
            //} 

         

            //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(stringr);
            //var result = System.Convert.ToBase64String(plainTextBytes);

            //IdentificacaoCreateChart();

            ViewBag.Title = "Home Page";
            return View();
        }

        #region FusionChart

        public string IdentificacaoCreateChart()
        {
            var jsonSerialiser = new JavaScriptSerializer();
            List<DadosGraficos> list = new List<DadosGraficos>();

            int totaisIdentificacao = 50;

            int TOTAIS_CONFORM = 150;
            int TOTAIS_NAOCONFORME = 13;
            int TOTAIS_OBSERVACAO = 35;



            list.Add(new DadosGraficos
            {
                label = "",
                displayValue = "35",
                value = "150",
                labelFontSize = "15",
                labelFontBold = "1",
                labelBorderPadding = "0 0 0 0",
                color = "#AFD249"
            });

            list.Add(new DadosGraficos
            {
                label = "",
                displayValue = "13",
                value = "13",
                labelFontSize = "15",
                labelFontBold = "1",
                labelBorderPadding = "0 0 0 0",
                color = "#FDB813"
            });

            list.Add(new DadosGraficos
            {
                label = "",
                displayValue = "35",
                value = "35",
                labelFontSize = "15",
                labelFontBold = "1",
                labelBorderPadding = "0 0 0 0",
                color = "#ED1C24"
            });


            string data = jsonSerialiser.Serialize(list);
            ConfiguracaoChart Configuracao = new ConfiguracaoChart()
            {
                baseFontSize = "19",
                showBorder = "0",
                caption = "",
                labelDistance = "35",
                subCaption = "",
                numberPrefix = "",
                startingAngle = "90",
                decimals = "0",
                enableMultiSlicing = "0",
                use3DLighting = "0",
                defaultCenterLabel = "",
                pieRadius = "110",
                smartLineAlpha = "100",
                showLabels = "1",
                smartLineThickness = "1",
                showShadow = "0",
                captionFontSize = "14",
                subcaptionFontSize = "0",
                subcaptionFontBold = "0",
                centerLabelBold = "4",
                canvasBgColor = "#FFFFFF",
                canvasbordercolor = "#FFFFFF",
                baseFontColor = "#000000",
                bgColor = "#FFFFFF",
                doughnutRadius = "80",
                slicingDistance = "0",
                borderColor = "#FFFFFF",
                borderThickness = "0",
                borderAlpha = "0",
                theme = "",
                exportEnabled = "0",
                showPlotBorder = "0"
            };
            string Config = jsonSerialiser.Serialize(Configuracao);
            string Chart = "{chart:" + Config + ",data:" + data + "}";

            TipoGraficos Charts = new TipoGraficos()
            {
                chartType = "doughnut2d",
                chartId = "Identificacao",
                chartWidth = "300",
                chartHeight = "292",
                renderAt = null,
                bgColor = "#00000000",
                bgOpacity = null,
                dataFormat = "json",
                dataSource = null
            };
            Chart dataIdentificacao = new Chart(Charts.chartType, Charts.chartId, Charts.chartWidth, Charts.chartHeight, Charts.dataFormat, Chart);
            var stringr = dataIdentificacao.Render().ToString();
            return dataIdentificacao.Render();
        }

        #endregion


        public ActionResult VisualizarRegistros()
        {
            List<Cadastro> model = _cadastrar.GetAll().ToList<Cadastro>();
            return View(model);
        }
    }
}
