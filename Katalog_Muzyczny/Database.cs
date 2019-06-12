using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katalog_Muzyczny
{
    class Database
    {
        private FileStream fs = null;
        private StreamWriter sw = null;
        private StreamReader sr = null;
        private string dataPath = @"c:\temp\katalogmuzyczny\database.txt";
        
        public int Entries()
        {
            int count = 0;
            CreateFile();
            try
            {
                fs = new FileStream(dataPath, FileMode.Open);
                if(fs.Length > 0)
                {
                    sr = new StreamReader(fs);
                    while (sr.ReadLine() != null)
                    {
                        count++;
                    }
                    sr.Close();
                }
                fs.Close();
            }
            catch
            {
                count = 0;
            }
            return count;
        }

        public string Select(string key, int id)
        {
            int count = 0;
            string result = "";
            CreateFile();
            try
            {
                fs = new FileStream(dataPath, FileMode.Open);
                sr = new StreamReader(fs);
                string temp = "";
                bool flag = true;
                while(flag == true)
                {
                    if((temp = sr.ReadLine()) == null)
                    {
                        sr.Close();
                        fs.Close();
                        flag = false;
                    } else
                    {
                        string[] s = temp.Split(';');
                        string column = s[id];
                        if (column.Contains(key))
                        {
                            result += count + ";";
                        }
                        count++;
                    }
                }
            }
            catch
            {
                result = "error";
            }
            return result;
        }

        

        public bool ReadEntry(int id, ref Album album)
        {
            int count = 0;
            CreateFile();
            try
            {
                string temp = "";
                bool flag = true;
                fs = new FileStream(dataPath, FileMode.Open);
                sr = new StreamReader(fs);
                while (flag == true)
                {
                    if ((temp = sr.ReadLine()) == null)
                    {
                        sr.Close();
                        fs.Close();
                        flag = false;
                        if (count == 0) return false;
                    }
                    if (count == id)
                    {
                        string[] s = temp.Split(';');
                        album.Name = s[0];
                        album.Artist = s[1];
                        album.Style = s[2];
                        album.Label = s[3];
                        album.Format = s[4];
                        album.Year = Int32.Parse(s[5]);
                        album.Country = s[6];
                        album.Cost = float.Parse(s[7]);
                    }
                    count++;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool InsertEntry(Album album)
        {
            CreateFile();
            //int id = Entries();
            try
            {
                fs = new FileStream(dataPath, FileMode.Append);
                sw = new StreamWriter(fs);
                sw.WriteLine($"{album.Name};{album.Artist};{album.Style};{album.Label};{album.Format};{album.Year};{album.Country};{album.Cost}");
                sw.Close();
                fs.Close();
                return true;
            }
            catch (Exception ee)
            {
                string temp = ee.Message;
                return false;
            }
        }
        public bool UpdateEntry(int id, Album album)
        {
            int count = 0;
            CreateFile();
            try
            {
                fs = new FileStream(dataPath, FileMode.Open);
                sr = new StreamReader(fs);
                string temp = "";
                string temp2 = "";
                while((temp = sr.ReadLine()) != null)
                {
                    if(count == id)
                    {
                        temp2 += $"{album.Name};{album.Artist};{album.Style};{album.Label};{album.Format};{album.Year};{album.Country};{album.Cost}\r\n";
                    } else
                    {
                        temp2 += temp + "\r\n";
                    }
                    count++;
                }
                sr.Close();
                fs.Close();
                fs = new FileStream(dataPath, FileMode.Create);
                sw = new StreamWriter(fs);
                sw.Write(temp2);
                sw.Close();
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteEntry(int id)
        {
            int count = 0;
            CreateFile();
            try
            {
                fs = new FileStream(dataPath, FileMode.Open);
                sr = new StreamReader(fs);
                string temp = "";
                string temp2 = "";
                while((temp = sr.ReadLine()) != null)
                {
                    if(count != id)
                    {
                        temp2 += temp + "\r\n";
                    }
                    count++;
                }
                sr.Close();
                fs.Close();
                fs = new FileStream(dataPath, FileMode.Create);
                sw = new StreamWriter(fs);
                sw.Write(temp2);
                sw.Close();
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool CreateFile()
        {
            try
            {
                if (!File.Exists(dataPath))
                {
                    string tempPath = System.IO.Path.GetDirectoryName(dataPath);
                    if (!Directory.Exists(tempPath))
                    {
                        Directory.CreateDirectory(tempPath);
                    }
                    fs = new FileStream(dataPath, FileMode.CreateNew);
                    fs.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
