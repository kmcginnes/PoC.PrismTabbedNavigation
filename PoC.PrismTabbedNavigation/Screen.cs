using System;
using Microsoft.Practices.Prism;

namespace PoC.PrismTabbedNavigation
{
    public interface IConfirmDeactivate
    {
        bool ConfirmDeactivation();
    }

    public class Screen : IActiveAware, IConfirmDeactivate
    {
        private bool _isActive;
        public string Title { get; set; }

        public Screen()
        {
            Title = GetType().Name;
            IsActiveChanged += Screen_IsActiveChanged;
        }

        void Screen_IsActiveChanged(object sender, EventArgs e)
        {
            
        }

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                if (value)
                    OnActivate();
                else
                    OnDeactivate();
                if (IsActiveChanged != null)
                    IsActiveChanged(this, new EventArgs());
            }
        }

        protected virtual void OnActivate()
        {
        }

        protected virtual void OnDeactivate()
        {
        }

        public event EventHandler IsActiveChanged;
        public virtual bool ConfirmDeactivation()
        {
            return true;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}