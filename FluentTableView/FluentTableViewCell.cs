using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;

namespace FluentTableView
{
    public abstract class MvxFluentTableViewCell : MvxTableViewCell
    {
        private bool _didSetupConstraints;

        protected MvxFluentTableViewCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(Bind);
        }
        
        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            if (!_didSetupConstraints) SetupConstraints();
            _didSetupConstraints = true;
        }

        protected virtual void SetupConstraints()
        {
        }

        protected virtual void Bind()
        {
        }
    }
}