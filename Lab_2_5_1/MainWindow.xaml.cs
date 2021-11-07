using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;





namespace Lab_2_5_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Top = Properties.Settings.Default.Position.Top;
            this.Left = Properties.Settings.Default.Position.Left;
            this.Height = Properties.Settings.Default.Position.Height;
            this.Width = Properties.Settings.Default.Position.Width;

            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Position = this.RestoreBounds;
            Properties.Settings.Default.Save();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не получилось у меня открывать и сохранять изображения что то все так запутанно и в инете тоже, я так понимаю надо не InkCanvas использовать? Думаю дальше по ходу учения мы изучим более простые методы?", "Сообщение", MessageBoxButton.OK);


            //this.Jpg.EditingMode = InkCanvasEditingMode.None;
            //string imgPath = @"c:\\Data\file.jpg"; //Куда сохраняется файл
            //MemoryStream ms = new MemoryStream();  //Поток памяти :)
            //FileStream fs = new FileStream(imgPath, FileMode.Create); //  Поток файла :)

            ////rtb - объект класса RenderTargetBitmap
            //RenderTargetBitmap rtb = new RenderTargetBitmap((int)Jpg.Width, (int)Jpg.Height, 96, 96, PixelFormats.Default);
            //rtb.Render(Jpg);

            //GifBitmapEncoder JpgEnc = new GifBitmapEncoder(); //сохраняем в формате GIF
            //JpgEnc.Frames.Add(BitmapFrame.Create(rtb));
            //JpgEnc.Save(fs);
            //fs.Close();
            //this.Jpg.EditingMode = InkCanvasEditingMode.Ink;
            //MessageBox.Show("Файл сохранен, " + imgPath); //Для информации


            //OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            //open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            //if (open_dialog.ShowDialog() == true) //если в окне была нажата кнопка 
            //{
            //    Jpg.Image = File.ReadAllText(openFileDialog.FileName);

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Только рисунок (*.jpg)|*.jpg";
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    
            //}
        }
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Не получилось у меня открывать и сохранять изображения что то все так запутанно и в инете тоже, я так понимаю надо не InkCanvas использовать? Думаю дальше по ходу учения мы изучим более простые методы?", "Сообщение", MessageBoxButton.OK);

            //string imgPath = @"C:\Temp\file.gif"; //Куда сохраняется файл
            //MemoryStream ms = new MemoryStream();  //Поток памяти :)
            //FileStream fs = new FileStream(imgPath, FileMode.Create); //  Поток файла :)

            ////rtb - объект класса RenderTargetBitmap
            //RenderTargetBitmap rtb = new RenderTargetBitmap((int)Jpg.Width, (int)Jpg.Height, 96, 96, PixelFormats.Default);
            //rtb.Render(Jpg);

            //GifBitmapEncoder gifEnc = new GifBitmapEncoder(); //сохраняем в формате GIF
            //gifEnc.Frames.Add(BitmapFrame.Create(rtb));
            //gifEnc.Save(fs);
            //fs.Close();

            //MessageBox.Show("Файл сохранен, " + imgPath); //Для информации
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Только рисунок (*.jpg)|*.jpg";
            //if (saveFileDialog.ShowDialog() == true)
            //{
            //    File.Open(saveFileDialog.FileName, );
            //    Jpg.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    Jpg.Image.Save("Только рисунок (*.jpg)|*.jpg");
            //}
        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Jpg.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Jpg.EditingMode = InkCanvasEditingMode.Select;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Jpg.EditingMode = InkCanvasEditingMode.InkAndGesture;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Jpg.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Jpg.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        //private void RadioButton_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Jpg.DefaultDrawingAttributes.Color = Colors.Black;

        //}

        //private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        //{
        //    this.Jpg.DefaultDrawingAttributes.Color = Colors.Red;
        //}

        //private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        //{
        //    this.Jpg.DefaultDrawingAttributes.Color = Colors.Green;
        //}

        //private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        //{
        //    this.Jpg.DefaultDrawingAttributes.Color = Colors.Yellow;
        //}

        //private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        //{
        //    this.Jpg.DefaultDrawingAttributes.Color = Colors.Blue;
        //}
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }
        public ColorRGB mcolor { get; set; }
        public Color clr { get; set; }
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name; //Определяем имя контрола, который покрутили
            double value = slider.Value; // Получаем значение контрола
                                         //В зависимости от выбранного контрола, меняем ту или иную компоненту и переводим ее в тип byte
            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }
            //Задаем значение переменной класса clr 
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            //Устанавливаем фон для контрола Label 
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            // Задаем цвет кисти для контрола InkCanvas
            this.Jpg.DefaultDrawingAttributes.Color = clr;
        }
    }
}
