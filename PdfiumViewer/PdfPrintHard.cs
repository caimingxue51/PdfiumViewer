using System;
using System.Collections.Generic;
using System.Text;

namespace PdfiumViewer
{
    public class PdfPrintHard
    {
        /// <summary>
        /// Gets to print horizontally.
        /// </summary>
        public int HardMarginX { get; }

        /// <summary>
        /// Gets to print vertically.
        /// </summary>
        public int HardMarginY { get; }
        public PdfPrintHard(int x, int y)
        {
            HardMarginX = x;
            HardMarginY = y;
        }
    }
}
