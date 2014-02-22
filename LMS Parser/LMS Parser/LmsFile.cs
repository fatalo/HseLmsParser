using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Parser
{
    public class LmsFile : IComparer<LmsFile>
    {
        int _id;
        string _url;
        string _filename;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value < 0)
                    throw new Exception("Id не может быть отрицательным числом!");
                _id = value;
            }
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }


        public LmsFile(int id, string filename)
        {
            Id = id;
            Url = "http://lms.hse.ru/view_file.php?file=" + _id + "&action=download";
            Filename = filename;
        }

        /// <summary>
        /// Реализация интерфейса IComparer
        /// </summary>
        public int Compare(LmsFile x, LmsFile y)
        {
            if (x.Id > y.Id)
                return 1;
            if (x.Id == y.Id)
                return 0;
            return -1;
        }
    }
}
