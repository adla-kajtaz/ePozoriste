﻿using ePozoriste.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ePozoriste.WinUI
{
    public partial class frmGlumacPredstava : Form
    {
        private Predstava _predstava;
        public frmGlumacPredstava(Predstava predstava = null)
        {
            InitializeComponent();
            _predstava = predstava;
        }
    }
}
