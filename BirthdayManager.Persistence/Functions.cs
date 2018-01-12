using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using System.IO;

namespace BirthdayManager.Persistence
{
    public class Functions
    {
        string path = @"c:\AT\csharp.txt";
        string dirPath = @"c:\AT";
        public List<Person> pessoas = new List<Person>();
        int index;

        public void confirmEdition(string nome, string sobrenome, string niver, List<Person> lista)
        {
            Person p = lista[index];

            lista[index].Name = nome;
            lista[index].LastName = sobrenome;
            lista[index].Birthday = DateTime.Parse(niver, CultureInfo.InvariantCulture);

            p.ToNextBirthday(p);

            string json = JsonConvert.SerializeObject(lista.ToArray());
            System.IO.File.WriteAllText(path, json);

        }

        public void edit(string nome, string sobrenome, string niver, Person item)
        {

            nome = item.Name;
            sobrenome = item.LastName;
            niver = item.Birthday.ToString();
            index = pessoas.IndexOf(item);



        }

        public void confirmDel(Person item)
        {
            pessoas.Remove(item);
            string json = JsonConvert.SerializeObject(pessoas.ToArray());
            System.IO.File.WriteAllText(path, json);


        }

        public List<Person> refreshDVG()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Person> items = JsonConvert.DeserializeObject<List<Person>>(json);
                return items;
            }


        }

        public void add(string nome, string sobrenome, string niver)
        {
            Person p = new Person();
            p.Name = nome;
            p.LastName = sobrenome;
            p.Birthday = DateTime.Parse(niver, CultureInfo.InvariantCulture);
            p.ToNextBirthday(p);

            pessoas.Add(p);

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




    }
}
