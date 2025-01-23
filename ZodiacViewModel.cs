using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Test1.Models;

public class ZodiacViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Zodiac> ZodiacList { get; set; }

    private Zodiac _selectedZodiac;
    public Zodiac SelectedZodiac
    {
        get => _selectedZodiac;
        set
        {
            if (_selectedZodiac != value)
            {
                _selectedZodiac = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedZodiacDetails));
            }
        }
    }

    public string SelectedZodiacDetails => _selectedZodiac?.Name ?? "โปรดเลือกข้อมูลราศี";

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public ZodiacViewModel()
    {
        ZodiacList = new ObservableCollection<Zodiac>
        {
            new Zodiac { Name = "ราศีเมษ", Image = "aries_card.png" },
            new Zodiac { Name = "ราศีพฤษภ", Image = "taurus_card.png" },
            new Zodiac { Name = "ราศีเมถุน", Image = "gemini_card.png" },
            new Zodiac { Name = "ราศีกรกฎ", Image = "cancer_card.png" },
            new Zodiac { Name = "ราศีสิงห์", Image = "leo_card.png" },
            new Zodiac { Name = "ราศีกันย์", Image = "virgo_card.png" },
            new Zodiac { Name = "ราศีตุลย์", Image = "libra_card.png" },
            new Zodiac { Name = "ราศีพิจิก", Image = "scorpio_card.png" },
            new Zodiac { Name = "ราศีธนู", Image = "sagittarius_card.png" },
            new Zodiac { Name = "ราศีมังกร", Image = "capricorn_card.png" },
            new Zodiac { Name = "ราศีกุมภ์", Image = "aquarius_card.png" },
            new Zodiac { Name = "ราศีมีน", Image = "pisces_card.png" }
        };
    }
}
