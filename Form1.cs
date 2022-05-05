namespace xlanor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_button_Click(object sender, EventArgs e)
        {
            // Get variables from the user
            string name = "";
            string surname = "";
            int day_of_birth = 0;
            string month_of_birth = "";
            int year_of_birth = 0;
            string answer = "";

            //Store variables from textboxes
            name = name_of_the_user.Text;
            surname = surname_of_the_user_box.Text;
            day_of_birth = Int32.Parse(day_of_birth_form.Text);
            month_of_birth = month_of_birth_box.Text;
            year_of_birth = Int32.Parse(year_of_birth_form.Text);
            answer = special_q_answer.Text;

            //Create a string for password
            string password = "";

            //Generate a random number
            Random rnd = new Random();
            
            //Get random char from each given string variable
            int name_random = rnd.Next(name.Length);
            int surname_random = rnd.Next(surname.Length);
            int day_birth_random = rnd.Next(day_of_birth.ToString().Length);
            int birth_month_random = rnd.Next(month_of_birth.Length);
            int year_birth_random = rnd.Next(year_of_birth.ToString().Length);
            int answer_random = rnd.Next(answer.Length);

            //Generate the password
            string generated_password = "";

            //Add items to the password
            generated_password += name.ElementAt(name_random);
            generated_password += surname.ElementAt(surname_random);
            generated_password += day_birth_random;
            generated_password += month_of_birth.ElementAt(birth_month_random);
            generated_password += year_birth_random;
            generated_password += answer.ElementAt(answer_random);

            //Turn generated password into string
            string gen_passwd = "";

            //Loop through
            for(int i = generated_password.Length-1; i > 0; i--)
            {
                gen_passwd += generated_password[i];
            }

            //Display the password in the other form
            password parola = new password();
            parola.paswd_label.Text = gen_passwd ;
            parola.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show about section
            About about = new About();
            about.Show();
        }
    }
}