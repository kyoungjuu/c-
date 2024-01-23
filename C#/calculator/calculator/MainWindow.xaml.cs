using System.Data;
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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double savedValue;   // 연산자 버튼을 누를 때 현재 txtResult에 있는 값을 저장하는 필드
        private char myOperator;    // 현재 계산할 연산자를 저장하는 char형 변수
        public MainWindow()
        {
            InitializeComponent();
            txtResult.Text = "0";
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string number = btn.Content.ToString();
            // 지금 0이거나 새로시작했을경우 값을 바로 적어줌.
            if (txtResult.Text == "0" )
            {
                txtResult.Text = number;
                
            }
            else // 그렇지 않을경우 숫자를 뒤에 계속 붙임 -> char기때문에 가능
            {
                txtResult.Text = txtResult.Text + number;
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + "+";
        }
        private void minus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + "-";
        }
        private void result_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            var v = dt.Compute(txtResult.Text,"");
            txtResult.Text = v.ToString();
        }
    }
}