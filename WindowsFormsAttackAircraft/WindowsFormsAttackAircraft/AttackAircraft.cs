using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAttackAircraft
{
    public class AttackAircraft : Aircraft
    {
        public Color DopColor { private set; get; }
        public bool Vint { private set; get; }
        public bool Pulemet { private set; get; }
        public bool Bombs { private set; get; }
        public AttackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool vint,
            bool pulemet, bool bombs) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            Vint = vint;
            Pulemet = pulemet;
            Bombs = bombs;
        }
        public override void DrawAircraft(Graphics g)
        {
            base.DrawAircraft(g);
            if (Pulemet)
            {
                Brush br1 = new SolidBrush(DopColor);
                g.FillRectangle(br1, _startPosX + 110, _startPosY + 4, 30, 2);
            }
            if (Vint)
            {
                Brush br2 = new SolidBrush(Color.Black);
                g.FillEllipse(br2, _startPosX + 35, _startPosY - 22, 5, 20);
            }
            if (Bombs)
            {
                Brush b = new SolidBrush(Color.Black);
                g.FillEllipse(b, _startPosX + 60, _startPosY + 4, 10, 5);
                g.FillEllipse(b, _startPosX + 75, _startPosY + 4, 10, 5);
                g.FillEllipse(b, _startPosX + 90, _startPosY + 4, 10, 5);

            }
        }
    }
}

