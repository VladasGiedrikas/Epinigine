using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandymasSuDuomenim
{
    public class Islaidos
    {
        public int Id { get; set; }
        public int IslaidosMaistui { get; set; }
        public int IslaidosTransportui { get; set; }
        public int IslaidosKitos { get; set; }
        public int BendrasBiudzetas { get; set; }
        public string FullInfo
        {
            get
            {
                return $"{IslaidosMaistui} {IslaidosTransportui} {IslaidosKitos}";
            }

        }
    }
}
