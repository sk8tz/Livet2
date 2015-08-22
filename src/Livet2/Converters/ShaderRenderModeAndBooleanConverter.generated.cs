﻿//this code generated by T4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
    public class ShaderRenderModeAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private ShaderRenderMode _convertWhenTrue;
        public ShaderRenderMode ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private ShaderRenderMode _convertWhenFalse;
        public ShaderRenderMode ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is ShaderRenderMode)) throw new ArgumentException();

            var enumValue = (ShaderRenderMode)value;

			switch(enumValue.ToString())
			{
				case "Auto":
					if (_isConvertBackWhenAutoSet)
					{
						return ConvertBackWhenAuto;
					}
					break;
				case "SoftwareOnly":
					if (_isConvertBackWhenSoftwareOnlySet)
					{
						return ConvertBackWhenSoftwareOnly;
					}
					break;
				case "HardwareOnly":
					if (_isConvertBackWhenHardwareOnlySet)
					{
						return ConvertBackWhenHardwareOnly;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenAutoSet;
        private bool _convertBackWhenAuto;

        public bool ConvertBackWhenAuto
        {
            get
            {
                return _convertBackWhenAuto;
            }
            set
            {
                _convertBackWhenAuto = value;
                _isConvertBackWhenAutoSet = true;
            }
        }
        private bool _isConvertBackWhenSoftwareOnlySet;
        private bool _convertBackWhenSoftwareOnly;

        public bool ConvertBackWhenSoftwareOnly
        {
            get
            {
                return _convertBackWhenSoftwareOnly;
            }
            set
            {
                _convertBackWhenSoftwareOnly = value;
                _isConvertBackWhenSoftwareOnlySet = true;
            }
        }
        private bool _isConvertBackWhenHardwareOnlySet;
        private bool _convertBackWhenHardwareOnly;

        public bool ConvertBackWhenHardwareOnly
        {
            get
            {
                return _convertBackWhenHardwareOnly;
            }
            set
            {
                _convertBackWhenHardwareOnly = value;
                _isConvertBackWhenHardwareOnlySet = true;
            }
        }
    }
}