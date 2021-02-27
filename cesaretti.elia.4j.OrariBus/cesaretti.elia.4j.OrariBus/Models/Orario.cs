using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace cesaretti.elia._4j.OrariBus.Models
{
    class Orario
    {
        private int _ore;
        private int _minuti;
        public int ore { get; set; }
        public int minuti
        {
            get
            {
                return _minuti;
            }
            set
            {
                if (value >= 60)
                {
                    _minuti = value - 60;
                    _ore++;
                }
                else
                {
                    _minuti = value;
                }
            }
        }
        public Orario()
        {
            _ore = 0;
            _minuti = 0;
        }

        public Orario(int o, int m)
        {
            _ore = o;
            _minuti = m;
        }
        public int GetMinuti()
        {
            return minuti;
        }
        public void SetMinuti(int m)
        {
            /*if (m >= 60)
            {
                minuti = m - 60;
                ore++;
            }
            else
            {
                minuti = m;
            }*/
        }
        public int GetOre()
        {
            return ore;
        }
        public void SetOre(int o)
        {
            ore = o % 24;
        }
        public string Visualizza()
        {
            string o = "";
            o = $"{_ore}:{_minuti}";
            return o;
        }
    }
}
