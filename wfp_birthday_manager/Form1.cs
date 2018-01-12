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


namespace wfp_birthday_manager
{
    public partial class Form1 : Form
    {

        string path = @"c:\AT\csharp.txt";
        string dirPath = @"c:\AT";
        List<Person> pessoas = new List<Person>();
        int index;


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

            checkFiles();

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
            add();          
        }

        private void btn_attLista_Click(object sender, EventArgs e)
        {
            refreshDVG();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_confirmDel_Click(object sender, EventArgs e)
        {
            confirmDel();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btn_confirmEdit_Click(object sender, EventArgs e)
        {
            confirmEdition();
        }

        public void showTodayBirthday()
        {
            
            foreach(Person p in pessoas)
            {
                DateTime dt = new DateTime(DateTime.Today.Year, p.Birthday.Month, p.Birthday.Day);
                if ( dt == DateTime.Today)
                {

                    MessageBox.Show(p.Name + " " + p.LastName, "Aniversáriantes do dia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Person p in pessoas)
            {
                checkedListBox1.Items.Add(p, false);
            }
        }

        //public void searchByName()
        //{

        //    foreach (Person p in pessoas)
        //    {
        //        if (p.Name.Contains(txt_search.Text) && p.LastName.Contains(txt_search.Text))
        //        {


        //            List<Person> items = new List<Person>();
        //            items.Add(p);

        //                var bindingList = new BindingList<Person>(items);
        //                var source = new BindingSource(bindingList, null);
        //                dataGridView1.DataSource = source;

        //                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        //        }
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //searchByName();
        }

        public void confirmEdition()
        {
            Person p = pessoas[index];

            pessoas[index].Name = textBox2.Text;
            pessoas[index].LastName = textBox1.Text;
            pessoas[index].Birthday = DateTime.Parse(maskedTextBox1.Text, CultureInfo.InvariantCulture);

            p.ToNextBirthday(p);

            string json = JsonConvert.SerializeObject(pessoas.ToArray());
            System.IO.File.WriteAllText(path, json);
            btn_confirmEdit.Enabled = false;
            checkedListBox1.Items.Clear();
            groupBox2.Visible = false;
        }

        public void edit()
        {
            groupBox2.Visible = true;

            foreach (Person item in checkedListBox1.CheckedItems.OfType<Person>().ToList())
            {
                textBox2.Text = item.Name;
                textBox1.Text = item.LastName;
                maskedTextBox1.Text = item.Birthday.ToString();
                index = pessoas.IndexOf(item);

            }
            btn_confirmEdit.Enabled = true;
        }

        public void confirmDel()
        {
            foreach (Person item in checkedListBox1.CheckedItems.OfType<Person>().ToList())
            {
                checkedListBox1.Items.Remove(item);
                pessoas.Remove(item);
                string json = JsonConvert.SerializeObject(pessoas.ToArray());
                System.IO.File.WriteAllText(path, json);
            }

        }

        public void refreshDVG()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Person> items = JsonConvert.DeserializeObject<List<Person>>(json);

                var bindingList = new BindingList<Person>(items);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;

                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }

        }

        public void add()
        {
            Person p = new Person();
            p.Name = txt_name.Text;
            p.LastName = txt_lastname.Text;
            p.Birthday = DateTime.Parse(mtxt_birthday.Text, CultureInfo.InvariantCulture);
            p.ToNextBirthday(p);

            pessoas.Add(p);

            string json = JsonConvert.SerializeObject(pessoas.ToArray());
            System.IO.File.WriteAllText(path, json);
            groupBox1.Visible = false;

            // using (System.IO.StreamWriter file =
            //new System.IO.StreamWriter(path, true))
            // {
            //     //foreach (Person person in pessoas)
            //     //{
            //     //    // If the line doesn't contain the word 'Second', write the line to the file.


            //     //    file.WriteLine(person);

            //     //}

            //     string json = JsonConvert.SerializeObject(pessoas.ToArray()); //convert to JSON string
            //     file.Write(json);
            // }

        }

        public void checkFiles()
        {
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);

                if (!File.Exists(path))
                {
                    File.Create(path);
                }

            }

            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();

                    if (json == "")
                    {
                        List<Person> pessoas = new List<Person>();
                        pessoas = JsonConvert.DeserializeObject<List<Person>>(json);
                    }
                    else
                    {
                        pessoas = JsonConvert.DeserializeObject<List<Person>>(json);
                    }


                }

            }
        }
    }

}
