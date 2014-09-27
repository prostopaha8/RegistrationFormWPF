using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class DataModel
    {
        private int id;
        private string name;
        private string surname;
        private string nickname;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public DataModel(int id,string name, string surname,string nickname)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = Surname;
            this.Nickname = nickname;
        }
    }
}
