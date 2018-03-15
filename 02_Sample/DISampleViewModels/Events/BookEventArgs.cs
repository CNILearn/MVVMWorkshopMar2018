using DISampleViewModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISampleViewModels.Events
{
    public class BookEventArgs : EventArgs
    {
        public Book Book { get; set; }
    }
}
