namespace AngleExample
{
    public class Angle
    {
        public int Degrees { get; private set; }
        public int Minutes { get; private set; }

        public Angle(int degrees, int minutes)
        {
            if (minutes < 0 || minutes >= 60)
            {
                throw new ArgumentOutOfRangeException(nameof(minutes), "������ ������ ���� � ��������� �� 0 �� 59.");
            }

            Degrees = degrees;
            Minutes = minutes;
            Normalize();
        }

        // ������� � �������
        public double ToRadians()
        {
            return (Degrees + Minutes / 60.0) * Math.PI / 180.0;
        }

        // ���������� � ��������� 0-360
        private void Normalize()
        {
            while (Degrees < 0)
            {
                Degrees += 360;
            }

            while (Degrees >= 360)
            {
                Degrees -= 360;
            }
        }

        // ���������� ���� �� �������� ��������
        public void Increase(int degrees, int minutes)
        {
            Degrees += degrees;
            Minutes += minutes;
            Normalize();
        }

        // ���������� ���� �� �������� ��������
        public void Decrease(int degrees, int minutes)
        {
            Degrees -= degrees;
            Minutes -= minutes;
            Normalize();
        }

        // ��������� ������ ����
        public double Sin()
        {
            return Math.Sin(ToRadians());
        }

        // ��������� �����
        public static bool operator ==(Angle angle1, Angle angle2)
        {
            return angle1.Degrees == angle2.Degrees && angle1.Minutes == angle2.Minutes;
        }

        public static bool operator !=(Angle angle1, Angle angle2)
        {
            return !(angle1 == angle2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Angle angle)
            {
                return this == angle;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Degrees * 60 + Minutes;
        }

        public override string ToString()
        {
            return $"{Degrees}� {Minutes}'";
        }
    }
}

