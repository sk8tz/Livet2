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
    public class PatternInterfaceAndBooleanConverter : IValueConverter
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
        private PatternInterface _convertWhenTrue;
        public PatternInterface ConvertWhenTrue
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
        private PatternInterface _convertWhenFalse;
        public PatternInterface ConvertWhenFalse
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
            if (!(value is PatternInterface)) throw new ArgumentException();

            var enumValue = (PatternInterface)value;

			switch(enumValue.ToString())
			{
				case "Invoke":
					if (_isConvertBackWhenInvokeSet)
					{
						return ConvertBackWhenInvoke;
					}
					break;
				case "Selection":
					if (_isConvertBackWhenSelectionSet)
					{
						return ConvertBackWhenSelection;
					}
					break;
				case "Value":
					if (_isConvertBackWhenValueSet)
					{
						return ConvertBackWhenValue;
					}
					break;
				case "RangeValue":
					if (_isConvertBackWhenRangeValueSet)
					{
						return ConvertBackWhenRangeValue;
					}
					break;
				case "Scroll":
					if (_isConvertBackWhenScrollSet)
					{
						return ConvertBackWhenScroll;
					}
					break;
				case "ScrollItem":
					if (_isConvertBackWhenScrollItemSet)
					{
						return ConvertBackWhenScrollItem;
					}
					break;
				case "ExpandCollapse":
					if (_isConvertBackWhenExpandCollapseSet)
					{
						return ConvertBackWhenExpandCollapse;
					}
					break;
				case "Grid":
					if (_isConvertBackWhenGridSet)
					{
						return ConvertBackWhenGrid;
					}
					break;
				case "GridItem":
					if (_isConvertBackWhenGridItemSet)
					{
						return ConvertBackWhenGridItem;
					}
					break;
				case "MultipleView":
					if (_isConvertBackWhenMultipleViewSet)
					{
						return ConvertBackWhenMultipleView;
					}
					break;
				case "Window":
					if (_isConvertBackWhenWindowSet)
					{
						return ConvertBackWhenWindow;
					}
					break;
				case "SelectionItem":
					if (_isConvertBackWhenSelectionItemSet)
					{
						return ConvertBackWhenSelectionItem;
					}
					break;
				case "Dock":
					if (_isConvertBackWhenDockSet)
					{
						return ConvertBackWhenDock;
					}
					break;
				case "Table":
					if (_isConvertBackWhenTableSet)
					{
						return ConvertBackWhenTable;
					}
					break;
				case "TableItem":
					if (_isConvertBackWhenTableItemSet)
					{
						return ConvertBackWhenTableItem;
					}
					break;
				case "Toggle":
					if (_isConvertBackWhenToggleSet)
					{
						return ConvertBackWhenToggle;
					}
					break;
				case "Transform":
					if (_isConvertBackWhenTransformSet)
					{
						return ConvertBackWhenTransform;
					}
					break;
				case "Text":
					if (_isConvertBackWhenTextSet)
					{
						return ConvertBackWhenText;
					}
					break;
				case "ItemContainer":
					if (_isConvertBackWhenItemContainerSet)
					{
						return ConvertBackWhenItemContainer;
					}
					break;
				case "VirtualizedItem":
					if (_isConvertBackWhenVirtualizedItemSet)
					{
						return ConvertBackWhenVirtualizedItem;
					}
					break;
				case "SynchronizedInput":
					if (_isConvertBackWhenSynchronizedInputSet)
					{
						return ConvertBackWhenSynchronizedInput;
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

        private bool _isConvertBackWhenInvokeSet;
        private bool _convertBackWhenInvoke;

        public bool ConvertBackWhenInvoke
        {
            get
            {
                return _convertBackWhenInvoke;
            }
            set
            {
                _convertBackWhenInvoke = value;
                _isConvertBackWhenInvokeSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionSet;
        private bool _convertBackWhenSelection;

        public bool ConvertBackWhenSelection
        {
            get
            {
                return _convertBackWhenSelection;
            }
            set
            {
                _convertBackWhenSelection = value;
                _isConvertBackWhenSelectionSet = true;
            }
        }
        private bool _isConvertBackWhenValueSet;
        private bool _convertBackWhenValue;

        public bool ConvertBackWhenValue
        {
            get
            {
                return _convertBackWhenValue;
            }
            set
            {
                _convertBackWhenValue = value;
                _isConvertBackWhenValueSet = true;
            }
        }
        private bool _isConvertBackWhenRangeValueSet;
        private bool _convertBackWhenRangeValue;

        public bool ConvertBackWhenRangeValue
        {
            get
            {
                return _convertBackWhenRangeValue;
            }
            set
            {
                _convertBackWhenRangeValue = value;
                _isConvertBackWhenRangeValueSet = true;
            }
        }
        private bool _isConvertBackWhenScrollSet;
        private bool _convertBackWhenScroll;

        public bool ConvertBackWhenScroll
        {
            get
            {
                return _convertBackWhenScroll;
            }
            set
            {
                _convertBackWhenScroll = value;
                _isConvertBackWhenScrollSet = true;
            }
        }
        private bool _isConvertBackWhenScrollItemSet;
        private bool _convertBackWhenScrollItem;

        public bool ConvertBackWhenScrollItem
        {
            get
            {
                return _convertBackWhenScrollItem;
            }
            set
            {
                _convertBackWhenScrollItem = value;
                _isConvertBackWhenScrollItemSet = true;
            }
        }
        private bool _isConvertBackWhenExpandCollapseSet;
        private bool _convertBackWhenExpandCollapse;

        public bool ConvertBackWhenExpandCollapse
        {
            get
            {
                return _convertBackWhenExpandCollapse;
            }
            set
            {
                _convertBackWhenExpandCollapse = value;
                _isConvertBackWhenExpandCollapseSet = true;
            }
        }
        private bool _isConvertBackWhenGridSet;
        private bool _convertBackWhenGrid;

        public bool ConvertBackWhenGrid
        {
            get
            {
                return _convertBackWhenGrid;
            }
            set
            {
                _convertBackWhenGrid = value;
                _isConvertBackWhenGridSet = true;
            }
        }
        private bool _isConvertBackWhenGridItemSet;
        private bool _convertBackWhenGridItem;

        public bool ConvertBackWhenGridItem
        {
            get
            {
                return _convertBackWhenGridItem;
            }
            set
            {
                _convertBackWhenGridItem = value;
                _isConvertBackWhenGridItemSet = true;
            }
        }
        private bool _isConvertBackWhenMultipleViewSet;
        private bool _convertBackWhenMultipleView;

        public bool ConvertBackWhenMultipleView
        {
            get
            {
                return _convertBackWhenMultipleView;
            }
            set
            {
                _convertBackWhenMultipleView = value;
                _isConvertBackWhenMultipleViewSet = true;
            }
        }
        private bool _isConvertBackWhenWindowSet;
        private bool _convertBackWhenWindow;

        public bool ConvertBackWhenWindow
        {
            get
            {
                return _convertBackWhenWindow;
            }
            set
            {
                _convertBackWhenWindow = value;
                _isConvertBackWhenWindowSet = true;
            }
        }
        private bool _isConvertBackWhenSelectionItemSet;
        private bool _convertBackWhenSelectionItem;

        public bool ConvertBackWhenSelectionItem
        {
            get
            {
                return _convertBackWhenSelectionItem;
            }
            set
            {
                _convertBackWhenSelectionItem = value;
                _isConvertBackWhenSelectionItemSet = true;
            }
        }
        private bool _isConvertBackWhenDockSet;
        private bool _convertBackWhenDock;

        public bool ConvertBackWhenDock
        {
            get
            {
                return _convertBackWhenDock;
            }
            set
            {
                _convertBackWhenDock = value;
                _isConvertBackWhenDockSet = true;
            }
        }
        private bool _isConvertBackWhenTableSet;
        private bool _convertBackWhenTable;

        public bool ConvertBackWhenTable
        {
            get
            {
                return _convertBackWhenTable;
            }
            set
            {
                _convertBackWhenTable = value;
                _isConvertBackWhenTableSet = true;
            }
        }
        private bool _isConvertBackWhenTableItemSet;
        private bool _convertBackWhenTableItem;

        public bool ConvertBackWhenTableItem
        {
            get
            {
                return _convertBackWhenTableItem;
            }
            set
            {
                _convertBackWhenTableItem = value;
                _isConvertBackWhenTableItemSet = true;
            }
        }
        private bool _isConvertBackWhenToggleSet;
        private bool _convertBackWhenToggle;

        public bool ConvertBackWhenToggle
        {
            get
            {
                return _convertBackWhenToggle;
            }
            set
            {
                _convertBackWhenToggle = value;
                _isConvertBackWhenToggleSet = true;
            }
        }
        private bool _isConvertBackWhenTransformSet;
        private bool _convertBackWhenTransform;

        public bool ConvertBackWhenTransform
        {
            get
            {
                return _convertBackWhenTransform;
            }
            set
            {
                _convertBackWhenTransform = value;
                _isConvertBackWhenTransformSet = true;
            }
        }
        private bool _isConvertBackWhenTextSet;
        private bool _convertBackWhenText;

        public bool ConvertBackWhenText
        {
            get
            {
                return _convertBackWhenText;
            }
            set
            {
                _convertBackWhenText = value;
                _isConvertBackWhenTextSet = true;
            }
        }
        private bool _isConvertBackWhenItemContainerSet;
        private bool _convertBackWhenItemContainer;

        public bool ConvertBackWhenItemContainer
        {
            get
            {
                return _convertBackWhenItemContainer;
            }
            set
            {
                _convertBackWhenItemContainer = value;
                _isConvertBackWhenItemContainerSet = true;
            }
        }
        private bool _isConvertBackWhenVirtualizedItemSet;
        private bool _convertBackWhenVirtualizedItem;

        public bool ConvertBackWhenVirtualizedItem
        {
            get
            {
                return _convertBackWhenVirtualizedItem;
            }
            set
            {
                _convertBackWhenVirtualizedItem = value;
                _isConvertBackWhenVirtualizedItemSet = true;
            }
        }
        private bool _isConvertBackWhenSynchronizedInputSet;
        private bool _convertBackWhenSynchronizedInput;

        public bool ConvertBackWhenSynchronizedInput
        {
            get
            {
                return _convertBackWhenSynchronizedInput;
            }
            set
            {
                _convertBackWhenSynchronizedInput = value;
                _isConvertBackWhenSynchronizedInputSet = true;
            }
        }
    }
}