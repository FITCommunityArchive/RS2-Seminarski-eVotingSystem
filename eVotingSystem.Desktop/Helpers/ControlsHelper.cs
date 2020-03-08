using eVotingSystem.CORE.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eVotingSystem.Desktop.Helpers
{
    public static class ControlsHelper
    {
        public static void MapPropsToControls<T>(T model, Control rootControl)
        {
            foreach (var prop in model.GetType().GetProperties())
            {
                SetControlValue(rootControl, prop.Name, prop.GetValue(model, null));
            }
        }

        public static T MapControlsToProps<T>(T model, Control rootControl)
        {
            foreach (var prop in model.GetType().GetProperties())
            {
                try
                {
                    var value = GetControlValue(rootControl, prop.Name);
                    if (value != ObjectExtension.GetDefaultTypeValue(prop.PropertyType))
                    {
                        if (prop.PropertyType == typeof(double))
                        {
                            prop.SetValue(model, double.Parse((string)value));
                        }
                        else
                        {
                            prop.SetValue(model, value);
                        }
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return model;
        }
        
        public static object GetControlValue(Control container, string propName)
        {
            object result = null;

            foreach (Control control in container.Controls)
            {
                try
                {
                    if (control.Name.RemoveControlPrefix() == propName)
                    {
                        result = GetValue(control);
                        return result;
                    }

                    result = GetControlValue(control, propName);
                }
                catch (Exception)
                {
                    continue;
                }
            }

            return result;
        }


        public static void SetControlValue(Control container, string propName, object propValue)
        {
            foreach (Control control in container.Controls)
            {
                try
                {
                    if (control.Name.RemoveControlPrefix() == propName)
                    {
                        SetValue(control, propValue);
                        return;
                    }

                    SetControlValue(control, propName, propValue);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        public static string RemoveControlPrefix(this string name)
        {
            name += "A";
            var firstCapitalLetter = name.IndexOf(name.FirstOrDefault(x => Char.IsUpper(x)));
            if (firstCapitalLetter == name.Length - 1)
            {
                return string.Empty;
            }

            return name.Substring(firstCapitalLetter, name.Length - firstCapitalLetter - 1);
        }

        public static object GetValue(Control control)
        {
            if (control is TextBox)
            {
                return (control as TextBox).Text;
            }

            if (control is RichTextBox)
            {
                return (control as RichTextBox).Text;
            }

            if (control is CheckBox)
            {
                return (control as CheckBox).Checked;
            }

            if (control is ComboBox)
            {
                return ((ComboBoxItem)((control as ComboBox).SelectedItem ?? new ComboBoxItem())).Value;
            }

            if (control is GroupBox)
            {
                return (control as GroupBox).Text;
            }

            return null;
        }

        public static void SetValue(Control control, object value)
        {
            if (value == null)
                return;

            if (control is TextBox)
            {
                if (value.GetType() == typeof(string))
                {
                    (control as TextBox).Text = (string)value;
                }
                if (value.GetType() == typeof(double))
                {
                    (control as TextBox).Text = ((double)value).ToString();
                }
            }

            if (control is RichTextBox)
            {
                if (value.GetType() == typeof(string))
                {
                    (control as RichTextBox).Text = (string)value;
                }
                if (value.GetType() == typeof(double))
                {
                    (control as RichTextBox).Text = ((double)value).ToString();
                }
            }

            if (control is CheckBox)
            {
                (control as CheckBox).Checked = (bool)value;
            }

            if (control is ComboBox)
            {
                (control as ComboBox).SelectedIndex = (int)value - 1;
            }
        }
    }
}
