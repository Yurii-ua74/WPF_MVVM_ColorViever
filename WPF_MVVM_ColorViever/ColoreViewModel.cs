using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_ColorViever
{
    public class ColoreViewModel 
    {
        public static string GetColorSum(byte a, byte r, byte g, byte b)
            => $"#{a:X2}{r:X2}{g:X2}{b:X2}";
    }

}
