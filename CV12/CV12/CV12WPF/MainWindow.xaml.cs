using CV12;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http.Json;
namespace CV12WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly HttpClient _client;

        public MainWindow()
        {
            InitializeComponent();

            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7204/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal operand1 = decimal.Parse(Operand1TextBox.Text);
                decimal operand2 = decimal.Parse(Operand2TextBox.Text);

                ComboBoxItem selectedItem = (ComboBoxItem)OperationComboBox.SelectedItem;
                string operation = selectedItem.Tag.ToString();

                CalcDTO calcDTO = new CalcDTO
                {
                    Operand1 = operand1,
                    Operand2 = operand2,
                    Operation = operation
                };

                HttpResponseMessage response = await _client.PostAsJsonAsync("api/calc", calcDTO);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                ResultTextBlock.Text = result;
            }
            catch (Exception ex)
            {
                ResultTextBlock.Text = "Chyba: " + ex.Message;
            }
        }
    }
}