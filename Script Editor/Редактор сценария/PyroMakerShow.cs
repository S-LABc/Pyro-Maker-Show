using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Drawing.Imaging;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework;

/**
 * Pyro Maker Show Firmware
 * 
 * Этот файл алгоритм работы приложения для составления сценария и
 * программирования пульта управляющего запуском развлекательной пиротехники.
 * 
 * Copyright (C) 2017. v1.0 / Скляр Роман S-LAB
 * YouTube https://www.youtube.com/channel/UCbkE52YKRphgkvQtdwzQbZQ
 * BUILD IN Microsoft Visual Studio Ultimate 2013
 * .NET framework 4.5
 * 
*/

namespace PyroMaker
{
    public partial class PyroMakerShow : MetroForm
    {
        public PyroMakerShow()
        {
            //Инициализация компонентов формы
            InitializeComponent();

            //Настройка диалогов
            DialogSettings();
        }

        //Загрузка формы
        private void PyroMaker_Load(object sender, EventArgs e)
        {
            //Вызов метода обновления списка портов
            ScanPorts();
        }

        private void aboutLink_Click(object sender, EventArgs e)
        {
            //Информация о программе
            MetroMessageBox.Show(this,
                "Программа создания и записи сценария в пульт для запуска бытовой пиротехники \n" + "Версия: 1.0 \n" + "E-mail: romansklyar15@gmail.com",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #region Константы для настроек

        //Настройки картинки-памятки
        static string[] Memo_Settings = File.ReadAllLines("MemoSettings.txt", Encoding.UTF8);

        //Пути к файлам и каталогам
        static string[] Pathways = File.ReadAllLines("Pathways.txt", Encoding.UTF8);

        //Расширение картнки-памятки
        static string _MemoEXT = ".jpg";

        //Фильтр файлов окна чтения сценария
        static string _openFilter = "Файлы Pyro Maker Show(*.pShow)|*.pShow";

        //Фильтр файлов окна сохранения сценария
        static string _saveFilter = "Файлы Pyro Maker Show(*.pShow)|*.pShow";

        //Название окна чтения сценария
        static string _openTitle = "Открыть сценарий Pyro Maker Show";

        //Название окна сохранения сценария
        static string _saveTitle = "Сохранить сценарий Pyro Maker Show";

        #endregion

        #region Настройка диалоговых окон

        private void DialogSettings()
        {
            //Настройка диалога "открыть"
            openFD.Title = _openTitle;
            openFD.Filter = _openFilter;
            openFD.InitialDirectory = Pathways[0];

            //Настройка диалога "сохранить"
            saveFD.Title = _saveTitle;
            saveFD.Filter = _saveFilter;
            saveFD.InitialDirectory = Pathways[1];
        }

        #endregion

        #region Поиск и обновление доступных портов

        //Метод поиска и создания списка
        private void ScanPorts()
        {
            //Заполнение массива найденными портами
            string[] Ports = SerialPort.GetPortNames();

            //Очистка и заполнение списка
            portsBox.Items.Clear();
            portsBox.Items.AddRange(Ports);
          
            //Если есть хоть один порт - выбрать его, иначе пустое поле
            portsBox.SelectedIndex = (Ports.Length != 0) ? 0 : -1;

        }

        //Событие обновления
        private void PortsRescan_Click(object sender, EventArgs e)
        {
            //Вызов метода обновления списка портов
            ScanPorts();
        }

        #endregion

        #region Сохранение сценария

        //Метод сохранения
        private void SavingCreatedFile()
        {
            //Заполнение массива содержимым формы
            string[] Name_Delay_S = { nameCUE1.Text,
                                    nameCUE2.Text,
                                    nameCUE3.Text,
                                    nameCUE4.Text,
                                    nameCUE5.Text,
                                    nameCUE6.Text,

                                    timeCUE1.Text,
                                    timeCUE2.Text,
                                    timeCUE3.Text,
                                    timeCUE4.Text,
                                    timeCUE5.Text,
                                    timeCUE6.Text,

                                    delayCUE1.Text,
                                    delayCUE2.Text,
                                    delayCUE3.Text,
                                    delayCUE4.Text,
                                    delayCUE5.Text};

            //Запись пути иимени файла для сохранения
            string SavePath = saveFD.FileName;

            //Запись данных в файл
            File.WriteAllLines(SavePath, Name_Delay_S, Encoding.UTF8);

            //Смена заголовка окна
            this.Text = Path.GetFileNameWithoutExtension(SavePath);

            //Перерисовка формы для смены заголовка
            this.Invalidate(true);
        }

        //Событие сохранения по клику
        private void saveLink_Click(object sender, EventArgs e)
        {
            //Проверка на закрытие окна диалога
            if (saveFD.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            //Вызов метода сохранения файла
            SavingCreatedFile();
        }

        #endregion

        #region Чтение сценария

        //Метод чтения сценария
        private void ReadingOpenFile()
        {
            //Запись пути иимени файла для открытия
            string OpenPath = openFD.FileName;

            //Чтение файла с записью в массив
            string[] Name_Delay_O = File.ReadAllLines(OpenPath, Encoding.UTF8);

            nameCUE1.Text = Name_Delay_O[0];
            nameCUE2.Text = Name_Delay_O[1];
            nameCUE3.Text = Name_Delay_O[2];
            nameCUE4.Text = Name_Delay_O[3];
            nameCUE5.Text = Name_Delay_O[4];
            nameCUE6.Text = Name_Delay_O[5];

            timeCUE1.Text = Name_Delay_O[6];
            timeCUE2.Text = Name_Delay_O[7];
            timeCUE3.Text = Name_Delay_O[8];
            timeCUE4.Text = Name_Delay_O[9];
            timeCUE5.Text = Name_Delay_O[10];
            timeCUE6.Text = Name_Delay_O[11];

            delayCUE1.Text = Name_Delay_O[12];
            delayCUE2.Text = Name_Delay_O[13];
            delayCUE3.Text = Name_Delay_O[14];
            delayCUE4.Text = Name_Delay_O[15];
            delayCUE5.Text = Name_Delay_O[16];

            //Смена заголовка окна
            this.Text = Path.GetFileNameWithoutExtension(OpenPath);

            //Перерисовка формы для смены заголовка
            this.Invalidate(true);
        }

        //Событие чтения сценария
        private void openLink_Click(object sender, EventArgs e)
        {
            //Проверка на закрытие окна диалога
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            //Вызов метода чтения файла
            ReadingOpenFile();
        }

        #endregion

        #region Очистка полей ввода

        //Очистка столбца "Название изделия"
        private void nameTile_Click(object sender, EventArgs e)
        {
            nameCUE1.Clear();
            nameCUE2.Clear();
            nameCUE3.Clear();
            nameCUE4.Clear();
            nameCUE5.Clear();
            nameCUE6.Clear();
        }

        //Очистка столбца "Время"
        private void timeTile_Click(object sender, EventArgs e)
        {
            timeCUE1.Clear();
            timeCUE2.Clear();
            timeCUE3.Clear();
            timeCUE4.Clear();
            timeCUE5.Clear();
            timeCUE6.Clear();
        }

        //Очистка столбца "Задержка"
        private void delayTile_Click(object sender, EventArgs e)
        {
            delayCUE1.Clear();
            delayCUE2.Clear();
            delayCUE3.Clear();
            delayCUE4.Clear();
            delayCUE5.Clear();
        }

        #endregion

        #region Создание картинки-памятки

        //Событие создания памятки
        private void memoLink_Click(object sender, EventArgs e)
        {
            if (this.Text != "Pyro Maker Show")
            {
                //Картинка из ресурсов
                Image ImageMemo = Image.FromFile("Memo.jpg");

                //Цвет текста на памятке
                Color TextColor = Color.FromArgb(Convert.ToInt16(Memo_Settings[2]),
                                                 Convert.ToInt16(Memo_Settings[3]),
                                                 Convert.ToInt16(Memo_Settings[4]));

                //Объект для рисования памятки
                Graphics GraphicsMemo = Graphics.FromImage(ImageMemo);

                //Шрифт
                Font drawFont = new Font(Memo_Settings[0], Convert.ToInt16(Memo_Settings[1]));

                //Кисть 
                SolidBrush drawBrush = new SolidBrush(TextColor);

                //Строка для канала CUE #1
                GraphicsMemo.DrawString(nameCUE1.Text, drawFont, drawBrush, new Point(Convert.ToInt16(Memo_Settings[5]),
                                                                                      Convert.ToInt16(Memo_Settings[6])));
                //Строка для канала CUE #2
                GraphicsMemo.DrawString(nameCUE2.Text, drawFont, drawBrush, new Point(Convert.ToInt16(Memo_Settings[7]),
                                                                                      Convert.ToInt16(Memo_Settings[8])));
                //Строка для канала CUE #3
                GraphicsMemo.DrawString(nameCUE3.Text, drawFont, drawBrush, new Point(Convert.ToInt16(Memo_Settings[9]),
                                                                                      Convert.ToInt16(Memo_Settings[10])));
                //Строка для канала CUE #4
                GraphicsMemo.DrawString(nameCUE4.Text, drawFont, drawBrush, new Point(Convert.ToInt16(Memo_Settings[11]),
                                                                                      Convert.ToInt16(Memo_Settings[12])));
                //Строка для канала CUE #5
                GraphicsMemo.DrawString(nameCUE5.Text, drawFont, drawBrush, new Point(Convert.ToInt16(Memo_Settings[13]),
                                                                                      Convert.ToInt16(Memo_Settings[14])));
                //Строка для канала CUE #6
                GraphicsMemo.DrawString(nameCUE6.Text, drawFont, drawBrush, new Point(Convert.ToInt16(Memo_Settings[15]),
                                                                                      Convert.ToInt16(Memo_Settings[16])));

                //Сохранение созданной памятки 
                ImageMemo.Save(Pathways[1] + this.Text + _MemoEXT, ImageFormat.Jpeg);

                //Сообщение об успешном создании памятки
                MetroMessageBox.Show(this,
                    "Памятка успешно создана в каталоге со сценарием",
                    "Создание памятки прошло успешно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }

            else
            {
                //Сообщение об ошибке
                MetroMessageBox.Show(this,
                    "Перед созданием памятки сохраните или откройте сценарий.",
                    "Проблема с созданием памятки",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Запись сценария в пульт

        private void downloadLink_Click(object sender, EventArgs e)
        {
            //Сбор задержек в массив
            string[] Delays = {delayCUE1.Text,
                            delayCUE2.Text,
                            delayCUE3.Text,
                            delayCUE4.Text,
                            delayCUE5.Text};

            //Обработка массива задержек
            for (int i = 0; i < Delays.Length; i++)
            {
                //Добавление "000" в конец задержки (эквив. *1000). перевод в мс
                Delays[i] = string.Concat(Delays[i], "000");

                //Если задержка меньше пяти знаков
                if (Delays[i].Length < 5)
                {
                    //Добавление "0" вначале
                    Delays[i] = Delays[i].Insert(0, "0");

                    //Если задержка снова меньше пяти знаков (значит поле пустое)
                    if (Delays[i].Length < 5)
                    {
                        //Добавление еще одного "0" вначале
                        Delays[i] = Delays[i].Insert(0, "0");
                    }
                }
            }

            //Склеивание элементов массива в одну строку
            string Package = string.Concat(Delays);

            try
            {
                //Выбор порта
                serialP.PortName = Convert.ToString(portsBox.SelectedItem);

                //Проверить открыто ли соединение
                if(!serialP.IsOpen)
                {
                    //Открыть соединение, если было закрыто
                    serialP.Open();
                }
                
                //Отправить пакет данных
                serialP.Write(Package);
            }
            catch
            {
                //Сообщение об ошибке связи с пультом
                MetroMessageBox.Show(this,
                    "Подключите пульт к компьютеру, выберите из списка нужный порт, затем повторите попытку.",
                    "Ошибка загрузки сценария",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Прием данных от пульта

        //Делегат передачи прочитанных данных
        private delegate void ReceivedEvent(string text);

        //Событие приема данных от пульта
        private void serialP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Запись считанных данных в переменную до ключа
            string ReadData = serialP.ReadTo("!");

            //Вызов метода через делегат 
            this.BeginInvoke(new ReceivedEvent(MessageConsole), ReadData);

        }

        //Метод обработки ключей от пульта
        private void MessageConsole(string DataReceived)
        {
            //Ключ подтверждения корректных данных
            if (DataReceived == "@")
            {
                //Сообщение об успешной записи данных в пульт
                MetroMessageBox.Show(this,
                    "Сценарий был успешно записан в пульт",
                    "Загрузка сценария",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            //Закрыть соединение
            serialP.Close();
        }

        #endregion

        #region Фильтр символов при вводе в ячейку

        private void CheckNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Ссылки на внешние ресурсы

        //Ссылка на канал "youtube.com"
        private void youtubeLink_Click(object sender, EventArgs e)
        {
            //Вызов метода перехода по ссылке
            Process.Start("https://www.youtube.com/c/SLABORATORY");
        }

        //Ссылка на яндекс "yasobe.ru"
        private void donateLink_Click(object sender, EventArgs e)
        {
            //Вызов метода перехода по ссылке
            Process.Start("Promote.txt");
        }

        #endregion
  
    }
}
