using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HotReloadIssue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCell : ViewCell
    {
        public MyCell()
        {
            InitializeComponent();
        }
    }
}