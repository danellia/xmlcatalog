//Разработать статический класс для преобразования приведенного ниже
//xml документа в объект класса Catalog, содержащий список (использовать
//контейнер List) объектов класса CD. Количество объектов CD в списке не
//ограничено. Классы CD и Catalog разработать самостоятельно.
//добавить абстрактные классы и/или интерфейсы, а
//также абстрактные методы

namespace xmlcatalog
{
    public partial class Form1 : Form
    {
        string filepath;
        Serializer serializer;
        Catalog catalog;
        public Form1()
        {
            InitializeComponent();
            serializer = new CatalogSerializer();
        }

        private void loadXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.DefaultExt = "*.xml";
                ofd.Filter = "XML Files (*.xml)|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    textBox1.Text = ofd.FileName;
                    filepath = ofd.FileName;
                    using (StreamReader reader = new StreamReader(filepath))
                    {
                        richTextBox1.Text = reader.ReadToEnd();
                    }
                }
            }
        }

        private void transformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                catalog = serializer.deserialize(filepath);
                foreach(var cd in catalog.CD)
                {
                    ListViewItem item = new ListViewItem();
                    createSubItem(item, cd.title);
                    createSubItem(item, cd.artist);
                    createSubItem(item, cd.country);
                    createSubItem(item, cd.company);
                    createSubItem(item, cd.price.ToString());
                    createSubItem(item, cd.year.ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load non-empty XML file first!");
            }
        }

        private void createSubItem(ListViewItem item, string value)
        {
            string itemValue;
            if (value == "" || value == "0" || value == null)
            {
                itemValue = "-";
            }
            else
            {
                itemValue = value;
            }
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, itemValue));
        }
    }
}