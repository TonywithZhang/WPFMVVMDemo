using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.ViewModels
{
    /// <summary>
    /// MainView的ViewModel
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// 实现INotifyPropertyChanged接口
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// 自动通知属性变更
        /// </summary>
        /// <param name="propertyName"></param>
        public void RaisePropertyChaged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
    }
}
