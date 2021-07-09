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
using ADOX;

namespace Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            addTablebtn.IsEnabled = false;
            mCurrentDataBase = "";
            
        }

        private void addTablebtn_Click(object sender, RoutedEventArgs e)
        {
            TableCreation creationTable = new TableCreation(mCatalog);
            creationTable.Show();
        }

        private void createDBbtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "DataBase"; // le nom de la base de donnees par defaut
            dlg.DefaultExt = ".mdb"; // l'extension par defaut
            dlg.Filter = "(.mdb)|*.mdb"; 

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string mCurrentDataBase = dlg.FileName;
                string connectionString = string.Format("Provider={0}; Data Source={1}; Jet OLEDB:Engine Type={2}",
                                                        "Microsoft.Jet.OLEDB.4.0",
                                                        mCurrentDataBase,
                                                        5);

                mCatalog = new ADOX.Catalog();
                mCatalog.Create(connectionString);

                currentDBLabel.Content = mCurrentDataBase;
                addTablebtn.IsEnabled = true;
            }
        }

        string mCurrentDataBase;
        ADOX.Catalog mCatalog;
    }
}
