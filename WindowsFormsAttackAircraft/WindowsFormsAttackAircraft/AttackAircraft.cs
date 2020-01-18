using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAttackAircraft
{
    /// <summary>
    /// Класс отрисовки штурмовика
    /// </summary>
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

        public AttackAircraft(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Turbines = Convert.ToBoolean(strs[4]);
                Propeller = Convert.ToBoolean(strs[5]);
                Flag = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawAircraft(Graphics g)
        {

            base.DrawAircraft(g);
            if (Propeller)
            {
                Brush br1 = new SolidBrush(DopColor);
                g.FillEllipse(br1, _startPosX + 35, _startPosY - 22, 5, 20);
            }

            if (Turbines)
            {
                Brush br2 = new SolidBrush(Color.DarkGray);
                g.FillEllipse(br2, _startPosX + 60, _startPosY + 4, 10, 5);
                g.FillEllipse(br2, _startPosX + 75, _startPosY + 4, 10, 5);
                g.FillEllipse(br2, _startPosX + 90, _startPosY + 4, 10, 5);
            }



            if (Flag)
            {
                Brush b = new SolidBrush(Color.Red);
                g.FillRectangle(b, _startPosX + 110, _startPosY + 4, 30, 2);
            }

        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + Turbines + ";" + Propeller + ";" + Flag;
        }

    }
}

