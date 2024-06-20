namespace ToBinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sets up the labels.

            label2.Text = "ToBinary";
            label1.Text = "Decial Number: ";


            // Sets up the button.

            button1.Text = "Convert";

        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Set the selected number.
            var selectedNumber = textBox1.Text;



            // Checks if the number is null or not.

            if (string.IsNullOrEmpty(selectedNumber))
            {
                MessageBox.Show("Please insert a number.", "ToBinary Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Calls the converter.

            Converter(selectedNumber);
        }


        private static bool IsNumber(string s)
        {
            foreach (char c in s)
            {

                if (!char.IsDigit(c))
                    return false;

            }
            return true;
        }



        private static void Converter(string possibleNumber)
        {



            // Checks if it is a number and not a string.

            if (IsNumber(possibleNumber) == false)
            {
                MessageBox.Show("Please insert a number.", "ToBinary Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Checks if it is too big.

            try
            {

                if (Convert.ToInt64(possibleNumber) > 9223372036854775807)
                {
                    MessageBox.Show("Please insert a number less than 9223372036854775807.", "ToBinary Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            catch (OverflowException)
            {

                MessageBox.Show("Please insert a number less than 9223372036854775807.", "ToBinary Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Parse the string into an integer.
            long number = Convert.ToInt64(possibleNumber);



            // Convert it into 16bit binary.
            var binary = Convert.ToString(number, 2);

            // Convert it into 16bit hex.
            var hex = Convert.ToString(number, 16);


            // Calls the success form.
            
            Resutl result = new Resutl();
            result.Show();


            // Call function to print the outputs inside of Resutl()

            result.UpdateLabels(binary, hex);

        }
    }
}
