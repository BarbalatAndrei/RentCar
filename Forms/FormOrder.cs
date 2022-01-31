using RentCar.CompositeAndDecorator;
using RentCar.CompositeAndDecorator.CarElements;
using RentCar.CompositeAndDecorator.CompositePattern;
using RentCar.CompositeAndDecorator.DecoratorPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCar.Cars;

namespace RentCar.Forms
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        public List<Cars.Car> cars = new CarList().GetCars();

        public List<ICar> carElements = new List<ICar>();

        Composite carComposite = new Composite();


        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadTheme();
            CompositeImplementation();
            displayCarList();
            displayElements();
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

            labelAditionalLabel.ForeColor = ThemeColor.SecondaryColor;
            labelCurrentPrice.ForeColor = ThemeColor.SecondaryColor;
            labelDashboard.ForeColor = ThemeColor.SecondaryColor;
            labelEngine.ForeColor = ThemeColor.SecondaryColor;
            labelNewPrice.ForeColor = ThemeColor.SecondaryColor;
            labelSeats.ForeColor = ThemeColor.SecondaryColor;
            labelTrunk.ForeColor = ThemeColor.SecondaryColor;
            labelParktroniks.ForeColor = ThemeColor.SecondaryColor;
            labelAditional.ForeColor = ThemeColor.SecondaryColor;

        }

        public void CompositeImplementation()
        {
            var newCar = new Client().getCar();

            Composite frontPart = new Composite();
            Engine engine = newCar.setEngine();
            frontPart.addElement(engine);

            Composite backPart = new Composite();
            Trunk trunk = newCar.setTrunk();
            BackParktronics backParktronics = newCar.setParktonics();
            backPart.addElement(trunk);
            backPart.addElement(backParktronics);

            Composite interiorPart = new Composite();
            Seats seats = newCar.setSeats();
            Dashboard dashboard = newCar.setDashboard();
            interiorPart.addElement(seats);
            interiorPart.addElement(dashboard);
                
            carComposite.addElement(frontPart);
            carComposite.addElement(interiorPart);
            carComposite.addElement(backPart);

            AutopilotOptions myCar = new AutopilotOptions(carComposite);

        }

        public void displayCarList()
        {
            listCarListOrder.View = View.Details;
            for (int i = 0; i < cars.Count; i++)
            {
                listCarListOrder.Items.Add(cars[0].ToString());
                listCarListOrder.Items[i].SubItems.Add(cars[i].Brand.ToString());
                listCarListOrder.Items[i].SubItems.Add(cars[i].Price.ToString());
            }
        }

        public void displayElements()
        {
            carElements = carComposite.getElements();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listCarListOrder_MouseClick(object sender, MouseEventArgs e)
        {
            textEngine.Text = carElements[0].showElementDetail(0).ToString();
            textSeats.Text = carElements[1].showElementDetail(0).ToString();
            textDashboard.Text = carElements[1].showElementDetail(1).ToString();
            textTrunk.Text = carElements[2].showElementDetail(0).ToString();
            textParktroniks.Text = carElements[2].showElementDetail(1).ToString();
            textCurrentPrice.Text = carComposite.getElementPrice().ToString();

        }

        private void btnAutoPilot_Click(object sender, EventArgs e)
        {
            AutopilotOptions myCar = new AutopilotOptions(carComposite);
            textAutopilot.Text = "+ Autopilot Option";
            textNewPrice.Text = myCar.cost().ToString();
        }
    }
}
