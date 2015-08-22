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
    public class TiffCompressOptionAndBooleanConverter : IValueConverter
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
        private TiffCompressOption _convertWhenTrue;
        public TiffCompressOption ConvertWhenTrue
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
        private TiffCompressOption _convertWhenFalse;
        public TiffCompressOption ConvertWhenFalse
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
            if (!(value is TiffCompressOption)) throw new ArgumentException();

            var enumValue = (TiffCompressOption)value;

			switch(enumValue.ToString())
			{
				case "Default":
					if (_isConvertBackWhenDefaultSet)
					{
						return ConvertBackWhenDefault;
					}
					break;
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Ccitt3":
					if (_isConvertBackWhenCcitt3Set)
					{
						return ConvertBackWhenCcitt3;
					}
					break;
				case "Ccitt4":
					if (_isConvertBackWhenCcitt4Set)
					{
						return ConvertBackWhenCcitt4;
					}
					break;
				case "Lzw":
					if (_isConvertBackWhenLzwSet)
					{
						return ConvertBackWhenLzw;
					}
					break;
				case "Rle":
					if (_isConvertBackWhenRleSet)
					{
						return ConvertBackWhenRle;
					}
					break;
				case "Zip":
					if (_isConvertBackWhenZipSet)
					{
						return ConvertBackWhenZip;
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

        private bool _isConvertBackWhenDefaultSet;
        private bool _convertBackWhenDefault;

        public bool ConvertBackWhenDefault
        {
            get
            {
                return _convertBackWhenDefault;
            }
            set
            {
                _convertBackWhenDefault = value;
                _isConvertBackWhenDefaultSet = true;
            }
        }
        private bool _isConvertBackWhenNoneSet;
        private bool _convertBackWhenNone;

        public bool ConvertBackWhenNone
        {
            get
            {
                return _convertBackWhenNone;
            }
            set
            {
                _convertBackWhenNone = value;
                _isConvertBackWhenNoneSet = true;
            }
        }
        private bool _isConvertBackWhenCcitt3Set;
        private bool _convertBackWhenCcitt3;

        public bool ConvertBackWhenCcitt3
        {
            get
            {
                return _convertBackWhenCcitt3;
            }
            set
            {
                _convertBackWhenCcitt3 = value;
                _isConvertBackWhenCcitt3Set = true;
            }
        }
        private bool _isConvertBackWhenCcitt4Set;
        private bool _convertBackWhenCcitt4;

        public bool ConvertBackWhenCcitt4
        {
            get
            {
                return _convertBackWhenCcitt4;
            }
            set
            {
                _convertBackWhenCcitt4 = value;
                _isConvertBackWhenCcitt4Set = true;
            }
        }
        private bool _isConvertBackWhenLzwSet;
        private bool _convertBackWhenLzw;

        public bool ConvertBackWhenLzw
        {
            get
            {
                return _convertBackWhenLzw;
            }
            set
            {
                _convertBackWhenLzw = value;
                _isConvertBackWhenLzwSet = true;
            }
        }
        private bool _isConvertBackWhenRleSet;
        private bool _convertBackWhenRle;

        public bool ConvertBackWhenRle
        {
            get
            {
                return _convertBackWhenRle;
            }
            set
            {
                _convertBackWhenRle = value;
                _isConvertBackWhenRleSet = true;
            }
        }
        private bool _isConvertBackWhenZipSet;
        private bool _convertBackWhenZip;

        public bool ConvertBackWhenZip
        {
            get
            {
                return _convertBackWhenZip;
            }
            set
            {
                _convertBackWhenZip = value;
                _isConvertBackWhenZipSet = true;
            }
        }
    }
}