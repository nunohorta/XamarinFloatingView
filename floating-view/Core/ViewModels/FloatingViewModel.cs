using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using MvvmCross;

namespace Core
{
    public class FloatingViewModel : MvxViewModel
    {
        public async Task Dismiss()
        {
            await Mvx.Resolve<IMvxNavigationService>().Close(this);
        }
    }
}
