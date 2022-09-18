//����������� ����������� ����� ��� �������������� ������������ ����
//xml ��������� � ������ ������ Catalog, ���������� ������ (������������
//��������� List) �������� ������ CD. ���������� �������� CD � ������ ��
//����������. ������ CD � Catalog ����������� ��������������.
//�������� ����������� ������ �/��� ����������, �
//����� ����������� ������

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
            serializer = new Serializer();
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
                }
            }
            using (StreamReader reader = new StreamReader(filepath))
            {
                richTextBox1.Text = reader.ReadToEnd();
            }
        }

        private void transformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalog = serializer.deserialize(filepath);
            foreach(var cd in catalog.CD)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cd.title));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cd.artist));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cd.country));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cd.company));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cd.price.ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, cd.year.ToString()));
                listView1.Items.Add(item);
            }
        }
    }
}