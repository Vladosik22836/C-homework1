using System;

namespace Graphics
{
    public enum ColorFormat { RGB, HEX, HSL, CMYK }

    public struct RgbColor
    {
        public byte R, G, B;

        // Переведення в HEX
        public string ToHex() => $"#{R:X2}{G:X2}{B:X2}";

        // Переведення в HSL
        public void ToHsl(out double h, out double s, out double l)
        {
            double rf = R / 255.0, gf = G / 255.0, bf = B / 255.0;
            double max = Math.Max(rf, Math.Max(gf, bf)), min = Math.Min(rf, Math.Min(gf, bf));
            double delta = max - min;

            l = (max + min) / 2.0;
            if (delta == 0) h = s = 0;
            else
            {
                s = l > 0.5 ? delta / (2.0 - max - min) : delta / (max + min);
                if (max == rf) h = (gf - bf) / delta + (gf < bf ? 6 : 0);
                else if (max == gf) h = (bf - rf) / delta + 2;
                else h = (rf - gf) / delta + 4;
                h *= 60;
            }
            s *= 100; l *= 100;
        }

        // Переведення в CMYK
        public void ToCmyk(out double c, out double m, out double y, out double k)
        {
            double rf = R / 255.0, gf = G / 255.0, bf = B / 255.0;
            k = 1.0 - Math.Max(rf, Math.Max(gf, bf));
            if (k == 1.0) c = m = y = 0;
            else
            {
                c = (1.0 - rf - k) / (1.0 - k) * 100;
                m = (1.0 - gf - k) / (1.0 - k) * 100;
                y = (1.0 - bf - k) / (1.0 - k) * 100;
            }
            k *= 100;
        }
    }

    class Program
    {
        static void Main()
        {
            RgbColor myColor = new RgbColor { R = 255, G = 100, B = 50 };
            Console.WriteLine($"HEX: {myColor.ToHex()}");

            myColor.ToHsl(out double h, out double s, out double l);
            Console.WriteLine($"HSL: {h:F1}°, {s:F1}%, {l:F1}%");
        }
    }
}