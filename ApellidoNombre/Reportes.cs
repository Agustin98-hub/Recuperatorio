﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApellidoNombre
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Escritorio\Barria.accdb;Persist Security Info=False;";

    }
}
