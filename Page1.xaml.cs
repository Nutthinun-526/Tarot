using Microsoft.Maui.Controls;
using System;
using System.Threading.Tasks;

namespace Test1;

public partial class Page1 : ContentPage
{
    public Page1()
    {
        InitializeComponent();
    }
    // รายการโชคและรูปภาพที่เกี่ยวข้อง
    private readonly string[] fortunes = new string[]
    {
            "โชคดีมาก",
            "โชคดี",
            "ปานกลาง",
            "ระวังตัว",
            "เคราะห์ร้าย"
    };

    private readonly string[] fortuneImages = new string[]
    {
            "tarot_a.png",  // รูปสำหรับ "โชคดีมาก"
            "tarot_b.png",  // รูปสำหรับ "โชคดี"
            "tarot_c.png",  // รูปสำหรับ "ปานกลาง"
            "tarot_d.png",  // รูปสำหรับ "ระวังตัว"
            "tarot_e.png"   // รูปสำหรับ "เคราะห์ร้าย"
    };

    private Random random = new Random();

    // ฟังก์ชันสุ่มดวงและ Flip การ์ด
    private async void OnRandomFortuneClicked(object sender, EventArgs e)
    {
        // เริ่มการหมุนการ์ด 3 ครั้ง
        for (int i = 0; i < 3; i++)
        {
            // ย่อการ์ดลงเล็กน้อย
            await fortuneImage.ScaleTo(0.7, 150);

            // หมุนการ์ดด้านข้าง 180 องศา
            await fortuneImage.RotateYTo(360, 300);

            // หมุนกลับมาที่ 0 องศา
            await fortuneImage.RotateYTo(0, 300);

            // คืนขนาดการ์ดกลับมาปกติ
            await fortuneImage.ScaleTo(1.0, 150);
        }

        // ขยายการ์ดเมื่อหมุนครบ 3 ครั้ง
        await fortuneImage.ScaleTo(1.1, 150);

        // สุ่มคำทำนาย
        int fortuneIndex = random.Next(fortunes.Length);
        string fortuneResult = fortunes[fortuneIndex];
        string fortuneImageSource = fortuneImages[fortuneIndex];

        // เปลี่ยนรูปภาพและข้อความเมื่อการ์ดหันด้านหลัง
        fortuneImage.Source = fortuneImageSource;
        resultLabel.Text = $"ผลทำนาย: {fortuneResult}";

        // คืนขนาดการ์ดกลับมาปกติหลังแสดงผล
        await fortuneImage.ScaleTo(1.0, 150);

        // รอ 3 วินาที แล้วรีเซ็ตข้อความและรูปภาพ
        await Task.Delay(3000);
        fortuneImage.Source = "tarot.png";
        resultLabel.Text = "กดปุ่มเพื่อทำนายโชคของคุณ";
    }
}