using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Holo_Data.Structure;
using System.IO;
using System.Diagnostics;

namespace Holo_Data
{
    public partial class Form1 : Form
    {

        internal List<Mottaker> mottakere;

        public Form1()
        {
            InitializeComponent();
            mottakere = new List<Mottaker>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bestilling best = new Bestilling();
            best.koli = (int)numKoli.Value;
            best.fraktnr = (int)numFraktNr.Value;
            best.sendt = dateSendtInput.Value;
            best.sender = txtSender.Text;
            best.mottakerpers = txtMottaker.Text;
            best.transportertav = txtTransportor.Text;
            if (chkBedriftSkjekk.Checked)
            {
                bool exists = false;
                int i = 0;
                for (i = 0; i < mottakere.Count; i++)
                {
                    if (mottakere[i].navn.ToLower() == txtMottaker.Text.ToLower())
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    mottakere.Add(new Mottaker() { id = mottakere.Count, navn = txtMottaker.Text, bestillinger = new List<Bestilling>() });
                    listMottakere.Items.Add(txtMottaker.Text);
                    mottakere[i].bestillinger.Add(best);
                }
                else
                {
                    mottakere[i].bestillinger.Add(best);
                }
            }
            else
            {
                if (listMottakere.SelectedIndex > 0 && listMottakere.SelectedIndex < mottakere.Count + 1)
                {
                    mottakere[listMottakere.SelectedIndex - 1].bestillinger.Add(best);
                    UpdateTreeView(listMottakere.SelectedIndex - 1);
                }
                else
                {
                    MessageBox.Show("Velg en mottaker fra listen på venstre side (ikke 'Alle')");
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    MessageBox.Show("Detected file: " + file);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDispSelect.SelectedIndex = 0;

            LoadData("tree.dat");

            listMottakere.Items.Clear();
            listMottakere.Items.Add("Alle");
            foreach (Mottaker m in mottakere)
            {
                listMottakere.Items.Add(m.navn);
            }
            UpdateTreeView();
        }

        private void listMottakere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMottakere.SelectedIndex > 0 && listMottakere.SelectedIndex < mottakere.Count + 1)
            {
                string navn = listMottakere.SelectedItem.ToString();

                int i = 0;
                for (i = 0; i < mottakere.Count; i++)
                {
                    if (navn == mottakere[i].navn)
                    {
                        break;
                    }
                }

                UpdateTreeView(i);
            }
            else
            {
                UpdateTreeView();
            }
        }

        private void UpdateTreeView()
        {
            treeBestillinger.Nodes.Clear();
            foreach (Mottaker m in mottakere)
            {
                treeBestillinger.Nodes.Add(m.GetNode());
            }
            treeBestillinger.ExpandAll();
        }

        private void UpdateTreeView(int mid)
        {
            treeBestillinger.Nodes.Clear();
            treeBestillinger.Nodes.Add(mottakere[mid].GetNode());
            treeBestillinger.ExpandAll();
        }

        private void UpdateTreeView(DateTime date, byte type)
        {
            treeBestillinger.Nodes.Clear();
            foreach (Mottaker m in mottakere)
            {
                TreeNode n = m.GetNodes(date, type);
                if (n.Nodes.Count > 0)
                {
                    treeBestillinger.Nodes.Add(n);
                }
            }
            treeBestillinger.ExpandAll();
        }

        private void Save(string file)
        {
            if (File.Exists(file)) File.Delete(file);
            FileStream fs = new FileStream(file, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(mottakere.Count);
            foreach (Mottaker m in mottakere)
            {
                m.Save(bw);
            }
            bw.Close();
        }

        void LoadData(string file)
        {
            if (File.Exists(file))
            {
                FileStream fs = new FileStream(file, FileMode.Open);
                BinaryReader br = new BinaryReader(fs);
                int mlen = br.ReadInt32();
                mottakere = new List<Mottaker>();
                for (int i = 0; i < mlen; i++)
                {
                    mottakere.Add(Mottaker.Load(br));
                }
                br.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTreeView(dateFilter.Value.Date, (byte)cmbDispSelect.SelectedIndex);
        }

        private void cmbDispSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTreeView(dateFilter.Value.Date, (byte)cmbDispSelect.SelectedIndex);
        }

        private void lagreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save("tree.dat");
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            foreach (Mottaker m in mottakere)
            {
                m.Remove(treeBestillinger.SelectedNode.Text);
            }
            UpdateTreeView();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save("tree.dat");
        }

        private void lagreSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Holo Data File|*.dat";
            sd.AddExtension = true;
            sd.ShowDialog();
            if (sd.FileName != "")
            {
                Save(sd.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listMottakere.SelectedIndex > 0 && listMottakere.SelectedIndex < mottakere.Count + 1)
            {
                if (MessageBox.Show("Vil du virkelig fjerne: " + listMottakere.SelectedItem.ToString() + " og alle bestillingene dens?","Fjerning av bedrift",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    for (int i = 0; i < mottakere.Count; i++)
                    {
                        if (mottakere[i].navn == listMottakere.SelectedItem.ToString())
                        {
                            mottakere.RemoveAt(i);
                        }
                    }
                    UpdateMottakerList();
                }
            }
        }

        private void UpdateMottakerList()
        {
            listMottakere.Items.Clear();
            listMottakere.Items.Add("Alle");
            foreach (Mottaker m in mottakere)
            {
                listMottakere.Items.Add(m.navn);
            }
        }

        private void printFraktbrevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Mottaker m in mottakere)
            {
                Bestilling b = m.GetBestilling(treeBestillinger.SelectedNode.Text);
                if (b != null)
                {
                    File.WriteAllText("tempfb.txt", b.ToFraktBrev());
                    Process.Start("tempfb.txt");
                }
            }
        }
    }
}
