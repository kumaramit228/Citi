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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Questionnaire
{
    /// <summary>
    /// Interaction logic for AssetDetails.xaml
    /// </summary>
    public partial class AssetDetails : UserControl
    {
        public AssetDetails()
        {
            InitializeComponent();
        }
        public string TextBoxText
        {
            get { return (string)(txtAssetValue.Text); }
            //set { SetValue(TextBlockTextProperty, value); }
        }
    }
}
