namespace Test1
{
    public partial class App : Application
    {
        // คอนสตรัคเตอร์นี้จะไม่ตั้งค่า MainPage โดยตรง
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
           // ใช้ NavigationPage เพื่อห่อหุ้ม MainPage
           return new Window(new NavigationPage(new MainPage())); // ตั้งค่า MainPage เป็นหน้าเริ่มต้น
        }
    }
}
