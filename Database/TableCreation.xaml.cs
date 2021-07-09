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

namespace Database
{
    public class RowData
    {
        public string Champ;
        public string Type;
        public string ClePrimaire;
    }
    /// <summary>
    /// Interaction logic for TableCreation.xaml
    /// </summary>
    public partial class TableCreation : Window
    {
        public TableCreation(ADOX.Catalog catalog)
        {
            InitializeComponent();
            comboBoxKey.Items.Add("Oui");
            comboBoxKey.Items.Add("Non");
            comboBoxKey.SelectedIndex = 1;

            comboBoxType.Items.Add("int");
            comboBoxType.Items.Add("string");
            comboBoxType.SelectedIndex = 1;

            list = new List<RowData>();

            createDataGrid();

            mCatalog = catalog;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void createDataGrid()
        {
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "Champ";
            c1.Binding = new Binding("Champ");
            c1.Width = 250;
            dataGrid.Columns.Add(c1);
            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Type";
            c2.Width = 200;
            c2.Binding = new Binding("Type");
            dataGrid.Columns.Add(c2);
            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Cle Primaire";
            c3.Width = 200;
            c3.Binding = new Binding("ClePrimaire");
            dataGrid.Columns.Add(c3);
        }

        private void addColonneBtn_Click(object sender, RoutedEventArgs e)
        {
            list.Add(new RowData{ Champ = champTxt.Text, Type = comboBoxType.Text, ClePrimaire = comboBoxKey.Text });

            dataGrid.Items.Add (new { Champ = champTxt.Text, Type = comboBoxType.Text, ClePrimaire = comboBoxKey.Text });
            champTxt.Text = "";
        }

        private void validerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (tableNameBox.Text != "")
            {
                ADOX.Table table = new ADOX.Table();
                table.Name = tableNameBox.Text;   // Table name

                tableNameBox.Text = "";
                string primaryKey = list[0].Champ;

                foreach (var item in list)
                {
                    ADOX.Column col = new ADOX.Column();
                    col.Name = item.Champ;  // The name of the column
                    col.ParentCatalog = mCatalog;
                    if (item.Type == "int")
                    {
                        col.Type = ADOX.DataTypeEnum.adInteger;
                    }
                    else
                    {
                        col.Type = ADOX.DataTypeEnum.adVarWChar;   
                        col.DefinedSize = 60;
                    }

                    if (item.ClePrimaire == "Oui")
                    {
                        primaryKey = col.Name;
                    }

                    table.Columns.Append(col);                    
                }

                table.Keys.Append("PrimaryKey", ADOX.KeyTypeEnum.adKeyPrimary, primaryKey, null, null);

                mCatalog.Tables.Append(table);
            }
        }

        ADOX.Catalog mCatalog;
        List<RowData> list;
    }
}
