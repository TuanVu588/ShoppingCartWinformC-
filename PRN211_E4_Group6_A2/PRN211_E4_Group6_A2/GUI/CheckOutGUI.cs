using System;
using PRN211_E4_Group6_A2.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Net;
using MusicStoreWin.Models;
using Microsoft.Extensions.Configuration;

namespace PRN211_E4_Group6_A2.GUI
{
    public partial class CheckOutGUI : Form
    {
        MusicStoreContext context;
<<<<<<< HEAD
        ShoppingCart cart;
        public CheckOutGUI()
        {
            InitializeComponent();
            context = new MusicStoreContext();
            cart = ShoppingCart.GetCart();
            int id = context.Users.Where(r => r.UserName == Settings.UserName.ToString()).Select(r => r.Id).FirstOrDefault();
            User user = context.Users.Find(id);
            FirstName.Text = user.FirstName;
            LastName.Text = user.LastName;
            Address.Text = user.Address;
            City.Text = user.City;
            State.Text = user.State;
            Country.Text = user.Country;
            Phone.Text = user.Phone;
            Email.Text = user.Email;
            Total.Text = cart.GetTotal().ToString();
=======

        public CheckOutGUI(int Id, MusicStoreContext context)
        {
            InitializeComponent();
            FirstName.Text = FirstName.ToString();
            LastName.Text = LastName.ToString();
            Email.Text = Email.ToString();
            this.context = context;
            if (Id != -1)
            {
                Order order = context.Orders.Find(Total);
                User user = context.Users.Find(Id);
                FirstName.Text = user.FirstName;
                LastName.Text = user.LastName;
                Address.Text = user.Address;
                City.Text = user.City;
                State.Text = user.State;
                Country.Text = user.Country;
                Phone.Text = user.Phone;
                Email.Text = user.Email;
                Total.Text = Total.ToString();
            }

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
>>>>>>> ae03ecb2ade2e9a7261b04af287ca0787bb6334f

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            cart = ShoppingCart.GetCart();
            Order o = new Order();
            o.FirstName = FirstName.Text;
            o.LastName = LastName.Text;
            o.Address = Address.Text;
            o.City = City.Text;
            o.State = State.Text;
            o.Country = Country.Text;
            o.Phone = Phone.Text;
            o.Email = Email.Text;
            o.Total = decimal.Parse(Total.Text);           
            cart.CreateOrder(o);
            MessageBox.Show($"Order id {o.OrderId} is saved!");
            this.Close();
=======
            if (int.Parse(FirstName.Text) == -1)
            {
                Order order = new Order
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Address = Address.Text,
                    City = City.Text,
                    State = State.Text,
                    Country = Country.Text,
                    Phone = Phone.Text,
                    Email = Email.Text,
                };
                try
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                    MessageBox.Show("have been saved");
                }
                catch
                {
                    MessageBox.Show("Failed!");
                }
            }
>>>>>>> ae03ecb2ade2e9a7261b04af287ca0787bb6334f
        }


        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

  
  
