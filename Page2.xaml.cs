using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace Test1
{
    public partial class Page2 : ContentPage
    {
        // Dictionary สำหรับเก็บรายละเอียดราศี
        private Dictionary<string, string> zodiacDetails = new Dictionary<string, string>
        {
            { "Aries", "\nของนำโชคของราศีเมษ\nหินนำโชค: โรโดไครไซต์, \n                   คาร์เนเลียน\nสัญลักษณ์: แกะ, สีแดง\nสิ่งของ: เทียนสีแดง, \n              เครื่องประดับโลหะ" },
            { "Taurus", "\nของนำโชคของราศีพฤษภ\nหินนำโชค: มรกต, \n                   โรสควอตซ์\nสัญลักษณ์: วัว, สีเขียว\nสิ่งของ: กระถางต้นไม้, \n              ของที่ทำจากไม้" },
            { "Gemini", "\nของนำโชคของราศีเมถุน\nหินนำโชค: ไทเกอร์อาย, \n                   ซิทริน\nสัญลักษณ์: ฝาแฝด, สีเหลือง\nสิ่งของ: หนังสือ, \n              เครื่องเขียน" },
            { "Cancer", "\nของนำโชคของราศีกรกฎ\nหินนำโชค: มูนสโตน, \n                   ไข่มุก\nสัญลักษณ์: ปู, สีขาว\nสิ่งของ: น้ำหอม, \n              ของตกแต่งบ้าน" },
            { "Leo", "\nของนำโชคของราศีสิงห์\nหินนำโชค: ซันสโตน, \n                   โกเมน\nสัญลักษณ์: สิงโต, สีทอง\nสิ่งของ: เครื่องประดับทอง, \n              ดอกไม้" },
            { "Virgo", "\nของนำโชคของราศีกันย์\nหินนำโชค: ไพลิน, \n                   เพริดอต\nสัญลักษณ์: หญิงสาว, สีเขียวอ่อน\nสิ่งของ: สมุดบันทึก, \n             อุปกรณ์เก็บของ" },
            { "Libra", "\nของนำโชคของราศีตุลย์\nหินนำโชค: อเมทิสต์, \n                   ลาพิส ลาซูลี\nสัญลักษณ์: ตาชั่ง, สีฟ้า\nสิ่งของ: กระจก, \n             ของตกแต่งห้อง" },
            { "Scorpio", "\nของนำโชคของราศีพิจิก\nหินนำโชค: โอปอล, \n                   ออบซิเดียน\nสัญลักษณ์: แมงป่อง, สีดำ\nสิ่งของ: เทียนหอม, \n              น้ำมันอโรม่า" },
            { "Sagittarius", "\nของนำโชคของราศีธนู\nหินนำโชค: เทอร์คอยซ์, \n                   ซิทริน\nสัญลักษณ์: คนยิงธนู, สีฟ้า\nสิ่งของ: แผนที่, \n             อุปกรณ์เดินทาง" },
            { "Capricorn", "\nของนำโชคของราศีมังกร\nหินนำโชค: ออนิกซ์, \n                   โกเมน\nสัญลักษณ์: แพะภูเขา, สีเทา\nสิ่งของ: นาฬิกา, \n              เครื่องมือทำงาน" },
            { "Aquarius", "\nของนำโชคของราศีกุมภ์\nหินนำโชค: อเมทิสต์, \n                   อะความารีน\nสัญลักษณ์: คนถือเหยือกน้ำ, \n                  สีม่วง\nสิ่งของ: เครื่องใช้ไฟฟ้า, \n              ของล้ำสมัย" },
            { "Pisces", "\nของนำโชคของราศีมีน\nหินนำโชค: อะความารีน, \n                   มูนสโตน\nสัญลักษณ์: ปลา, สีฟ้าอ่อน\nสิ่งของ: ของตกแต่งที่เกี่ยวกับน้ำ, \n              เปลือกหอย" }
        };

        public ICommand ZodiacCommand { get; }

        public Page2()
        {
            InitializeComponent();
            ZodiacCommand = new Command<string>(OnZodiacButtonClicked);
            BindingContext = this;
        }

        private async void OnZodiacButtonClicked(string zodiacName)
        {
            if (zodiacDetails.TryGetValue(zodiacName, out var zodiacDetail))
            {
                // นำทางไปยัง Page3 พร้อมส่งข้อมูลราศีที่เลือก
                await Navigation.PushAsync(new Page3(zodiacDetail));
            }
            else
            {
                await DisplayAlert("Error", "ไม่พบข้อมูลของราศีนี้", "OK");
            }
        }

    }
}
