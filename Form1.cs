namespace tes
{
    public partial class formTugas : Form
    {
        public formTugas()
        {
            InitializeComponent();
        }

        private void listAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPilih.SelectedIndex == 0)
            {
                listAdd.Items.Add(textBoxIsi.Text);
            }
            if (comboBoxPilih.SelectedIndex == 1)
            {
                listAdd.Items.RemoveAt(listAdd.SelectedIndex);                              
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (comboBoxPilih.SelectedIndex == 0)
            {
                listAdd.Items.Add(textBoxIsi.Text);
            }
            if (comboBoxPilih.SelectedIndex == 1)
            {
                
                //listAdd.Items.Remove(listAdd.SelectedItems[listAdd.SelectedIndex]);
                //listAdd.Items.Insert(cek,textBoxIsi.Text);                
            }
        }

        private void buttonAllRight_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listAdd.Items.Count; i++)
            {
                listReplace.Items.Add(listAdd.Items[i]);                
            }
            listAdd.Items.Clear();
        }

        private void buttonAllLeft_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listReplace.Items.Count; i++)
            {
                listAdd.Items.Add(listReplace.Items[i]);
            }
            listReplace.Items.Clear();
        }

        private void checkBlock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBlock.Checked == true)
            {
                buttonAllLeft.Enabled = false;
                buttonAllRight.Enabled = false;
                buttonLeft.Enabled = false;
                buttonRight.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else
            {
                buttonAllLeft.Enabled = true;
                buttonAllRight.Enabled = true;
                buttonLeft.Enabled = true;
                buttonRight.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listAdd.Items.RemoveAt(listAdd.Items.IndexOf(listAdd.SelectedIndex));
            //listReplace.Items.RemoveAt(listReplace.Items);
        }
    }
}