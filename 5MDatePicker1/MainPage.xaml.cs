namespace _5MDatePicker1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            dpDatePickerRez2.Date = DateTime.Now.AddDays(1);
            dpDatePickerRez2.MinimumDate = DateTime.Now.AddDays(1);
            dpDatePickerRez1.MinimumDate = DateTime.Now;
        }

        private void onDatePicker1Selected(object sender, EventArgs e)
        {
            lblData.Text = dpDatePicker1.Date.ToString("yyyy-MM-dd");
        }
        private void btnUstawClicked(object sender, EventArgs e)
        {
            dpDatePicker2.Date = new DateTime(2024, 05, 15);
        }

        private void dpRezerwackaSelected(object sender, EventArgs e)
        {
            if (dpDatePickerRez1.Date > dpDatePickerRez2.Date)
                lblDni.Text = "zły wybór";
            else
            {
                //lblDni.Text = "dobry wybór";
                lblDni.Text = (dpDatePickerRez2.Date - dpDatePickerRez1.Date).Days.ToString();
            }
        }

    }

}
