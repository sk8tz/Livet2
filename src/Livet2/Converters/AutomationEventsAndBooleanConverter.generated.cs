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
    public class AutomationEventsAndBooleanConverter : IValueConverter
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
        private AutomationEvents _convertWhenTrue;
        public AutomationEvents ConvertWhenTrue
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
        private AutomationEvents _convertWhenFalse;
        public AutomationEvents ConvertWhenFalse
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
            if (!(value is AutomationEvents)) throw new ArgumentException();

            var enumValue = (AutomationEvents)value;

			switch(enumValue.ToString())
			{
				case "ToolTipOpened":
					if (_isConvertBackWhenToolTipOpenedSet)
					{
						return ConvertBackWhenToolTipOpened;
					}
					break;
				case "ToolTipClosed":
					if (_isConvertBackWhenToolTipClosedSet)
					{
						return ConvertBackWhenToolTipClosed;
					}
					break;
				case "MenuOpened":
					if (_isConvertBackWhenMenuOpenedSet)
					{
						return ConvertBackWhenMenuOpened;
					}
					break;
				case "MenuClosed":
					if (_isConvertBackWhenMenuClosedSet)
					{
						return ConvertBackWhenMenuClosed;
					}
					break;
				case "AutomationFocusChanged":
					if (_isConvertBackWhenAutomationFocusChangedSet)
					{
						return ConvertBackWhenAutomationFocusChanged;
					}
					break;
				case "InvokePatternOnInvoked":
					if (_isConvertBackWhenInvokePatternOnInvokedSet)
					{
						return ConvertBackWhenInvokePatternOnInvoked;
					}
					break;
				case "SelectionItemPatternOnElementAddedToSelection":
					if (_isConvertBackWhenSelectionItemPatternOnElementAddedToSelectionSet)
					{
						return ConvertBackWhenSelectionItemPatternOnElementAddedToSelection;
					}
					break;
				case "SelectionItemPatternOnElementRemovedFromSelection":
					if (_isConvertBackWhenSelectionItemPatternOnElementRemovedFromSelectionSet)
					{
						return ConvertBackWhenSelectionItemPatternOnElementRemovedFromSelection;
					}
					break;
				case "SelectionItemPatternOnElementSelected":
					if (_isConvertBackWhenSelectionItemPatternOnElementSelectedSet)
					{
						return ConvertBackWhenSelectionItemPatternOnElementSelected;
					}
					break;
				case "SelectionPatternOnInvalidated":
					if (_isConvertBackWhenSelectionPatternOnInvalidatedSet)
					{
						return ConvertBackWhenSelectionPatternOnInvalidated;
					}
					break;
				case "TextPatternOnTextSelectionChanged":
					if (_isConvertBackWhenTextPatternOnTextSelectionChangedSet)
					{
						return ConvertBackWhenTextPatternOnTextSelectionChanged;
					}
					break;
				case "TextPatternOnTextChanged":
					if (_isConvertBackWhenTextPatternOnTextChangedSet)
					{
						return ConvertBackWhenTextPatternOnTextChanged;
					}
					break;
				case "AsyncContentLoaded":
					if (_isConvertBackWhenAsyncContentLoadedSet)
					{
						return ConvertBackWhenAsyncContentLoaded;
					}
					break;
				case "PropertyChanged":
					if (_isConvertBackWhenPropertyChangedSet)
					{
						return ConvertBackWhenPropertyChanged;
					}
					break;
				case "StructureChanged":
					if (_isConvertBackWhenStructureChangedSet)
					{
						return ConvertBackWhenStructureChanged;
					}
					break;
				case "InputReachedTarget":
					if (_isConvertBackWhenInputReachedTargetSet)
					{
						return ConvertBackWhenInputReachedTarget;
					}
					break;
				case "InputReachedOtherElement":
					if (_isConvertBackWhenInputReachedOtherElementSet)
					{
						return ConvertBackWhenInputReachedOtherElement;
					}
					break;
				case "InputDiscarded":
					if (_isConvertBackWhenInputDiscardedSet)
					{
						return ConvertBackWhenInputDiscarded;
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

        private bool _isConvertBackWhenToolTipOpenedSet;
        private bool _convertBackWhenToolTipOpened;

        public bool ConvertBackWhenToolTipOpened
        {
            get
            {
                return _convertBackWhenToolTipOpened;
            }
            set
            {
                _convertBackWhenToolTipOpened = value;
                _isConvertBackWhenToolTipOpenedSet = true;
            }
        }
        private bool _isConvertBackWhenToolTipClosedSet;
        private bool _convertBackWhenToolTipClosed;

        public bool ConvertBackWhenToolTipClosed
        {
            get
            {
                return _convertBackWhenToolTipClosed;
            }
            set
            {
                _convertBackWhenToolTipClosed = value;
                _isConvertBackWhenToolTipClosedSet = true;
            }
        }
        private bool _isConvertBackWhenMenuOpenedSet;
        private bool _convertBackWhenMenuOpened;

        public bool ConvertBackWhenMenuOpened
        {
            get
            {
                return _convertBackWhenMenuOpened;
            }
            set
            {
                _convertBackWhenMenuOpened = value;
                _isConvertBackWhenMenuOpenedSet = true;
            }
        }
        private bool _isConvertBackWhenMenuClosedSet;
        private bool _convertBackWhenMenuClosed;

        public bool ConvertBackWhenMenuClosed
        {
            get
            {
                return _convertBackWhenMenuClosed;
            }
            set
            {
                _convertBackWhenMenuClosed = value;
                _isConvertBackWhenMenuClosedSet = true;
            }
        }
        private bool _isConvertBackWhenAutomationFocusChangedSet;
        private bool _convertBackWhenAutomationFocusChanged;

        public bool ConvertBackWhenAutomationFocusChanged
        {
            get
            {
                return _convertBackWhenAutomationFocusChanged;
            }
            set
            {
                _convertBackWhenAutomationFocusChanged = value;
                _isConvertBackWhenAutomationFocusChangedSet = true;
            }
        }
        private bool _isConvertBackWhenInvokePatternOnInvokedSet;
        private bool _convertBackWhenInvokePatternOnInvoked;

        public bool ConvertBackWhenInvokePatternOnInvoked
        {
            get
            {
                return _convertBackWhenInvokePatternOnInvoked;
            }
            set
            {
                _convertBackWhenInvokePatternOnInvoked = value;
                _isConvertBackWhenInvokePatternOnInvokedSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionItemPatternOnElementAddedToSelectionSet;
        private bool _convertBackWhenSelectionItemPatternOnElementAddedToSelection;

        public bool ConvertBackWhenSelectionItemPatternOnElementAddedToSelection
        {
            get
            {
                return _convertBackWhenSelectionItemPatternOnElementAddedToSelection;
            }
            set
            {
                _convertBackWhenSelectionItemPatternOnElementAddedToSelection = value;
                _isConvertBackWhenSelectionItemPatternOnElementAddedToSelectionSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionItemPatternOnElementRemovedFromSelectionSet;
        private bool _convertBackWhenSelectionItemPatternOnElementRemovedFromSelection;

        public bool ConvertBackWhenSelectionItemPatternOnElementRemovedFromSelection
        {
            get
            {
                return _convertBackWhenSelectionItemPatternOnElementRemovedFromSelection;
            }
            set
            {
                _convertBackWhenSelectionItemPatternOnElementRemovedFromSelection = value;
                _isConvertBackWhenSelectionItemPatternOnElementRemovedFromSelectionSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionItemPatternOnElementSelectedSet;
        private bool _convertBackWhenSelectionItemPatternOnElementSelected;

        public bool ConvertBackWhenSelectionItemPatternOnElementSelected
        {
            get
            {
                return _convertBackWhenSelectionItemPatternOnElementSelected;
            }
            set
            {
                _convertBackWhenSelectionItemPatternOnElementSelected = value;
                _isConvertBackWhenSelectionItemPatternOnElementSelectedSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionPatternOnInvalidatedSet;
        private bool _convertBackWhenSelectionPatternOnInvalidated;

        public bool ConvertBackWhenSelectionPatternOnInvalidated
        {
            get
            {
                return _convertBackWhenSelectionPatternOnInvalidated;
            }
            set
            {
                _convertBackWhenSelectionPatternOnInvalidated = value;
                _isConvertBackWhenSelectionPatternOnInvalidatedSet = true;
            }
        }
        private bool _isConvertBackWhenTextPatternOnTextSelectionChangedSet;
        private bool _convertBackWhenTextPatternOnTextSelectionChanged;

        public bool ConvertBackWhenTextPatternOnTextSelectionChanged
        {
            get
            {
                return _convertBackWhenTextPatternOnTextSelectionChanged;
            }
            set
            {
                _convertBackWhenTextPatternOnTextSelectionChanged = value;
                _isConvertBackWhenTextPatternOnTextSelectionChangedSet = true;
            }
        }
        private bool _isConvertBackWhenTextPatternOnTextChangedSet;
        private bool _convertBackWhenTextPatternOnTextChanged;

        public bool ConvertBackWhenTextPatternOnTextChanged
        {
            get
            {
                return _convertBackWhenTextPatternOnTextChanged;
            }
            set
            {
                _convertBackWhenTextPatternOnTextChanged = value;
                _isConvertBackWhenTextPatternOnTextChangedSet = true;
            }
        }
        private bool _isConvertBackWhenAsyncContentLoadedSet;
        private bool _convertBackWhenAsyncContentLoaded;

        public bool ConvertBackWhenAsyncContentLoaded
        {
            get
            {
                return _convertBackWhenAsyncContentLoaded;
            }
            set
            {
                _convertBackWhenAsyncContentLoaded = value;
                _isConvertBackWhenAsyncContentLoadedSet = true;
            }
        }
        private bool _isConvertBackWhenPropertyChangedSet;
        private bool _convertBackWhenPropertyChanged;

        public bool ConvertBackWhenPropertyChanged
        {
            get
            {
                return _convertBackWhenPropertyChanged;
            }
            set
            {
                _convertBackWhenPropertyChanged = value;
                _isConvertBackWhenPropertyChangedSet = true;
            }
        }
        private bool _isConvertBackWhenStructureChangedSet;
        private bool _convertBackWhenStructureChanged;

        public bool ConvertBackWhenStructureChanged
        {
            get
            {
                return _convertBackWhenStructureChanged;
            }
            set
            {
                _convertBackWhenStructureChanged = value;
                _isConvertBackWhenStructureChangedSet = true;
            }
        }
        private bool _isConvertBackWhenInputReachedTargetSet;
        private bool _convertBackWhenInputReachedTarget;

        public bool ConvertBackWhenInputReachedTarget
        {
            get
            {
                return _convertBackWhenInputReachedTarget;
            }
            set
            {
                _convertBackWhenInputReachedTarget = value;
                _isConvertBackWhenInputReachedTargetSet = true;
            }
        }
        private bool _isConvertBackWhenInputReachedOtherElementSet;
        private bool _convertBackWhenInputReachedOtherElement;

        public bool ConvertBackWhenInputReachedOtherElement
        {
            get
            {
                return _convertBackWhenInputReachedOtherElement;
            }
            set
            {
                _convertBackWhenInputReachedOtherElement = value;
                _isConvertBackWhenInputReachedOtherElementSet = true;
            }
        }
        private bool _isConvertBackWhenInputDiscardedSet;
        private bool _convertBackWhenInputDiscarded;

        public bool ConvertBackWhenInputDiscarded
        {
            get
            {
                return _convertBackWhenInputDiscarded;
            }
            set
            {
                _convertBackWhenInputDiscarded = value;
                _isConvertBackWhenInputDiscardedSet = true;
            }
        }
    }
}