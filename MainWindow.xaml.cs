﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using NpgsqlTypes;
using System.Data.Common;
using Microsoft.SqlServer.Server;


namespace WpfApp4
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Connection.Connect("127.0.0.1", "5432", "postgres", "ShopUL");
            
            frame.Navigate(new login());
        }
        
       
    }
}
