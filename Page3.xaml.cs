using AndroidX.Lifecycle;
using Microsoft.Maui.Controls;

namespace Test1
{
    public partial class Page3 : ContentPage
    {
        public Page3(string zodiacDetail)
        {
            InitializeComponent();

            // กำหนด ViewModel
            var viewModel = new ZodiacViewModel();
            BindingContext = viewModel;

            // ตั้งค่าข้อมูลรายละเอียดเพิ่มเติม
            ZodiacDetailsLabel.Text = zodiacDetail;

            // ถ้าต้องการอัปเดต SelectedZodiac ใน ViewModel
            var initialZodiac = viewModel.ZodiacList.FirstOrDefault(z => zodiacDetail.Contains(z.Name));
            if (initialZodiac != null)
            {
                viewModel.SelectedZodiac = initialZodiac;
            }
        }
    }
}