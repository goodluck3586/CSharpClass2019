using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace mook_Steganography
{
    class SteganographyConvert
    {
        enum State
        {
            hiding,
            filling_with_zeros
        };

        public delegate void ProcessEventHandler(int Current);
        public event ProcessEventHandler runNum;

        public Bitmap embedText(string HiddenText, Bitmap Imgbmp)
        {
            State s = State.hiding;

            int charIndex = 0;
            int charValue = 0;
            long colorUnitIndex = 0;

            int zeros = 0;

            int R = 0, G = 0, B = 0;

            int RunStatus = 0;

            Application.DoEvents();
            for (int i = 0; i < Imgbmp.Height; i++)
            {
                for (int j = 0; j < Imgbmp.Width; j++)
                {
                    Color pixel = Imgbmp.GetPixel(j, i);

                    pixel = Color.FromArgb(pixel.R - pixel.R % 2,
                        pixel.G - pixel.G % 2, pixel.B - pixel.B % 2);

                    R = pixel.R; G = pixel.G; B = pixel.B;

                    for (int n = 0; n < 3; n++)
                    {
                        ++RunStatus;
                        if (colorUnitIndex % 8 == 0)
                        {
                            if (zeros == 8)
                            {
                                if ((colorUnitIndex - 1) % 3 < 2)
                                {
                                    Imgbmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                runNum(RunStatus);
                                return Imgbmp;
                            }
                            if (charIndex >= HiddenText.Length)
                            {
                                s = State.filling_with_zeros;
                            }
                            else
                            {
                                charValue = HiddenText[charIndex++];
                            }
                        }

                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    if (s == State.hiding)
                                    {
                                        R += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (s == State.hiding)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (s == State.hiding)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }
                                    Imgbmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        colorUnitIndex++;

                        if (s == State.filling_with_zeros)
                        {
                            zeros++;
                        }
                    }
                }
            }
            Application.DoEvents();
            return Imgbmp;
        }
        public string ExtractText(Bitmap Imgbmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string ExtractedText = String.Empty;

            int RunStatus = 0;
            Application.DoEvents();
            for (int i = 0; i < Imgbmp.Height; i++)
            {
                for (int j = 0; j < Imgbmp.Width; j++)
                {
                    Color pixel = Imgbmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)
                    {
                        ++RunStatus;
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        if (colorUnitIndex % 8 == 0)
                        {
                            charValue = ReverseBits(charValue);

                            if (charValue == 0)
                            {
                                runNum(RunStatus);
                                return ExtractedText;
                            }

                            char c = (char)charValue;

                            ExtractedText += c.ToString();
                        }
                    }
                }
            }
            Application.DoEvents();
            return ExtractedText;
        }

        public static int ReverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }
            return result;
        }
    }
}