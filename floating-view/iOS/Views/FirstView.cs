using System;
using Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;

namespace iOS.Views
{
    [MvxFromStoryboard]
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        public FirstView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
            set.Apply();

            GoButton.TouchUpInside += async (sender, e) =>
            {
                await ViewModel.OpenFloatView();
            };
        }
    }
}
