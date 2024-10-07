using Microcharts;
using SkiaSharp;

namespace graficosMicrocharts
{
    public partial class MainPage : ContentPage
    {
        ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                Label = "Windows",
                ValueLabel = "112",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(248)
            {
                Label = "Android",
                ValueLabel = "648",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(128)
            {
               
                Label = "iOS",
                ValueLabel = "428",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label = ".NET MAUI",
                ValueLabel = "214",
                Color = SKColor.Parse("#3498db")
            }
        };

        ChartEntry[] generos = new[]
        {
    new ChartEntry(45)
    {
        Label = "Matematicas",
        Color = SKColor.Parse("#ffcc00") // Amarillo dorado
    },
    new ChartEntry(25)
    {
        Label = "Español",
        Color = SKColor.Parse("#8b0000") // Rojo oscuro
    },
    new ChartEntry(55)
    {
        Label = "Ciencias",
        Color = SKColor.Parse("#00bfff") // Azul profundo
    },
    new ChartEntry(30)
    {
        Label = "Valores",
        Color = SKColor.Parse("#ff69b4") // Rosa caliente
    },
    new ChartEntry(65)
    {
        Label = "Fisica",
        Color = SKColor.Parse("#228b22") // Verde bosque
    }
};


        public MainPage()
        {
            InitializeComponent();

            chartView.Chart = new BarChart
            {
                Entries = entries
            };

            chartView1.Chart = new LineChart
            {
                Entries = entries
            };
            chartView2.Chart = new PieChart
            {
                Entries = generos
            };
        }
    }

}
