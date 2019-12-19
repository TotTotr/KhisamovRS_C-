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
        public bool Turbines { private set; get; }
        public bool Propeller { private set; get; }
        public bool Flag { private set; get; }

        public AttackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool turbines,
            bool propeller, bool flag) :
            base(maxSpeed, weight, mainColor)
        {

            DopColor = dopColor;
            Turbines = turbines;
            Propeller = propeller;
            Flag = flag;

        }
        public override void DrawAircraft(Graphics g)
        {

            base.DrawAircraft(g);
            if (Propeller)
            {
                Brush br2 = new SolidBrush(Color.Black);

                g.FillEllipse(br2, _startPosX + 90, _startPosY + 4, 10, 5);
            }
            if (Turbines)
            {
                Brush br2 = new SolidBrush(Color.Black);

                g.FillEllipse(br2, _startPosX + 35, _startPosY - 22, 5, 20);
            }

            if (Flag)
            {
                Brush br2 = new SolidBrush(Color.Black);
                g.FillEllipse(br2, _startPosX + 60, _startPosY + 4, 10, 5);
                g.FillEllipse(br2, _startPosX + 75, _startPosY + 4, 10, 5);
            }
        }
    }
}

