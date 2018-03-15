using System;
using System.Collections.ObjectModel;

using WindowsTemplateSample.Helpers;
using WindowsTemplateSample.Models;
using WindowsTemplateSample.Services;

namespace WindowsTemplateSample.ViewModels
{
    public class Chart1ViewModel : Observable
    {
        public Chart1ViewModel()
        {
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetChartSampleData();
            }
        }
    }
}
