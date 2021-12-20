using MySQLToCSharp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using MessageBox = System.Windows.MessageBox;

namespace MySQLToCSharp.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public string IP
        {
            get
            {
                return Properties.Settings.Default.IP;
            }
            set
            {
                Properties.Settings.Default.IP = value;
                OnPropertyChanged("IP");
            }
        }

        public string Port
        {
            get
            {
                return Properties.Settings.Default.Port;
            }
            set
            {
                Properties.Settings.Default.Port = value;
                OnPropertyChanged("Port");
            }
        }
        public string Database
        {
            get
            {
                return Properties.Settings.Default.Database;
            }
            set
            {
                Properties.Settings.Default.Database = value;
                OnPropertyChanged("Database");
            }
        }
        public string UID
        {
            get
            {
                return Properties.Settings.Default.UID;
            }
            set
            {
                Properties.Settings.Default.UID = value;
                OnPropertyChanged("UID");
            }
        }
        public string Password
        {
            get
            {
                return Properties.Settings.Default.Password;
            }
            set
            {
                Properties.Settings.Default.Password = value;
                OnPropertyChanged("Password");
            }
        }
        public string Charset
        {
            get
            {
                return Properties.Settings.Default.Charset;
            }
            set
            {
                Properties.Settings.Default.Charset = value;
                OnPropertyChanged("Charset");
            }
        }
        public string ModelNamespace
        {
            get
            {
                return Properties.Settings.Default.ModelNamespace;
            }
            set
            {
                Properties.Settings.Default.ModelNamespace = value;
                OnPropertyChanged("ModelNamespace");
            }
        }
        public string SaveFolder
        {
            get
            {
                return Properties.Settings.Default.SaveFolder;
            }
            set
            {
                Properties.Settings.Default.SaveFolder = value;
                OnPropertyChanged("SaveFolder");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ICommand commandOpenSaveFolder;
        public ICommand CommandOpenSaveFolder
        {
            get
            {
                if (commandOpenSaveFolder == null)
                    commandOpenSaveFolder = new OpenSaveFolder(this);
                return commandOpenSaveFolder;
            }
            set
            {
                commandOpenSaveFolder = value;
            }
        }
        private ICommand commandGenerateClass;
        public ICommand CommandGenerateClass
        {
            get
            {
                if (commandGenerateClass == null)
                    commandGenerateClass = new GenerateClass(this);
                return commandGenerateClass;
            }
            set
            {
                commandGenerateClass = value;
            }
        }
    }

    class OpenSaveFolder : ICommand
    {
        private MainWindowViewModel _mainWindowViewModel;
        public OpenSaveFolder(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            _mainWindowViewModel.SaveFolder = dialog.SelectedPath;
        }
    }

    class GenerateClass : ICommand
    {
        private MainWindowViewModel _mainWindowViewModel;
        public GenerateClass(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            if (!RegexHelper.IsIP(Properties.Settings.Default.IP))
            {
                MessageBox.Show("Invalid IP Address!");
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Port))
            {
                MessageBox.Show("Port number cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Database))
            {
                MessageBox.Show("Database name cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.UID))
            {
                MessageBox.Show("UID cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.ModelNamespace))
            {
                MessageBox.Show("Namespace cannot be empty!");
                return;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.SaveFolder))
            {
                MessageBox.Show("Select a folder to save output files!");
                return;
            }
            try
                {
                    DataHelper.TableSaveToCSFile();
                    Properties.Settings.Default.Save();
                   MessageBox.Show("Generated successfully");
               }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}
