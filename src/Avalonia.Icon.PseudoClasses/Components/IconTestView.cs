using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Avalonia.Icon.PseudoClasses.Components
{
    public sealed class IconTestView : TemplatedControl
    {
        private const string True = ":true";
        private const string False = ":false";

        public static readonly StyledProperty<bool> IsTrueProperty = AvaloniaProperty.Register<IconTestView, bool>(nameof(IsTrue));

        public bool IsTrue
        {
            get => GetValue(IsTrueProperty);
            set => SetValue(IsTrueProperty, value);
        }

        protected override Type StyleKeyOverride => typeof(IconTestView);

        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);
            if (change.Property.Name is nameof(IsTrue))
            {
                PseudoClasses.Set(True, IsTrue);
                PseudoClasses.Set(False, !IsTrue);
            }
        }
    }
}
