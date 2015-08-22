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
    public class UndoActionAndBooleanConverter : IValueConverter
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
        private UndoAction _convertWhenTrue;
        public UndoAction ConvertWhenTrue
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
        private UndoAction _convertWhenFalse;
        public UndoAction ConvertWhenFalse
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
            if (!(value is UndoAction)) throw new ArgumentException();

            var enumValue = (UndoAction)value;

			switch(enumValue.ToString())
			{
				case "None":
					if (_isConvertBackWhenNoneSet)
					{
						return ConvertBackWhenNone;
					}
					break;
				case "Merge":
					if (_isConvertBackWhenMergeSet)
					{
						return ConvertBackWhenMerge;
					}
					break;
				case "Undo":
					if (_isConvertBackWhenUndoSet)
					{
						return ConvertBackWhenUndo;
					}
					break;
				case "Redo":
					if (_isConvertBackWhenRedoSet)
					{
						return ConvertBackWhenRedo;
					}
					break;
				case "Clear":
					if (_isConvertBackWhenClearSet)
					{
						return ConvertBackWhenClear;
					}
					break;
				case "Create":
					if (_isConvertBackWhenCreateSet)
					{
						return ConvertBackWhenCreate;
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
        private bool _isConvertBackWhenMergeSet;
        private bool _convertBackWhenMerge;

        public bool ConvertBackWhenMerge
        {
            get
            {
                return _convertBackWhenMerge;
            }
            set
            {
                _convertBackWhenMerge = value;
                _isConvertBackWhenMergeSet = true;
            }
        }
        private bool _isConvertBackWhenUndoSet;
        private bool _convertBackWhenUndo;

        public bool ConvertBackWhenUndo
        {
            get
            {
                return _convertBackWhenUndo;
            }
            set
            {
                _convertBackWhenUndo = value;
                _isConvertBackWhenUndoSet = true;
            }
        }
        private bool _isConvertBackWhenRedoSet;
        private bool _convertBackWhenRedo;

        public bool ConvertBackWhenRedo
        {
            get
            {
                return _convertBackWhenRedo;
            }
            set
            {
                _convertBackWhenRedo = value;
                _isConvertBackWhenRedoSet = true;
            }
        }
        private bool _isConvertBackWhenClearSet;
        private bool _convertBackWhenClear;

        public bool ConvertBackWhenClear
        {
            get
            {
                return _convertBackWhenClear;
            }
            set
            {
                _convertBackWhenClear = value;
                _isConvertBackWhenClearSet = true;
            }
        }
        private bool _isConvertBackWhenCreateSet;
        private bool _convertBackWhenCreate;

        public bool ConvertBackWhenCreate
        {
            get
            {
                return _convertBackWhenCreate;
            }
            set
            {
                _convertBackWhenCreate = value;
                _isConvertBackWhenCreateSet = true;
            }
        }
    }
}