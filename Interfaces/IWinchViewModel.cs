using System;
using System.Collections.Generic;
using System.Text;

namespace SealenceDemo.Interfaces
{
    public interface IWinchViewModel
    {
        string Title { get; set; }
        float Load { get; set; }
        float PayedOut { get; set; }
        float Speed { get; set; }
    }
}
