using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LINQ_people
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<People> people = new List<People>();
            StreamReader sr = File.OpenText("people.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] info = str.Split(new char[] { ' ' });
                string name = info[0];
                string surname = info[1];
                string otchestvo = info[2];
                int age = Convert.ToInt32(info[3]);
                double weight = Convert.ToDouble(info[4]);
                People people1 = new People(name, surname, otchestvo, age, weight);
                people.Add(people1);
                listBox1.Items.Add($"{name} {surname} {otchestvo}, Возраст - {age}, Вес - {weight}");
            }
            var age40 = from people1 in people
                        where people1.age < 40
                        select people1;
            foreach (People people2 in age40)
            {
                listBox2.Items.Add($"{people2.name} {people2.surname} {people2.otchestvo}, Возраст - {people2.age}, Вес - {people2.weight}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Department> department = new List<Department>()
            {
                new Department { Name = "Отдел закупок", Reg="Германия"},
                new Department { Name = "Отдел продаж", Reg = "Испания" },
                new Department { Name = "Отдел маркетинга", Reg = "Испания" }
            };
            List<Employ> employs = new List<Employ>()
            {
                new Employ { Name="Иванов", department="Отдел закупок"},
                new Employ { Name="Петров", department="Отдел закупок"},
                new Employ { Name="Сидоров", department="Отдел продаж"},
                new Employ { Name="Лямин", department="Отдел продаж"},
                new Employ { Name="Сидоренко", department="Отдел маркетинга"},
                new Employ { Name="Кривоносов", department="Отдел продаж"}
                
            };
            
        }
    }
}
