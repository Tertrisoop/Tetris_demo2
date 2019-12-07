using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Formatcs
    {
        public int crong { get; set; }
        public int ccao { get; set; }
        private int[,] m_matrizPieza = new int[constants.xbrick, constants.ybrick];

        public Formatcs(string formaPieza)
        {
            if (formaPieza.Length != constants.xbrick * constants.ybrick)
                throw new Exception("Phần này là " + constants.xbrick * constants.ybrick + " vuông");
            else
            {
                int bloque = 0;
                crong = 0;
                ccao = 0;
                for (int y = 0; y < constants.xbrick; y++)
                {
                    for (int x = 0; x < constants.ybrick; x++)
                    {
                        bloque = System.Int32.Parse(formaPieza.Substring((4 * y) + x, 1));
                        if (bloque == 1)
                        {
                            if (ccao < y + 1)
                                ccao = y + 1;
                            if (crong < x + 1)
                                crong = x + 1;
                        }
                        m_matrizPieza[y, x] = bloque;
                    }
                }
            }
        }

        //thiết lập mảng không vượt quá số dòng cột quy định
        public int this[int y, int x]
        {
            get
            {
                    return m_matrizPieza[y, x];
            }
            set
            {
                    m_matrizPieza[y, x] = value;
            }
        }

       
    }
}
