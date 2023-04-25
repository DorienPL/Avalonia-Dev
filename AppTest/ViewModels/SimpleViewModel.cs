using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppTest.ViewModels
{
    public class SimpleViewModel: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string? _Name = "test"; // This is our backing field for Name

        public string? Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                // We only want to update the UI if the Name actually changed, so we check if the value is actually new
                if (_Name != value)
                {
                    // 1. update our backing field
                    _Name = value;

                    // 2. We call RaisePropertyChanged() to notify the UI about changes. 
                    // We can omit the property name here because [CallerMemberName] will provide it for us.  
                    RaisePropertyChanged();
                }
            }
        }


    }

}