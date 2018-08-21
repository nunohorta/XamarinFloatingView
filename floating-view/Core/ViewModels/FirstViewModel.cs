using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCross.Navigation;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }

        public async Task OpenFloatView()
        {
            await Mvx.Resolve<IMvxNavigationService>().Navigate<FloatingViewModel>();
        }
    }
}
