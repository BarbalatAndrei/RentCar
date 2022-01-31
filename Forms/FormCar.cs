using RentCar.Cars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar.Forms
{
    public partial class FormCar : Form
    {
        public List<Car> cars = new CarList().GetCars();

        public FormCar()
        {
            InitializeComponent();
        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            LoadTheme();

            listViewCars.View = View.Details;
            for (int i = 0; i < cars.Count; i++)
            {
                listViewCars.Items.Add(cars[0].ToString());
                listViewCars.Items[i].SubItems.Add(cars[i].Brand.ToString());
                listViewCars.Items[i].SubItems.Add(cars[i].Price.ToString());
                listViewCars.Items[i].SubItems.Add(cars[i].Status.ToString());
                listViewCars.Items[i].SubItems.Add(cars[i].VIN.ToString());
            }
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;

                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            listTitleLabel.ForeColor = ThemeColor.SecondaryColor;
            labelBrand.ForeColor = ThemeColor.SecondaryColor;
            labelPrice.ForeColor = ThemeColor.SecondaryColor;
            labelStatus.ForeColor = ThemeColor.SecondaryColor;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBrand.Text = "";
            textPrice.Text = "";
            textStatus.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewCars_MouseClick(object sender, MouseEventArgs e)
        {
            textBrand.Text = listViewCars.SelectedItems[0].SubItems[1].Text;
            textPrice.Text = listViewCars.SelectedItems[0].SubItems[2].Text;
            textStatus.Text = listViewCars.SelectedItems[0].SubItems[3].Text;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrder(), sender);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
