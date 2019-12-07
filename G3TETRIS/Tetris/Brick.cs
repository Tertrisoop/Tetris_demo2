using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
   public class Brick
    {
        private int m_posX, m_posY;
        private int m_color;
        private int m_rotacion;
        private Formatcs[] formas = new Formatcs[constants.numrolate];
        //fomas = các hình thức

        public Brick() { }

        public Brick(string formaPiezaRotacion1, string formaPiezaRotacion2, string formaPiezaRotacion3, string formaPiezaRotacion4, int color)
        {
            m_color = color;
            m_rotacion = 0;
            formas[0] = new Formatcs(formaPiezaRotacion1);
            formas[1] = new Formatcs(formaPiezaRotacion2);
            formas[2] = new Formatcs(formaPiezaRotacion3);
            formas[3] = new Formatcs(formaPiezaRotacion4);
            m_posX = 6;
            m_posY = 0 - ccao + 1;
        }

        public int this[int y, int x]
        {
            get
            {
                
                return ((Formatcs)formas[m_rotacion])[y, x];
            }
            set
            {
                
                    ((Formatcs)formas[m_rotacion])[y, x] = value;
                
            }
        }

        public int crong        //chiều rộng
        {
            get
            {
                return ((Formatcs)formas[m_rotacion]).crong;
            }
        }

        public int ccao     //chiều cao
        {
            get
            {
                return ((Formatcs)formas[m_rotacion]).ccao;
            }
        }

        public int posX
        {
            get
            {
                return m_posX;
            }
            set
            {
                m_posX = value;
            }
        }

        public int posY
        {
            get
            {
                return m_posY;
            }
            set
            {
                m_posY = value;
            }
        }

        public int color
        {
            get
            {
                return m_color;
            }
            set
            {
                m_color = value;
            }
        }

        public void rolate()      //xoay qua phải
        {
            if (m_rotacion < constants.numrolate - 1)
                m_rotacion++;
            else
                m_rotacion = 0;
        }

       
        

        public object Clone()
        {
            Brick p = new Brick();
            p.formas = (Formatcs[])this.formas.Clone();
            p.m_posY = this.posY;
            p.m_posX = this.posX;
            p.m_color = this.color;
            p.m_rotacion = this.m_rotacion;
            return p;
        }

    }
}
