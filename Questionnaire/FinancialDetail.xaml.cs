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
    /// Interaction logic for FinancialGoal.xaml
    /// </summary>
    public partial class FinancialGoal : Page
    {
        AssetDetails[] ASD= new AssetDetails[10];
        Goals[] GD = new Goals[10];
        static int i, j;
        public FinancialGoal()
        {
            InitializeComponent();
            InitiateGoalsAndAssets();
        }
        private void InitiateGoalsAndAssets()
        {
            ASD[i] = new AssetDetails();
            GD[j] = new Goals();
            stackAssetDetails.Children.Add(ASD[i]);
            stackGoals.Children.Add(GD[j]);
            i++;
            j++;
        }
        private void btnAddAsset_Click(object sender, RoutedEventArgs e)
        {
            ASD[i] = new AssetDetails();
            stackAssetDetails.Children.Add(ASD[i]);
            i++;
        }

        private void btnSaveAsset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSaveGoals_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddGoals_Click(object sender, RoutedEventArgs e)
        {
            GD[j] = new Goals();
            stackGoals.Children.Add(GD[j]);
            j++;
        }
    }
}
