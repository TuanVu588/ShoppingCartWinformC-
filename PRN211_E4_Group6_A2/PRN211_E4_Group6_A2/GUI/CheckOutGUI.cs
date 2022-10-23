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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  
  
