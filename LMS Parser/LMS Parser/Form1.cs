using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ViKing.Engine;
using System.IO;

namespace LMS_Parser
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Список со спарсенными хедерами.
        /// </summary>
        List<LmsFile> _fileList;

        /// <summary>
        /// Очередь id'шников для скачки.
        /// </summary>
        Queue<int> idToDownload = new Queue<int>();

        /// <summary>
        /// Файлы cookie вне метода, чтобы был доступ у всех потоков.
        /// </summary>
        CookieCollection cook;

        /// <summary>
        /// Job-менеджер для многопоточности
        /// </summary>
        JobManager manager;

        /// <summary>
        /// Количество спаршенных файлов
        /// </summary>
        int numberOfCompleted = 0;

        public Form1()
        {
            InitializeComponent();

            _fileList = new List<LmsFile>();
            toNumberComboBox.SelectedIndex = 1;

            Log("Чтобы не уронить LMS, ограничиваю количество потоков.");
            Log("За компиляцию исходного кода без ограничений - ответственности не несу.");
        }

        /// <summary>
        /// Добавляет в конец сетки данных переданный объект.
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="lmsFile"></param>
        private void UpdateGrid(DataGridView dataGridView, LmsFile lmsFile)
        {
            if (lmsFile != null)
            {
                if (InvokeRequired)
                {
                    try
                    {
                        BeginInvoke(new Action(() => { dataGridView.Rows.Add(lmsFile.Id, lmsFile.Url, lmsFile.Filename); return; }));
                    }
                    catch (Exception ex)
                    {
                        Log(ex.Message);
                        return;
                    }
                }
                else
                {
                    dataGridView.Rows.Add(lmsFile.Id, lmsFile.Url, lmsFile.Filename);
                    return;
                }
            }

        }

        /// <summary>
        ///  Сортирует список объектов и выводит их на сетку данных.
        /// </summary>
        /// <param name="dataGridView"></param>
        private void UpdateGrid(DataGridView dataGridView)
        {

            if (_fileList.Any())
            {
                _fileList.Sort(
                    delegate(LmsFile x, LmsFile y)
                    {
                        if (x.Id > y.Id)
                            return 1;
                        if (x.Id == y.Id)
                            return 0;
                        return -1;
                    });
                dataGridView.Rows.Clear();
                foreach (var file in _fileList)
                {
                    dataGridView.Rows.Add(file.Id, file.Url, file.Filename);
                }
            }
            else
            {
                dataGridView.Rows.Clear();
            }


        }
        private void startParseButton_Click(object sender, EventArgs e)
        {
            int startId = (int)fromNumericUpDown.Value,
                count;

            try
            {
                count = int.Parse(toNumberComboBox.SelectedItem.ToString());
            }
            catch
            {
                MessageBox.Show("Выберите сколько штук парсить!");
                return;
            }

            StartParse(startId, count);
        }

        /// <summary>
        /// Записывает текущие действия в текстовое поле.
        /// </summary>
        /// <param name="logText">Текст для записи</param>
        private void Log(string logText)
        {
            if (logText == "")
                return;

            logText = String.Format("[ {0} ] {1}\r\n", DateTime.Now.ToString("HH:mm:ss"), logText);

            if (InvokeRequired)
                BeginInvoke(new Action(() => { logTextbox.Text += logText; numberOfCompletedLabel.Text = numberOfCompleted.ToString(); }));
            else
            {
                logTextbox.Text += logText;
                numberOfCompletedLabel.Text = numberOfCompleted.ToString();
            }
        }

        /// <summary>
        /// Подготовка к парсингу. Логинимся на сайте и начинаем парсить.
        /// </summary>
        /// <param name="startNumber">Начальный id парсинга</param>
        /// <param name="count">Число штук</param>
        public void StartParse(int startNumber, int count)
        {
            string query, head;
            cook = new CookieCollection();
            numberOfCompleted = 0;

            try
            {
                query = String.Format("login={0}&password={1}&submit_login={2}&_qf__login_form=",
                    loginTextbox.Text, passwordTextbox.Text, HttpUtility.UrlEncode("Войти"));

                VkRequest.Request("http://lms.hse.ru", cookies: cook);
                head = VkRequest.Request("http://lms.hse.ru/index.php?index_page", request: query, method: "POST", cookies: cook).Headers.ToString();

            }
            catch
            {
                Log("Не могу загрузить страницу!");
                return;
            }

            if (!head.Contains("efront"))
            {
                Log("Не могу зайти c данной парой логин/пароль!");
                return;
            }

            Log("Успешно залогинились!");

            // Заполняю очередь id'шниками для парсинга.
            for (int i = 0; i < count; ++i)
            {
                idToDownload.Enqueue(startNumber + i);
            }

            manager = new JobManager(StartDownload);
            manager.PreferredThreadCount = (int)threadsCountNumericUpDown.Value;
            manager.JobCompleted += (obj, args) => { Log(args.Reason); UpdateGrid(dataGridView1); UpdateGrid(dataGridView1); };
            manager.Start();
        }

        /// <summary>
        /// Парсинг заголовков файлов и их запись в список объектов.
        /// </summary>
        public void StartDownload()
        {
            HTTPHeaders header;
            int currentId;

            lock (idToDownload)
            {
                if (idToDownload.Count == 0)
                {
                    manager.StopJob("Закончили!");
                    return;
                }
                else
                {
                    currentId = idToDownload.Dequeue();
                }
            }

            try
            {
                LmsFile myFile = new LmsFile(currentId, "");
                header = VkRequest.Request(myFile.Url, cookies: cook, FollowRedirects: true).Headers;
                string filename = header["content-disposition"];
                if (filename != null)
                {
                    filename = HttpUtility.UrlDecode(
                        filename.Replace("attachment; filename= ", "")
                        ) + "\r\n";

                    myFile.Filename = filename;
                    AddObjectToList(myFile);

                    ++numberOfCompleted;

                    Log("Удачно получили id " + (currentId));
                    UpdateGrid(dataGridView1, myFile);
                }
                else
                {
                    Log((currentId).ToString() + "пустой!");
                }
            }
            catch (Exception ex)
            {
                Log("По причине ниже не смог получить заголовки!");
                Log(ex.Message);
            }
        }

        /// <summary>
        /// Потокобезопасный метод добавления объекта в список.
        /// </summary>
        /// <param name="file">Передаваемый объект</param>
        private void AddObjectToList(LmsFile file)
        {
            if (InvokeRequired)
                BeginInvoke(new Action(() => { _fileList.Add(file); }));
            else
                _fileList.Add(file);
        }

        /// <summary>
        /// Очищает список объектов и сетку данных.
        /// </summary>
        private void ClearDataGrid()
        {
            _fileList = new List<LmsFile>();
            this.UpdateGrid(this.dataGridView1);
        }

        private void fromNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveAstxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция пока не работает!","Ведутся работы");
        }




    }
}
