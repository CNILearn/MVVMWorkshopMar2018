using DISampleViewModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace UWPSample.Services
{
    class UWPShowMessageService : IShowMessageService
    {
        public async Task ShowMessageAsync(string message) => 
            await new MessageDialog(message).ShowAsync();
    }
}
