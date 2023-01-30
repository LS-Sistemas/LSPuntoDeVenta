using LSPuntoDeVenta.Views;
using System.Collections.ObjectModel;

namespace LSPuntoDeVenta;

public partial class MainPage : ContentPage
{
    int count = 0;
    private ObservableCollection<OrderInfo> orderInfo;

    public MainPage()
    {
        InitializeComponent();
        orderInfo = new ObservableCollection<OrderInfo>();
        dataGrid.ItemsSource = GenerateOrders();
    }

    public class OrderInfo
    {
        private string codigo;
        private string cantidad;
        private string artciulo;
        private string precioUnit;
        private string importe;

        public string Codigo
        {
            get { return codigo; }
            set { this.codigo = value; }
        }

        public string Cantidad
        {
            get { return cantidad; }
            set { this.cantidad = value; }
        }

        public string Articulo
        {
            get { return artciulo; }
            set { this.artciulo = value; }
        }

        public string PrecioUnit
        {
            get { return this.precioUnit; }
            set { this.precioUnit = value; }
        }

        public string Importe
        {
            get { return importe; }
            set { this.importe = value; }
        }

        public OrderInfo(string codigo, string cantidad, string articulo, string precioUnit, string importe)
        {
            this.Codigo = codigo;
            this.Cantidad = cantidad;
            this.Articulo = articulo;
            this.PrecioUnit = precioUnit;
            this.Importe = importe;
        }
    }

    public ObservableCollection<OrderInfo> OrderInfoCollection
    {
        get { return orderInfo; }
        set { this.orderInfo = value; }
    }



    public ObservableCollection<OrderInfo> GenerateOrders()
    {
        orderInfo.Add(new OrderInfo("1001", "2", "Coca Cola x 1L", "65", "2"));
        orderInfo.Add(new OrderInfo("1002", "4", "Mayoneas x 500g", "56", "25"));
        orderInfo.Add(new OrderInfo("1003", "3", "Sprite x 1L", "25", "21548"));
        orderInfo.Add(new OrderInfo("1004", "4", "Pepsi x 500ml", "120", "100659"));
        orderInfo.Add(new OrderInfo("1005", "26", "Salamin paladini x 250g", "130", "671"));
        orderInfo.Add(new OrderInfo("1006", "23", "Coca Cola x 1L", "130", "369."));
        orderInfo.Add(new OrderInfo("1007", "12", "Fanta x 1L", "130", "1589325"));
        orderInfo.Add(new OrderInfo("1008", "10", "Spain", "130", "520"));
        orderInfo.Add(new OrderInfo("1009", "4", "Pan x 500g", "452", "11780"));
        orderInfo.Add(new OrderInfo("1010", "5", "Papas lays x 250g", "9", "3215"));
        orderInfo.Add(new OrderInfo("1011", "65", "Leche entera x 1L", "7", "2560"));
        orderInfo.Add(new OrderInfo("1012", "205", "Trapo de piso", "110", "666"));
        orderInfo.Add(new OrderInfo("1013", "66", "Rexona x 300cc", "22", "534"));
        orderInfo.Add(new OrderInfo("1014", "89", "Manteca ilolay x 330g", "23", "34"));

        return orderInfo;

    }

    private void btnDatos_Clicked(object sender, EventArgs e)
    {
        var windows = new Window
        {
            Page = new Datos
            {
                HeightRequest = 200,
                WidthRequest = 200,
            }

        };


        Application.Current.OpenWindow(windows);

    }
}

