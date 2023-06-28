using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCsharp1
{
    public partial class SimulationForm : Form
    {
        private Bitmap fieldBitmap;

        public SimulationForm()
        {
            InitializeComponent();

            // Установка размера окна
            this.ClientSize = new Size(784, 550); // Ширина 784, Высота 550 


            // Создаем большое по горизонтали изображение для поля
            fieldBitmap = new Bitmap(2000, panel1.Height);

            using (Graphics g = Graphics.FromImage(fieldBitmap))
            {
                for (int i = 0; i < 2000; i += 50)
                {
                    g.DrawString("X", new Font("Arial", 12), Brushes.Black, new PointF(i, 10));
                    g.DrawEllipse(Pens.Black, i, 30, 30, 30);
                }
            }

            // Запускаем вычислительную задачу на всех логических ядрах
            RunParallelComputation();
        }

        private void RunParallelComputation()
        {
            Task.Run(() =>
            {
                Parallel.For(0, Environment.ProcessorCount, core =>
                {
                    // Здесь ваш код для ресурсоемких вычислений
                    // Вы можете модифицировать fieldBitmap для отображения результатов вычислений
                });

                // Обновление PictureBox после завершения вычислений
                this.Invoke(new Action(() =>
                {
                    pictureBox1.Image = fieldBitmap;
                    pictureBox1.Width = fieldBitmap.Width;

                    // Настраиваем ползунок
                    hScrollBar1.Maximum = fieldBitmap.Width - panel1.Width;

                    // Масштабируем и отображаем изображение в уменьшенном виде в нижней части окна
                    var thumbnail = new Bitmap(panel1.Width, 100); // 100 - высота уменьшенного изображения
                    using (var g = Graphics.FromImage(thumbnail))
                    {
                        g.DrawImage(fieldBitmap, 0, 0, panel1.Width, 100);
                    }
                    pictureBoxThumbnail.Image = thumbnail;
                }));
            });
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Перемещение PictureBox согласно положению ползунка
            pictureBox1.Left = -e.NewValue;
        }
    }
}
