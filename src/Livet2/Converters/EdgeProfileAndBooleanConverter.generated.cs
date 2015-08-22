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
    public class EdgeProfileAndBooleanConverter : IValueConverter
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
        private EdgeProfile _convertWhenTrue;
        public EdgeProfile ConvertWhenTrue
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
        private EdgeProfile _convertWhenFalse;
        public EdgeProfile ConvertWhenFalse
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
            if (!(value is EdgeProfile)) throw new ArgumentException();

            var enumValue = (EdgeProfile)value;

			switch(enumValue.ToString())
			{
				case "Linear":
					if (_isConvertBackWhenLinearSet)
					{
						return ConvertBackWhenLinear;
					}
					break;
				case "CurvedIn":
					if (_isConvertBackWhenCurvedInSet)
					{
						return ConvertBackWhenCurvedIn;
					}
					break;
				case "CurvedOut":
					if (_isConvertBackWhenCurvedOutSet)
					{
						return ConvertBackWhenCurvedOut;
					}
					break;
				case "BulgedUp":
					if (_isConvertBackWhenBulgedUpSet)
					{
						return ConvertBackWhenBulgedUp;
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

        private bool _isConvertBackWhenLinearSet;
        private bool _convertBackWhenLinear;

        public bool ConvertBackWhenLinear
        {
            get
            {
                return _convertBackWhenLinear;
            }
            set
            {
                _convertBackWhenLinear = value;
                _isConvertBackWhenLinearSet = true;
            }
        }
        private bool _isConvertBackWhenCurvedInSet;
        private bool _convertBackWhenCurvedIn;

        public bool ConvertBackWhenCurvedIn
        {
            get
            {
                return _convertBackWhenCurvedIn;
            }
            set
            {
                _convertBackWhenCurvedIn = value;
                _isConvertBackWhenCurvedInSet = true;
            }
        }
        private bool _isConvertBackWhenCurvedOutSet;
        private bool _convertBackWhenCurvedOut;

        public bool ConvertBackWhenCurvedOut
        {
            get
            {
                return _convertBackWhenCurvedOut;
            }
            set
            {
                _convertBackWhenCurvedOut = value;
                _isConvertBackWhenCurvedOutSet = true;
            }
        }
        private bool _isConvertBackWhenBulgedUpSet;
        private bool _convertBackWhenBulgedUp;

        public bool ConvertBackWhenBulgedUp
        {
            get
            {
                return _convertBackWhenBulgedUp;
            }
            set
            {
                _convertBackWhenBulgedUp = value;
                _isConvertBackWhenBulgedUpSet = true;
            }
        }
    }
}