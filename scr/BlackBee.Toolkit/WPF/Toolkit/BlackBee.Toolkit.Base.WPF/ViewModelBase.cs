﻿using BlackBee.Toolkit.Commands;
using System.Windows.Input;

namespace BlackBee.Toolkit.Base
{
    public class ViewModelBase : ObjectBase
    {
        private bool _bussinessProcess;
        private string _bussinessProcessMessage;
        private double _percentProcess;
        private bool _isPercent;

        public ViewModelBase()
        {
            BussinessProcessMessage = "Выполнение операции";
            PercentProcess = 0;
            IsPercent = false;
        }

        #region Fields

        /// <summary>
        /// Поле для шторки которая показывает процесс выполнения
        /// </summary>
        public bool BussinessProcess
        {
            get => _bussinessProcess;
            set
            {
                _bussinessProcess = value;
                if (!_bussinessProcess)
                    _percentProcess = 0;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Поле для шторки которая показывает процесс выполнения
        /// </summary>
        public bool IsPercent
        {
            get => _isPercent;
            set
            {
                _isPercent = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Поле для шторки которая показывает процесс выполнения
        /// </summary>
        public double PercentProcess
        {
            get => _percentProcess;
            set
            {
                _percentProcess = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Поле для шторки которая показывает процесс выполнения
        /// </summary>
        public string BussinessProcessMessage
        {
            get => _bussinessProcessMessage;
            set
            {
                _bussinessProcessMessage = value;
                OnPropertyChanged();
            }
        }

        public IAsyncCommand CancelAsyncCommand { get; }
        #endregion
    }
}