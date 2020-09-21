using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizzas_R_Us_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //the subtotal is stored in this variable
        decimal subtotal;

        private void btnAddSpeciality_Click(object sender, EventArgs e)
        {

            //Depending on what the user picks, add the stated price to the declared variable
            if (rdoMargheritaSmall.Checked || rdoPepperoniSmall.Checked || rdoHawaiianSmall.Checked || rdoMeatFeastSmall.Checked || rdoVegetarianSmall.Checked)
            {
                subtotal += 9.99m;
                //different string is diplayed in basket depending on user choice.
                if (rdoMargheritaSmall.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Margherita Small - £9.99");
                }
                if (rdoPepperoniSmall.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Pepperoni Small - £9.99");
                }
                if (rdoHawaiianSmall.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Hawaiian Small - £9.99");
                }
                if (rdoMeatFeastSmall.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Meat Feast Small - £9.99");
                }
                if (rdoVegetarianSmall.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Vegetarian Small - £9.99");
                }
                lblSubtotalNumber.Text = $"£{subtotal}";
            }


            //Depending on what the user picks, add the stated price to the declared variable
            if (rdoMargheritaMedium.Checked || rdoPepperoniMedium.Checked || rdoHawaiianMedium.Checked || rdoMeatFeastMedium.Checked || rdoVegetarianMedium.Checked)
            {
                subtotal += 13.99m;
                //different string is diplayed in basket depending on user choice.
                if (rdoMargheritaMedium.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Margherita Medium - £13.99");
                }
                if (rdoPepperoniMedium.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Pepperoni Medium - £13.99");
                }
                if (rdoHawaiianMedium.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Hawaiian Medium - £13.99");
                }
                if (rdoMeatFeastMedium.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Meat Feast Medium - £13.99");
                }
                if (rdoVegetarianMedium.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Vegetarian Medium - £13.99");
                }
                lblSubtotalNumber.Text = $"£{subtotal}";

            }
            //Depending on what the user picks, add the stated price to the declared variable
            if (rdoMargheritaLarge.Checked || rdoPepperoniLarge.Checked || rdoHawaiianLarge.Checked || rdoMeatFeastLarge.Checked || rdoVegetarianLarge.Checked)
            {
                subtotal += 17.99m;
                //different string is diplayed in basket depending on user choice.
                if (rdoMargheritaLarge.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Margherita Large - £17.99");
                }
                if (rdoPepperoniLarge.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Pepperoni Large - £17.99");
                }
                if (rdoHawaiianLarge.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Hawaiian Large - £17.99");
                }
                if (rdoMeatFeastLarge.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Meat Feast Large - £17.99");
                }
                if (rdoVegetarianLarge.Checked)
                {
                    lstBasket.Items.Add("Speciality Item: Vegetarian Large - £17.99");
                }
                lblSubtotalNumber.Text = $"£{subtotal}";
            }


        }

        private void btnCustomise_Click(object sender, EventArgs e)
        {
            //if the user clicks this radio button, this code is excecuted.
            if (rdoCustomiseSmall.Checked)
            {
                //increases the subtotal by this amount
                subtotal += 9.99m;

                decimal checkBoxCount = 0;
                //calculates how many check boxes the user has checked when picking toppings and adds the total to the variable above

                //stores the names of the toppings in a variable
                String toppings = "";
                foreach (Control c in groupBox3.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox check = (CheckBox)c;
                        if (check.Checked)
                        {
                            toppings += check.Text + ", ";
                            checkBoxCount++;
                        }
                    }
                }
                //multiplies the amount stored by 49 pence price per topping
                checkBoxCount = (checkBoxCount * 49);
                checkBoxCount = (checkBoxCount / 100);

                //calculates the number to display in the list box
                decimal listBoxText = 9.99m + checkBoxCount;
                //calculates the number to show in the subtotal
                subtotal = subtotal + checkBoxCount;
                lblSubtotalNumber.Text = $"£{subtotal}";
                lstBasket.Items.Add($"Customised Pizza - £{listBoxText} - {toppings}");
            }

            //if the user clicks this radio button, this code is excecuted.
            if (rdoCustomiseMedium.Checked)
            {
                //increases the subtotal by this amount
                subtotal += 13.99m;

                decimal checkBoxCount = 0;
                //calculates how many check boxes the user has checked when picking toppings and adds the total to the variable above

                //stores the names of the toppings in a variable
                String toppings = "";
                foreach (Control c in groupBox3.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox check = (CheckBox)c;
                        if (check.Checked)
                        {
                            toppings += check.Text + ", ";
                            checkBoxCount++;
                        }
                    }
                }
                //multiplies the amount stored by 49 pence price per topping
                checkBoxCount = (checkBoxCount * 49);
                checkBoxCount = (checkBoxCount / 100);

                //calculates the number to display in the list box
                decimal listBoxText = 13.99m + checkBoxCount;
                //calculates the number to show in the subtotal
                subtotal = subtotal + checkBoxCount;
                lblSubtotalNumber.Text = $"£{subtotal}";
                lstBasket.Items.Add($"Customised Pizza - £{listBoxText} - {toppings}");
            }

            //if the user clicks this radio button, this code is excecuted.
            if (rdoCustomiseLarge.Checked)
            {
                //increases the subtotal by this amount
                subtotal += 17.99m;

                decimal checkBoxCount = 0;
                //calculates how many check boxes the user has checked when picking toppings and adds the total to the variable above

                //stores the names of the toppings in a variable
                String toppings = "";
                foreach (Control c in groupBox3.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox check = (CheckBox)c;
                        if (check.Checked)
                        {
                            toppings += check.Text + ", ";
                            checkBoxCount++;
                        }
                    }
                }
                //multiplies the amount stored by 49 pence price per topping
                checkBoxCount = (checkBoxCount * 49);
                checkBoxCount = (checkBoxCount / 100);

                //calculates the number to display in the list box
                decimal listBoxText = 17.99m + checkBoxCount;
                //calculates the number to show in the subtotal
                subtotal = subtotal + checkBoxCount;
                lblSubtotalNumber.Text = $"£{subtotal}";
                lstBasket.Items.Add($"Customised Pizza - £{listBoxText} - {toppings}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //adds the correct item and price to subtotal and list box
            if (rdoMeatballs.Checked)
            {
                subtotal += 3.99m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoMeatballs.Text);
            }

            if (rdoGarlicBread.Checked)
            {
                subtotal += 4.50m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoGarlicBread.Text);
            }

            if (rdoPizzaBread.Checked)
            {
                subtotal += 4.50m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoPizzaBread.Text);
            }

            if (rdoPotatoWedges.Checked)
            {
                subtotal += 3.50m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoPotatoWedges.Text);
            }

            if (rdoDipSelection.Checked)
            {
                subtotal += 0.99m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoDipSelection.Text);
            }

            if (rdoColesaw.Checked)
            {
                subtotal += 1.99m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoColesaw.Text);
            }

            if (rdoCoke.Checked)
            {
                subtotal += 1.49m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoCoke.Text);
            }

            if (rdoFanta.Checked)
            {
                subtotal += 1.49m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoFanta.Text);
            }

            if (rdoWater.Checked)
            {
                subtotal += 1.49m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoWater.Text);
            }

            if (rdoMonster.Checked)
            {
                subtotal += 1.49m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoMonster.Text);
            }

            if (rdoSprite.Checked)
            {
                subtotal += 1.49m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoSprite.Text);
            }

            if (rdoOasis.Checked)
            {
                subtotal += 1.49m;
                lblSubtotalNumber.Text = Convert.ToString($"£{ subtotal}");
                lstBasket.Items.Add(rdoOasis.Text);
            }
        }

        private void btnClearBasket_Click(object sender, EventArgs e)
        {
            //validation technique to ensure the user doensn't accidentally clear the basket.
            DialogResult customerChoice = MessageBox.Show("Are you sure you want to clear the basket?", "Clear Basket", MessageBoxButtons.YesNo);
            if (customerChoice == DialogResult.Yes)
            {
                subtotal = 0;
                lblSubtotalNumber.Text = ($"£{subtotal}");
                lstBasket.Items.Clear();
            }

            else { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //leaves a message to the user if no item has been selected in the listbox
            if (lstBasket.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item first");
            }

            else
            {
                DialogResult customerChoice = MessageBox.Show("Remove selection from basket?", "Remove selection", MessageBoxButtons.YesNo);
                if (customerChoice == DialogResult.Yes)
                {
                    //Extracts the selected list box item and stores it in a string
                    string listBoxText = lstBasket.GetItemText(lstBasket.SelectedItem);
                    string b = string.Empty;
                    //stores only the numbers from the extracted string
                    decimal extractedNumber;

                    //finds only the numbers in the stated string and stores them in the empty string
                    for (int i = 0; i < listBoxText.Length; i++)
                    {
                        if (Char.IsDigit(listBoxText[i]))
                            b += listBoxText[i];
                    }

                    //if the string has numbers, store the number in the decimal datatype and convert to £.
                    if (b.Length > 0)
                    {
                        extractedNumber = int.Parse(b);
                        extractedNumber = extractedNumber / 100;

                        //reduces the subtotal and display to the user.
                        subtotal = subtotal - extractedNumber;
                        lblSubtotalNumber.Text = Convert.ToString($"£{subtotal}");


                    }

                    //Removes the selected listbox item
                    for (int i = lstBasket.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        lstBasket.Items.RemoveAt(lstBasket.SelectedIndices[i]);
                    }
                }
            }

            

        }

    }
}
