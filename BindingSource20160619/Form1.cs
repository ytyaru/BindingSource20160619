using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BindingSource20160619
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "R", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "G", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "B", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            this.trackBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "R", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "G", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBar3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "B", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));

            RGB rgb1 = new RGB();
            rgb1.R = 100;
            rgb1.G = 200;
            rgb1.B = 50;
            this.bindingSource1.DataSource = rgb1;

            ((RGB)(this.bindingSource1.DataSource)).R = 5;
            ((RGB)(this.bindingSource1.DataSource)).G = 205;
            ((RGB)(this.bindingSource1.DataSource)).B = 55;
        }
    }
}
