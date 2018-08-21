using Core;
using CoreGraphics;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.Presenters.Attributes;
using UIKit;

namespace iOS
{
    [MvxModalPresentation(ModalPresentationStyle = UIModalPresentationStyle.OverFullScreen, ModalTransitionStyle = UIModalTransitionStyle.CoverVertical)]
    public partial class FloatingView : MvxViewController<FloatingViewModel>
    {
        enum SwipeDirection
        {
            Horizontal,
            Vertical,
            None
        };

        enum ViewState
        {
            Fullscreen,
            Floating
        };

        public FloatingView() : base("FloatingView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TransitioningDelegate = new TransitioningDelegate();

            DismissButton.TouchUpInside += async (sender, e) =>
            {
                await ViewModel.Dismiss();
            };



        }
    }

    public class TransitioningDelegate : UIViewControllerTransitioningDelegate
    {
        public override IUIViewControllerAnimatedTransitioning GetAnimationControllerForPresentedController(UIViewController presented, UIViewController presenting, UIViewController source)
        {
            return new CustomTransitionAnimator();
        }
    }

    public class CustomTransitionAnimator : UIViewControllerAnimatedTransitioning
    {
        float length = 0.5f;

        public CustomTransitionAnimator()
        {
        }

        public override double TransitionDuration(IUIViewControllerContextTransitioning transitionContext)
        {
            return length;
        }

        public override void AnimateTransition(IUIViewControllerContextTransitioning transitionContext)
        {
            var inView = transitionContext.ContainerView;
            var fromVC = transitionContext.GetViewControllerForKey(UITransitionContext.FromViewControllerKey);
            var fromView = fromVC.View;
            var toVC = transitionContext.GetViewControllerForKey(UITransitionContext.ToViewControllerKey);
            var toView = toVC.View;
            var frame = toView.Frame;
            inView.AddSubview(toView);
            var y = UIScreen.MainScreen.Bounds.Height;
            var height = UIScreen.MainScreen.Bounds.Height;
            var width = UIScreen.MainScreen.Bounds.Width;

            toView.Frame = new CGRect(0, y, width, height);

            UIView.Animate(TransitionDuration(transitionContext), () =>
            {
                toView.Frame = new CGRect(0, UIApplication.SharedApplication.StatusBarFrame.Size.Height, width, height);
            }, () =>
            {
                transitionContext.CompleteTransition(true);
            });
        }
    }
}

