using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Cita_ViewDias : Form
    {
        public Cita_ViewDias()
        {
            InitializeComponent();
            Inicio();
        }

        #region "Declaracion de variables"
        private Label lblDayz;
        private Int32 y = 0;
        private double x = 1;
        private Int32 ndayz;
        private string Dayofweek;
        //private string CurrentCulture;
        protected internal int MONTHNO = DateTime.Today.Month;
        protected internal int YearNO = DateTime.Today.Year;
        protected internal bool jump = false;
        #endregion

        #region Calendario
        private void currentmonthchanger()
        {
            if (MONTHNO == 1)
            {
                label1.BackColor = Color.FromArgb(176, 180, 43);
                label1.ForeColor = Color.White;
            }
            else if (MONTHNO == 2)
            {
                label2.BackColor = Color.FromArgb(176, 180, 43);
                label2.ForeColor = Color.White;
            }
            else if (MONTHNO == 3)
            {
                label3.BackColor = Color.FromArgb(176, 180, 43);
                label3.ForeColor = Color.White;
            }
            else if (MONTHNO == 4)
            {
                label4.BackColor = Color.FromArgb(176, 180, 43);
                label4.ForeColor = Color.White;
            }
            else if (MONTHNO == 5)
            {
                label5.BackColor = Color.FromArgb(176, 180, 43);
                label5.ForeColor = Color.White;
            }
            else if (MONTHNO == 6)
            {
                label6.BackColor = Color.FromArgb(176, 180, 43);
                label6.ForeColor = Color.White;
            }
            else if (MONTHNO == 7)
            {
                label7.BackColor = Color.FromArgb(176, 180, 43);
                label7.ForeColor = Color.White;
            }
            else if (MONTHNO == 8)
            {
                label8.BackColor = Color.FromArgb(176, 180, 43);
                label8.ForeColor = Color.White;
            }
            else if (MONTHNO == 9)
            {
                label9.BackColor = Color.FromArgb(176, 180, 43);
                label9.ForeColor = Color.White;
            }
            else if (MONTHNO == 10)
            {
                label10.BackColor = Color.FromArgb(176, 180, 43);
                label10.ForeColor = Color.White;
            }
            else if (MONTHNO == 11)
            {
                label11.BackColor = Color.FromArgb(176, 180, 43);
                label11.ForeColor = Color.White;
            }
            else if (MONTHNO == 12)
            {
                label12.BackColor = Color.FromArgb(176, 180, 43);
                label12.ForeColor = Color.White;
            }
        }

        public Int32 CheckDay()
        {
            DateTime time = Convert.ToDateTime("01/" + Convert.ToString(MONTHNO) + "/" + Convert.ToString(YearNO));/*Convert.ToDateTime(MONTHNO.ToString + "/01/" + YearNO.ToString);*/
            Dayofweek = Application.CurrentCulture.Calendar.GetDayOfWeek(time).ToString();
            if (Dayofweek == "Sunday")
            {
<<<<<<< HEAD
=======
                ndayz = 0;
>>>>>>> jeanRuiz
            }
            else if (Dayofweek == "Monday")
                ndayz = 1;
            else if (Dayofweek == "Tuesday")
                ndayz = 2;
            else if (Dayofweek == "Wednesday")
                ndayz = 3;
            else if (Dayofweek == "Thursday")
                ndayz = 4;
            else if (Dayofweek == "Friday")
                ndayz = 5;
            else if (Dayofweek == "Saturday")
                ndayz = 6;
            return Convert.ToInt32(x);
        }

        private void monthchanger(Object sender, MouseEventArgs e)
        {
            Label xt = (Label)sender;
            string yt = xt.Text;
            MONTHNO = Convert.ToInt32(yt);
            currentmonthchanger();
            compute();
        }

        protected internal void compute()
        {
            if (Convert.ToString(MONTHNO) == null | Convert.ToString(YearNO) == null)
                MessageBox.Show("Either year or month is incorrect");
            else
                try
                {
                    Int32 t = Convert.ToInt32(YearNO);
                    var lbs = panelMes.Controls.OfType<Label>().Where(lb => lb.Name.Contains(""));
                    foreach (var lb in lbs)
                    {
                        if (lb.Text == Convert.ToString(MONTHNO))
                        {
                            lb.BackColor = Color.FromArgb(176, 180, 43);
                            lb.ForeColor = Color.White;
                        }
                        else
                        {
                            lb.BackColor = panelMes.BackColor;
                            lb.ForeColor = Color.White;
                        }
                    }
                    panelCalendario.Controls.Clear();
                    x = 1;
                    try
                    {
                        //System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                        //Prueba_Calendario.Form1.ChangeCulture(CurrentCulture);
                    }
                    catch (Exception ex)
                    {
                        //CurrentCulture = System.Globalization.CultureInfo.CurrentCulture.Name;
                    }
                    lbldia.Text = Application.CurrentCulture.DateTimeFormat.GetMonthName(MONTHNO).ToString() + " " + YearNO.ToString();
                    Int32 Dayz = DateTime.DaysInMonth(YearNO, MONTHNO);
                    CheckDay();
                    int hdivchk = 1;
                    for (Int32 i = 1; i <= Dayz; i++)
                    {
                        ndayz += 1;
                        if (ndayz == 7)
                        {
                            ndayz = 0;
                            hdivchk += 1;
                        }
                    }
                    CheckDay();
                    int widthchkr = this.Width / 8;
                    int hightchkr = this.Height / (hdivchk + 3);

                    lblDayz = new Label();
                    lblDayz.Text = "Dom";
                    lblDayz.Name = "DateSun";
                    lblDayz.Anchor = AnchorStyles.None;
                    lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                    lblDayz.ForeColor = Color.White;
                    lblDayz.Font = new Font("Century Gothic", 15);
                    lblDayz.Size = new Size(75, 75);
                    lblDayz.Left = (widthchkr * 1) - (lblDayz.Width / 2);
                    lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                    panelCalendario.Controls.Add(lblDayz);
                    lblDayz = new Label();
                    lblDayz.Text = "Lun";
                    lblDayz.Name = "DateMon";
                    lblDayz.Anchor = AnchorStyles.None;
                    lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                    lblDayz.ForeColor = Color.White;
                    lblDayz.Font = new Font("Century Gothic", 15);
                    lblDayz.Size = new Size(75, 75);
                    lblDayz.Left = (widthchkr * 2) - (lblDayz.Width / 2);
                    lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                    panelCalendario.Controls.Add(lblDayz);
                    lblDayz = new Label();
                    lblDayz.Text = "Mar";
                    lblDayz.Name = "DateTue";
                    lblDayz.Anchor = AnchorStyles.None;
                    lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                    lblDayz.ForeColor = Color.White;
                    lblDayz.Font = new Font("Century Gothic", 15);
                    lblDayz.Size = new Size(75, 75);
                    lblDayz.Left = (widthchkr * 3) - (lblDayz.Width / 2);
                    lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                    panelCalendario.Controls.Add(lblDayz);
                    lblDayz = new Label();
                    lblDayz.Text = "Mie";
                    lblDayz.Name = "DateWed";
                    lblDayz.Anchor = AnchorStyles.None;
                    lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                    lblDayz.ForeColor = Color.White;
                    lblDayz.Font = new Font("Century Gothic", 15);
                    lblDayz.Size = new Size(75, 75);
                    lblDayz.Left = (widthchkr * 4) - (lblDayz.Width / 2);
                    lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                    panelCalendario.Controls.Add(lblDayz);
                    lblDayz = new Label();
                    lblDayz.Text = "Jue";
                    lblDayz.Name = "DateThu";
                    lblDayz.Anchor = AnchorStyles.None;
                    lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                    lblDayz.ForeColor = Color.White;
                    lblDayz.Font = new Font("Century Gothic", 15);
                    lblDayz.Size = new Size(75, 75);
                    lblDayz.Left = (widthchkr * 5) - (lblDayz.Width / 2);
                    lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                    panelCalendario.Controls.Add(lblDayz);
                    lblDayz = new Label();
                    lblDayz.Text = "Vie";
                    lblDayz.Name = "DateFri";
                    lblDayz.Anchor = AnchorStyles.None;
                    lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                    lblDayz.ForeColor = Color.White;
                    lblDayz.Font = new Font("Century Gothic", 15);
                    lblDayz.Size = new Size(75, 75);
                    lblDayz.Left = (widthchkr * 6) - (lblDayz.Width / 2);
                    lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                    panelCalendario.Controls.Add(lblDayz);
                    lblDayz = new Label();
                    lblDayz.Text = "Sab";
                    lblDayz.Name = "DateSat";
                    lblDayz.Anchor = AnchorStyles.None;
                    lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                    lblDayz.ForeColor = Color.White;
                    lblDayz.Font = new Font("Century Gothic", 15);
                    lblDayz.Size = new Size(75, 75);
                    lblDayz.Left = (widthchkr * 7) - (lblDayz.Width / 2);
                    lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                    panelCalendario.Controls.Add(lblDayz);
                    x += 1;

                    for (Int32 i = 1; i <= Dayz; i++)
                    {
                        ndayz += 1;
                        lblDayz = new Label();
                        lblDayz.Text = i.ToString();
                        lblDayz.Cursor = Cursors.Hand;
                        lblDayz.Name = "Date" + i;
                        lblDayz.Anchor = AnchorStyles.None;
                        lblDayz.TextAlign = ContentAlignment.MiddleCenter;
                        if (i == DateTime.Now.Day & MONTHNO == DateTime.Now.Month & YearNO == DateTime.Now.Year)
                        {
                            lblDayz.BackColor = Color.FromArgb(176, 180, 43);
                            lblDayz.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                        }
                        else
                        {
                            lblDayz.BackColor = Color.Transparent;
                            lblDayz.Font = new Font("Century Gothic", 15);
                        }
                        lblDayz.ForeColor = Color.White;
                        lblDayz.Size = new Size(75, 75);
                        lblDayz.Left = (widthchkr * ndayz) - (lblDayz.Width / 2);
                        lblDayz.Top = (hightchkr * Convert.ToInt32(x)) - (lblDayz.Height / 2);
                        if (ndayz == 7)
                        {
                            x += 1;
                            ndayz = 0;
                        }
                        panelCalendario.Controls.Add(lblDayz);
                    }
                    handdatespanel(panelCalendario);
                    x = 1;
                    ndayz = 0;
                }
                catch (FormatException er)
                {
                }
        }

        public void handdatespanel(Panel tp)
        {
            var lbs = tp.Controls.OfType<Label>().Where(lb => lb.Name.Contains("Date"));
            foreach (var lb in lbs)
            {
                if (lb.Text.Length < 3)
                    lb.Click += handlecalevent;
            }
        }

        private void handlecalevent(Object sender, EventArgs e)
        {
            Label xt = (Label)sender;
            string dia = xt.Text;
            DateTime Dia = Convert.ToDateTime("" + dia + "/" + MONTHNO + "/" + YearNO + "");
            string Nombredia = Application.CurrentCulture.Calendar.GetDayOfWeek(Dia).ToString();
            string Nombre_mes = Application.CurrentCulture.DateTimeFormat.GetMonthName(MONTHNO).ToString();
            string fecha = Nombredia + ", " + dia + " de " + Nombre_mes + " del " + YearNO.ToString();
            Citas.Corroborar = "Agendar";
            Citas.nombredia = fecha;
            Citas.Año = YearNO;
            Citas.mes = MONTHNO;
            Citas.dia = Convert.ToInt32(dia);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Me_SizeChanged(object sender, System.EventArgs e)
        {
            try
            {
                compute();
            }
            catch (Exception ex)
            {
            }
        }
        #endregion

        private void pAtras_Click(object sender, EventArgs e)
        {
            if (MONTHNO == 1)
            {
                MONTHNO = 12;
                YearNO = YearNO - 1;
            }
            else
                MONTHNO -= 1;
                compute();
        }

        private void pAdelante_Click(object sender, EventArgs e)
        {
            if (MONTHNO == 12)
            {
                MONTHNO = 1;
                YearNO = YearNO + 1;
            }
            else
            MONTHNO += 1;
            compute();
            panelMes.Refresh();
        }

        #region Metodo de Carga para datos iniciales
        private void Inicio()
        {
            if (Citas.Corroborar != "Dias")
            {
                compute();
            }
            else
            {
                YearNO = Citas.Año;
                MONTHNO = Citas.mes;
                jump = Citas.jump;
                compute();
            }
            Citas.Corroborar = "null";
        }
        #endregion
    }
}
