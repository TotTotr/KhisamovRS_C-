using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAttackAircraft
{
    public class Aircraft : FlyingObject
    {
        protected const int carWidth = 100;
        protected const int carHeight = 60;
        public Aircraft(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Aircraft(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawAircraft(Graphics g)
        {
            Brush br = new SolidBrush(MainColor);
            g.FillEllipse(br, _startPosX + 30, _startPosY - 10, 100, 20);
            g.FillEllipse(br, _startPosX + 30, _startPosY - 10 - 10, 9, 20);

            Brush br1 = new SolidBrush(Color.DarkBlue);
            g.FillEllipse(br1, _startPosX + 60, _startPosY - 5, 30, 8);
            Brush br2 = new SolidBrush(Color.Black);

            g.FillEllipse(br2, _startPosX + 85, _startPosY - 12, 5, 20);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}

