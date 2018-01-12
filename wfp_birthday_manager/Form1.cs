using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Globalization;
using BirthdayManager.Persistence;

namespace wfp_birthday_manager
{
    public partial class Form1 : Form
    {

        Functions fnc = new Functions();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            btn_confirmAdd.Enabled = false;
            btn_confirmEdit.Enabled = false;

            fnc.checkFiles();

            showTodayBirthday();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_attLista.Enabled = true;
            btn_confirmAdd.Enabled = true;
            btn_add.Enabled = false;
            groupBox1.Visible = true;
        }

        private void btn_confirmAdd_Click(object sender, EventArgs e)
        {
            fnc.add(txt_name.Text, txt_lastname.Text, mtxt_birthday.Text);
            groupBox1.Visible = false;
        }

        private void btn_attLista_Click(object sender, EventArgs e)
        {
            fnc.refreshDVG();
            var bindingList = new BindingList<Person>(fnc.refreshDVG());
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }



        private void btn_confirmDel_Click(object sender, EventArgs e)
        {
            foreach (Person item in checkedListBox1.CheckedItems.OfType<Person>().ToList())
            {
                checkedListBox1.Items.Remove(item);
                fnc.confirmDel(item);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            foreach (Person item in checkedListBox1.CheckedItems.OfType<Person>().ToList())
            {
                fnc.edit(textBox2.Text, textBox1.Text, maskedTextBox1.Text, item);
            }
            btn_confirmEdit.Enabled = true;
        }

        private void btn_confirmEdit_Click(object sender, EventArgs e)
        {
            fnc.confirmEdition(textBox2.Text, textBox1.Text, maskedTextBox1.Text, fnc.pessoas);
            btn_confirmEdit.Enabled = false;
            checkedListBox1.Items.Clear();
            groupBox2.Visible = false;
        }

        public void showTodayBirthday()
        {

            foreach (Person p in fnc.pessoas)
            {
                DateTime dt = new DateTime(DateTime.Today.Year, p.Birthday.Month, p.Birthday.Day);
                if (dt == DateTime.Today)
                {

                    MessageBox.Show(p.Name + " " + p.LastName, "Aniversáriantes do dia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Person p in fnc.pessoas)
            {
                checkedListBox1.Items.Add(p, false);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //searchByName();
        }


    }

}
