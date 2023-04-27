using PokeAPI;
using System.Security.Principal;
using System.Windows.Forms;
using System.Xml.Linq;
//creating the form
namespace secondtolast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //acidental event
        private void Form1_Load(object sender, EventArgs  e)
        {
        }

        public async void GetSpicies()
        {
            // in async method
            // geting the Id variable and calling the API
            int pokemonID = Convert.ToInt32(txt_PokeID.Text);           
            PokemonSpecies p = await DataFetcher.GetApiObject<PokemonSpecies>(pokemonID);

            //Declaring variables
            txt_test.Text = p.Name;
            txt_BHappy.Text = Convert.ToString(p.BaseHappiness);
            txt_CaptureRate.Text = Convert.ToString(p.CaptureRate);

            //looping through the egg groups
            txt_EggGroup.Text = "";
            for (int i = 0; i < p.EggGroups.Length; i++)
                txt_EggGroup.Text = txt_EggGroup.Text + " " + p.EggGroups[i].Name;

            //more variables
            txt_GrowthRate.Text = Convert.ToString(p.GrowthRate.Name);
            txt_Habitat.Text = p.Habitat.Name;

            //looping through flavor text
            rtx_FlavorText.Text = "";
            for (int i = 0; i < p.FlavorTexts.Length; i++)
                rtx_FlavorText.Text = rtx_FlavorText.Text + " " + p.FlavorTexts[i].FlavorText.ToString();
        }

        //the button event that calles the API
        private void btn_test_Click(object sender, EventArgs e)
        {
            //input validation for blanks and calling the function
            try
            {
                int pokemonID = Convert.ToInt32(txt_PokeID.Text);
                GetSpicies();
            }
            catch (Exception)
            {
                if (txt_PokeID.Text == "")
                    MessageBox.Show("please enter an ID");
                return;
            }
        }

        //accidental event
        private void label1_Click(object sender, EventArgs e)
        {
        }

        //input validation consept one
        private void txt_PokeID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PokeID.Text))
            {
                e.Cancel = true;
                txt_PokeID.Focus();
                ep_InputValidation.SetError(txt_PokeID, "Name should not be left blank!");
            }

            else
            {
                e.Cancel = false;
                ep_InputValidation.SetError(txt_PokeID, "");
            }
        }

//blank event
        private void txt_PokeID_TextChanged(object sender, EventArgs e)
        {
        }

        //input validation, stopping strings and decimal points
        private void txt_PokeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow no decimal points
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > 0))
            {
                e.Handled = true;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }  
}