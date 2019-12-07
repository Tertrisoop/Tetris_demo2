using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tetris
{
    class constants
    {
        public const int xbrick = 4;          //dòng
        public const int ybrick = 4;       //cột
        public const int numbrick = 7;            // số lượng các khối
        public const int numrolate = 4;        //số lượng kiểu xoay
        public const int playzonerow = 21;       //hiển thị dòng
        public const int playzonecol = 13;    //hiển thị cột
        public const int witdh = 20;          //chiều rộng
        public const int heigth = 20;           //chiều cao 
        public const int scountlv = 20; //số lượng dòng của cấp

        //các màu dành cho các khối gạch
        private static Color[] m_COLOR = new Color[7] { Color.Red, Color.Blue, Color.DarkOrange, Color.DeepPink, Color.Violet, Color.Beige, Color.DarkMagenta };

        //tốc độ chạy của game tăng dần theo từng level
        private static int[] m_level = new int[10] { 1000, 800, 640, 512, 410, 328, 262, 210, 168, 134 };


        public static Color COLORES(int color)
        {
            return m_COLOR[color];
        }

        public static int NIVELES(int lv)
        {
            return m_level[lv];
        }
    }
}
