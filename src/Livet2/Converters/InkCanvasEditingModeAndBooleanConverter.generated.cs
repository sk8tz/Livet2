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
    public class InkCanvasEditingModeAndBooleanConverter : IValueConverter
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
        private InkCanvasEditingMode _convertWhenTrue;
        public InkCanvasEditingMode ConvertWhenTrue
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
        private InkCanvasEditingMode _convertWhenFalse;
        public InkCanvasEditingMode ConvertWhenFalse
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
            if (!(value is InkCanvasEditingMode)) throw new ArgumentException();

            var enumValue = (InkCanvasEditingMode)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Ink":
					if (_isConvertBackWhenInkSet)
					{
						return ConvertBackWhenInk;
					}
					break;
				case "GestureOnly":
					if (_isConvertBackWhenGestureOnlySet)
					{
						return ConvertBackWhenGestureOnly;
					}
					break;
				case "InkAndGesture":
					if (_isConvertBackWhenInkAndGestureSet)
					{
						return ConvertBackWhenInkAndGesture;
					}
					break;
				case "Select":
					if (_isConvertBackWhenSelectSet)
					{
						return ConvertBackWhenSelect;
					}
					break;
				case "EraseByPoint":
					if (_isConvertBackWhenEraseByPointSet)
					{
						return ConvertBackWhenEraseByPoint;
					}
					break;
				case "EraseByStroke":
					if (_isConvertBackWhenEraseByStrokeSet)
					{
						return ConvertBackWhenEraseByStroke;
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
        private bool _isConvertBackWhenInkSet;
        private bool _convertBackWhenInk;

        public bool ConvertBackWhenInk
        {
            get
            {
                return _convertBackWhenInk;
            }
            set
            {
                _convertBackWhenInk = value;
                _isConvertBackWhenInkSet = true;
            }
        }
        private bool _isConvertBackWhenGestureOnlySet;
        private bool _convertBackWhenGestureOnly;

        public bool ConvertBackWhenGestureOnly
        {
            get
            {
                return _convertBackWhenGestureOnly;
            }
            set
            {
                _convertBackWhenGestureOnly = value;
                _isConvertBackWhenGestureOnlySet = true;
            }
        }
        private bool _isConvertBackWhenInkAndGestureSet;
        private bool _convertBackWhenInkAndGesture;

        public bool ConvertBackWhenInkAndGesture
        {
            get
            {
                return _convertBackWhenInkAndGesture;
            }
            set
            {
                _convertBackWhenInkAndGesture = value;
                _isConvertBackWhenInkAndGestureSet = true;
            }
        }
        private bool _isConvertBackWhenSelectSet;
        private bool _convertBackWhenSelect;

        public bool ConvertBackWhenSelect
        {
            get
            {
                return _convertBackWhenSelect;
            }
            set
            {
                _convertBackWhenSelect = value;
                _isConvertBackWhenSelectSet = true;
            }
        }
        private bool _isConvertBackWhenEraseByPointSet;
        private bool _convertBackWhenEraseByPoint;

        public bool ConvertBackWhenEraseByPoint
        {
            get
            {
                return _convertBackWhenEraseByPoint;
            }
            set
            {
                _convertBackWhenEraseByPoint = value;
                _isConvertBackWhenEraseByPointSet = true;
            }
        }
        private bool _isConvertBackWhenEraseByStrokeSet;
        private bool _convertBackWhenEraseByStroke;

        public bool ConvertBackWhenEraseByStroke
        {
            get
            {
                return _convertBackWhenEraseByStroke;
            }
            set
            {
                _convertBackWhenEraseByStroke = value;
                _isConvertBackWhenEraseByStrokeSet = true;
            }
        }
    }
}