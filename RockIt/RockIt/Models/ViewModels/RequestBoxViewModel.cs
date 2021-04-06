using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockIt.Models.ViewModels
{
    public class RequestBoxViewModel
    {
        public RequestBoxViewModel()
        {
            Options = Enum.GetValues(typeof(Article)).Cast<Article>().ToList();
        }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public double Budget { get; set; }
        public List<Article> Options { get; set; }
        public int HatSize { get; set; }
        public HatType HatType { get; set; }
        public int ShoeSize { get; set; }
        public ShoeType ShoeType { get; set; }
        public int SockSize { get; set; }
        public SockType SockType { get; set; }
        public int PantWidth { get; set; }
        public int PantHeight { get; set; }
        public int PantSize { get; set; }
        public PantsType PantsType { get; set; }
        public int ShirtSize { get; set; }
        public int JacketSize { get; set; }
        public JacketType JacketType { get; set; }
        public int BraSize { get; set; }
        public int UnderwearSize { get; set; }
        public UnderwearType UnderwearType { get; set; }
        public int SwimwearSize { get; set; }
        public SwimWearType SwimWearType { get; set; }

    }

    public enum Article
    {
        Pants,
        Shirt,
        Shoes,
        Jacket,
        Socks,
        Hat,
        Underwear,
        Bra,
        SwimWear,
    }

    public enum HatType
    {
        Snapback,
        Baseball
    }
    public enum PantsType
    {
        Sweats,
        Dress,
        Jeans,
        Casual,
        Athletic,
    }
    public enum ShoeType
    {
        Athletic,
        Casual,
        Dress,
        Work,
        Heel,
        Slippers,
        Sliders,
        Boots
    }
    public enum SwimWearType
    {
        OnePiece,
        TwoPiece,
        Bikini
    }
    public enum JacketType
    {
        Light,
        Heavy
    }
    public enum UnderwearType
    {
        Relaxed,
        Sexy,
        Athletic
    }
    public enum SockType
    {
        Athletic,
        Crew,
        Ankle,
        NoShow
    }
}
