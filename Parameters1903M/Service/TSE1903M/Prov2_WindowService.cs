﻿using Parameters1903M.Model;
using Parameters1903M.Util;
using Parameters1903M.View.TSE1903M;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Parameters1903M.Service.TSE1903M
{
    internal class Prov2_WindowService : ProvMeasureWindowService, IWindowService
    {
        public Prov2_Window GetProvWindow() => Application.Current.Windows.OfType<Prov2_Window>().FirstOrDefault();

        public void Close(object param)
        {
            if (GlobalVars.IsMeasureRunning)
            {
                CancelEventArgs cancelEventArgs = (CancelEventArgs)param;
                cancelEventArgs.Cancel = true;

                string message = "Невозможно закрыть окно с проверкой, т.к. в настоящее время проводится измерение параметра.";
                MessageBox.Show(GetProvWindow(), message, ProgramInfo.SoftwareName, MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            GlobalVars.IsProvWindowOpened = false;
        }

        public void OpenDialog(object param)
        {
            if (param is Parameter parameter)
            {
                Prov2_Window window = Application.Current.Windows.OfType<Prov2_Window>().FirstOrDefault();
                if (window == null)
                {
                    window = new Prov2_Window(parameter) { Owner = Application.Current.MainWindow };
                }
                window.ShowDialog();

                GlobalVars.IsProvWindowOpened = true;
            }
        }
    }
}
