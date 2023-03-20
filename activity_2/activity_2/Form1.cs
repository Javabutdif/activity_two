namespace activity_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("Iphone 12");
            wishList.Items.Add("Mac OS");
            wishList.Items.Add("Gaming Computer");
            wishList.Items.Add("Rice");
            wishList.Items.Add("Coke");
            wishList.Items.Add("Car");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectionBox.Text = wishList.Text;
        }

        private void selectionBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            countBox.Text = Convert.ToString(wishList.Items.Count);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}