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

namespace AnyaProject
{
    public partial class Piramida : Form
    {
        public Piramida()
        {
            InitializeComponent();
        }
        public void collectDate()
        {
            if (!int.TryParse(x1.Text, out piramid.x1))
            { MessageBox.Show("Некорректно введено значение x1 Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.x1 = Convert.ToInt32(x1.Text);}

            if (!int.TryParse(x2.Text, out piramid.x2))
            { MessageBox.Show("Некорректно введено значение x2 Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.x2 = Convert.ToInt32(x2.Text); }

            if (!int.TryParse(x3.Text, out piramid.x3))
            { MessageBox.Show("Некорректно введено значение x3 Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.x3 = Convert.ToInt32(x3.Text);}

            if (!int.TryParse(y1.Text, out piramid.y1))
            { MessageBox.Show("Некорректно введено значение y1 Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.y1 = Convert.ToInt32(y1.Text); }

            if (!int.TryParse(y2.Text, out piramid.y2))
            { MessageBox.Show("Некорректно введено значение y2 Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.y2 = Convert.ToInt32(y2.Text); }


            if (!int.TryParse(y3.Text, out piramid.y3))
            { MessageBox.Show("Некорректно введено значение y3 Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.y3 = Convert.ToInt32(y3.Text); }


            if (!int.TryParse(haight.Text, out piramid.haight))
            { MessageBox.Show("Некорректно введено значение высоты. Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.haight = Convert.ToInt32(haight.Text); }

            if (!int.TryParse(gradus.Text, out piramid.gradus))
            { MessageBox.Show("Некорректно введено значение угла. Пожалуйста, введите целое число.", "Ошибка"); return; } // Прерываем функцию, если ошибка
            else
            { piramid.gradus = Convert.ToInt32(gradus.Text); }

            if (string.IsNullOrEmpty(fileName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя файла.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                piramid.name = Convert.ToString(fileName.Text);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            collectDate();
            // Создаем объект pointData
            var pointData = new
            {
                X1 = piramid.x1,
                X2 = piramid.x2,
                X3 = piramid.x3,

                Y1 = piramid.y1,
                Y2 = piramid.y2,
                Y3 = piramid.y3,


                Haight = piramid.haight,
                Gradus = piramid.gradus
            };

            // Сохранение в электронную таблицу (CSV)
            SaveToCsv(pointData);
        }
        private void SaveToCsv(object data)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, piramid.name + ".csv");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("x1,y1,x2,y2,x3,y3,haight,angle");
                writer.WriteLine($"{piramid.x1},{piramid.y1},{piramid.x2},{piramid.y2},{piramid.x3},{piramid.y3},{piramid.haight},{piramid.gradus}");
            }
        }

        private void load_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(fileName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя файла.", "Ошибка");
                return; // Прерываем функцию, если ошибка
            }
            else
            {
                piramid.name = Convert.ToString(fileName.Text);
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, piramid.name + ".csv");

            if (System.IO.File.Exists(filePath)) // Проверяем, существует ли файл
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    reader.ReadLine(); // Пропускаем первую строку (заголовок)
                    string line = reader.ReadLine(); // Читаем строку с данными
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] values = line.Split(','); // Разделяем строку по запятым
                        if (values.Length == 8)
                        {
                            piramid.x1 = Convert.ToInt32(values[0]);
                            piramid.y1 = Convert.ToInt32(values[1]);

                            piramid.x2 = Convert.ToInt32(values[2]);
                            piramid.y2 = Convert.ToInt32(values[3]);

                            piramid.x3 = Convert.ToInt32(values[4]);
                            piramid.y3 = Convert.ToInt32(values[5]);

                            piramid.haight = Convert.ToInt32(values[6]);
                            piramid.gradus = Convert.ToInt32(values[7]);

                            //запись сохранённых данных
                            x1.Text = piramid.x1.ToString();
                            x2.Text = piramid.x2.ToString();
                            x3.Text = piramid.x3.ToString();

                            y1.Text = piramid.y1.ToString();
                            y2.Text = piramid.y2.ToString();
                            y3.Text = piramid.y3.ToString();
                            fileName.Text = piramid.name.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Неверный формат файла CSV.", "Ошибка");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Файл " + piramid.name + " CSV пустой.", "Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Файл CSV не найден.", "Ошибка");
            }
        }

        private void build2d_Click(object sender, EventArgs e)
        {
            collectDate();
            Class1.My_detal2d();
        }

        private void build3d_Click(object sender, EventArgs e)
        {
            collectDate();
            Class1.My_detal3d();
        }
    }
}
