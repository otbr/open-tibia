﻿#region Licence
/**
* Copyright © 2015-2018 OTTools <https://github.com/ottools/open-tibia>
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*/
#endregion

#region Using Statements
using System;
using System.Drawing;
#endregion

namespace OpenTibia.Controls
{
    public class ColorChangedArgs
    {
        #region Constructor

        public ColorChangedArgs(Color oldRgbColor, Color newRgbColor, int oldColor, int newColor)
        {
            this.OldRgbColor = oldRgbColor;
            this.NewRgbColor = newRgbColor;
            this.OldColor = oldColor;
            this.NewColor = newColor;
        }

        #endregion

        #region Public Properties

        public Color OldRgbColor { get; private set; }

        public Color NewRgbColor { get; private set; }

        public int OldColor { get; private set; }

        public int NewColor { get; private set; }

        #endregion
    }

    public delegate void ColorChangedHandler(object sender, ColorChangedArgs e);
}
