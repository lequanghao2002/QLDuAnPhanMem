using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDAPM
{
    public class ThemeManager
    {
        private static Color backgroundColor = Color.White;

        public static Color BackgroundColor
        {
            get { return backgroundColor; }
            set
            {
                backgroundColor = value;
                ApplyBackgroundColorToForms();
            }
        }

        private static void ApplyBackgroundColorToForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                if(form is IThemeable themeable)
                {
                    themeable.ApplyTheme(backgroundColor);
                }
            }
        }
        public static event EventHandler<Form> NewFormCreated;

        public static void OnNewFormCreated(Form form)
        {
            NewFormCreated?.Invoke(null, form);
        }
    }
}
