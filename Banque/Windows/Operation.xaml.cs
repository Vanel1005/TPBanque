using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Banque.Windows
{
    /// <summary>
    /// Logique d'interaction pour Operation.xaml
    /// </summary>
    public partial class Operation : Window
    {
        public Operation()
        {
            InitializeComponent();
            //un text
            //un text //un champs pour rentrer des entiers
            //un bouton valider
            Label accountId = new Label();
            Label amountLabel = new Label();
            TextBox amountInput = new TextBox();
            Button valider = new Button();

            mainGrid.Children.Add(accountId);  
            mainGrid.Children.Add(amountLabel);  
            mainGrid.Children.Add(amountInput);  
            mainGrid.Children.Add(valider);

        }
    }
}
