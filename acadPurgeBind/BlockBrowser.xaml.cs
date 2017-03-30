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

namespace acadPurgeBind
{
    /// <summary>
    /// Interaction logic for BlockBrowswer.xaml
    /// </summary>
    public partial class BlockBrowser : Window
    {
        public BlockBrowser()
        {
            InitializeComponent();
        }

        private void SelectFolder_Click(object sender, RoutedEventArgs e)
        {
            // Step 1 : Open up a folder selection dialog box
            int size = -1;
            
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Show the list of sub folders in the folder selected in step 1
        }
    }
}
