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
            btn_change.Enabled = false;
            btn_confirm.Enabled = false;

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

                    if (json == null)
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_change.Enabled = true;
            btn_confirm.Enabled = true;
            btn_add.Enabled = false;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Name = txt_name.Text;
            p.LastName = txt_lastname.Text;
            p.Birthday = DateTime.ParseExact(mtxt_birthday.Text.ToString(), "dd/MM/yyyy", CultureInfo.CurrentCulture);
            p.ToNextBirthday(p);



            pessoas.Add(p);

            // QUANDO INICIAR TENHO QUE ADD PESSOAS QUE JA ESTAO EM OUTRO ARQUIVO

            string json = JsonConvert.SerializeObject(pessoas.ToArray());
            System.IO.File.WriteAllText(path, json);


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

            //File.WriteAllText(path, json); //save to file

        }

        private void btn_change_Click(object sender, EventArgs e)
        {

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Person> items = JsonConvert.DeserializeObject<List<Person>>(json);
                



                var bindingList = new BindingList<Person>(items);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;

                //foreach (Person newp in items)
                //{
                //    dataGridView1.DataSource = items;
                //}

            }



            //string[] lines = System.IO.File.ReadAllLines(path);

            //// Display the file contents by using a foreach loop.

            //foreach (string line in lines)
            //{
            //    string json = File.ReadAllText(path); //read from file into a string
            //    Person p2 = JsonConvert.DeserializeObject<Person>(json);
            //    textBox1.Text += p2.ToString();
            //}



        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();

            foreach (Person p in pessoas)
            {
                checkedListBox1.Items.Add(p, false);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Person item in checkedListBox1.CheckedItems.OfType<Person>().ToList())
            {
                checkedListBox1.Items.Remove(item);
                pessoas.Remove(item);
                string json = JsonConvert.SerializeObject(pessoas.ToArray());
                System.IO.File.WriteAllText(path, json);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Person item in checkedListBox1.CheckedItems.OfType<Person>().ToList())
            {
                txt_name.Text = item.Name;
                txt_lastname.Text = item.LastName;
                mtxt_birthday.Text = item.Birthday.ToString();
                index = pessoas.IndexOf(item);

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Person p = pessoas[index];

            pessoas[index].Name = txt_name.Text;
            pessoas[index].LastName = txt_lastname.Text;
            pessoas[index].Birthday = DateTime.ParseExact(mtxt_birthday.Text.ToString(), "dd/MM/yyyy", CultureInfo.CurrentCulture);

            p.ToNextBirthday(p);

            string json = JsonConvert.SerializeObject(pessoas.ToArray());
            System.IO.File.WriteAllText(path, json);
        }


    }

}
