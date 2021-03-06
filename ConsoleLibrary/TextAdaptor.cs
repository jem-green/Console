using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace ConsoleLibrary
{
    public class TextAdaptor : Adaptor
    {
        #region Fields

        protected RasterFont _font;
        protected ConsoleColor _foreground;
        protected ConsoleColor _background;

        public enum ConsoleColor : byte
        {
            Black = 0,
            DarkBlue = 1,
            DarkGreen = 2,
            DarkCyan = 3,
            DarkRed = 4,
            DarkMagenta = 5,
            DarkYellow = 6,
            Gray = 7,
            DarkGray = 8,
            Blue = 9,
            Green = 10,
            Cyan = 11,
            Red = 12,
            Magenta = 13,
            Yellow = 14,
            White = 15
        }

        #endregion
        #region Constructors

        public TextAdaptor(int width, int height) : base(width,height,1,1)
        {
            _mode = Mode.text;
            _memory = new byte[_width * _height * 2];
        }

        public TextAdaptor(int width, int height, int scale) : base(width, height, scale, 1)
        {
            _mode = Mode.text;
            _memory = new byte[_width * _height * 2];
        }

        public TextAdaptor(int width, int height, int scale, int aspect) : base(width, height, scale, aspect)
        {
            _mode = Mode.text;
            _memory = new byte[_width * _height * 2];
        }

        #endregion
        #region Properties

        public ConsoleColor ForegroundColor
        {
            set
            {
                _foreground = value;
            }
        }

        public ConsoleColor BackgroundColor
        {
            set
            {
                _background = value;
            }
        }

        #endregion
        #region Methods

        #endregion
        #region Private

        #endregion
    }
}
