﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroNegocio_RH_ERP_ISC_8A.Interfaces
{
    public partial class Departamentos_nuevo : Form
    {
        public Departamentos_nuevo()
        {
            InitializeComponent();
        }

        public static implicit operator Departamentos_nuevo(Estados_nuevo v)
        {
            throw new NotImplementedException();
        }
    }
}