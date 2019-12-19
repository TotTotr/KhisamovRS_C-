using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



namespace WindowsFormsAttackAircraft
{

    public class AttackAircraft
    {

        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private const int AttackAircraftWidth = 200;
        private const int AttackAircraftHeight = 200;
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public Color DopColor2 { private set; get; }
        public bool Turbines { private set; get; }
        public bool Propeller { private set; get; }
        public AttackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor, Color dopColor2,
           bool turbines, bool propeller)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            DopColor2 = dopColor2;
            Turbines = turbines;
            Propeller = propeller;

        }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + 40 + step < 800)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - 50 - step > -80)

                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step - 10 > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step + 30 < _pictureHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawAttackAircraft(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            Brush br = new SolidBrush(MainColor);
            g.FillEllipse(br, _startPosX + 30, _startPosY - 10, 100, 20);
            g.FillEllipse(br, _startPosX + 30, _startPosY - 10 - 10, 9, 20);
            Brush br1 = new SolidBrush(DopColor);
            g.FillEllipse(br1, _startPosX + 60, _startPosY - 5, 30, 8);
            Brush br2 = new SolidBrush(Color.Black);
            g.FillEllipse(br2, _startPosX + 60, _startPosY + 4, 10, 5);
            g.FillEllipse(br2, _startPosX + 75, _startPosY + 4, 10, 5);
            g.FillEllipse(br2, _startPosX + 85, _startPosY - 12, 5, 20);


            if (Propeller)
            {
                g.FillEllipse(br2, _startPosX + 35, _startPosY - 22, 5, 20);
            }

            if (Turbines)
            {
                g.FillEllipse(br2, _startPosX + 90, _startPosY + 4, 10, 5);
            }
        }
    }
}

