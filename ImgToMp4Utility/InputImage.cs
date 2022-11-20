using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class InputImage
    {
        public string FullPath => path;
        private string path;
        public string Name => name;
        private string name;

        public string Extension => extension;
        private string extension;

        public int Number => number;
        private int number;

        public InputImage(string path)
        {
            this.path = path;
            this.name = Path.GetFileNameWithoutExtension(path);
            this.extension = Path.GetExtension(path);
            
        }

        public bool HasExtension(string extension)
        {
            if (!String.IsNullOrEmpty(this.extension))
            {
                return this.extension == extension;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateNumber(string prefix,string suffix, out int number)
        {
            string text = name;
            text = text.StartsWith(prefix) ? text.Substring(prefix.Length) : name;
            text = text.EndsWith(suffix) ? text.Substring(0, text.Length - suffix.Length) : text;
            if(int.TryParse(text, out number))
            {
                this.number = number;
                return true;
            }
            //else
            this.number = -1;
            return false;   
        }
        public override string ToString()
        {
            return name;
        }
    }
}
