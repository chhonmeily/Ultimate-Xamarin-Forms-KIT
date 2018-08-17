﻿using System;
using System.Collections.Generic;
using UltimateXF.Widget.Charts.Models.Formatters;
using Xamarin.Forms;

namespace UltimateXF.Widget.Charts.Models.Component
{
    public class GradientColor
    {
        public Color StartColor;
        public Color EndColor;

        public GradientColor(Color startColor, Color endColor)
        {
            this.StartColor = startColor;
            this.EndColor = endColor;
        }
    }

    public abstract class BaseDataSetXF<TEntry> : BindableObject where TEntry : BaseEntry
    {
        /*
         * protected Typeface mValueTypeface;
         * protected MPPointF mIconsOffset = new MPPointF();
         * 
         */
        private List<Color> _Colors;
        public List<Color> Colors
        {
            get => _Colors;
            set
            {
                _Colors = value;
                OnPropertyChanged();
            }
        }

        private List<Color> _ValueColors;
        public List<Color> ValueColors
        {
            get => _ValueColors;
            set
            {
                _ValueColors = value;
                OnPropertyChanged();
            }
        }

        private GradientColor _GradientColor;
        public GradientColor GradientColor
        {
            get => _GradientColor;
            set
            {
                _GradientColor = value;
                OnPropertyChanged();
            }
        }

        private List<GradientColor> _GradientColors;
        public List<GradientColor> GradientColors
        {
            get => _GradientColors;
            set
            {
                _GradientColors = value;
                OnPropertyChanged();
            }
        }

        private string _Label;
        public string Label
        {
            get => _Label;
            set
            {
                _Label = value;
                OnPropertyChanged();
            }
        }

        private bool? _HighlightEnabled;
        public bool? HighlightEnabled
        {
            get => _HighlightEnabled;
            set
            {
                _HighlightEnabled = value;
                OnPropertyChanged();
            }
        }

        private bool? _Visible;
        public bool? Visible
        {
            get => _Visible;
            set
            {
                _Visible = value;
                OnPropertyChanged();
            }
        }

        private float? _ValueTextSize;
        public float? ValueTextSize
        {
            get => _ValueTextSize;
            set
            {
                _ValueTextSize = value;
                OnPropertyChanged();
            }
        }

        private bool? _DrawIcons;
        public bool? DrawIcons
        {
            get => _DrawIcons;
            set
            {
                _DrawIcons = value;
                OnPropertyChanged();
            }
        }

        private bool? _DrawValues;
        public bool? DrawValues
        {
            get => _DrawValues;
            set
            {
                _DrawValues = value;
                OnPropertyChanged();
            }
        }

        private IValueFormatterXF _ValueFormatter;
        public IValueFormatterXF ValueFormatter
        {
            get => ValueFormatter;
            set
            {
                ValueFormatter = value;
                OnPropertyChanged();
            }
        }

        public BaseDataSetXF()
        {
        }
    }
}