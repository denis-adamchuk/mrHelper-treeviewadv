using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aga.Controls
{
   internal static class WinFormsHelpers
   {
      public static double ScalePixelsToNewDpi(int oldDpi, int newDpi, int pixels) => pixels * newDpi / (double)oldDpi;
   }
}

