using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarComputers
{
    enum ProductFields
    {

    ProductID,
    Cost,
    Manufacturer,
    Model,
    Ram_Type,
    Ram_Size,

    Display_Type,
    Screen_Size,
    Resolution,
    CPU_Class,
    CPU_Brand,
    CPU_Type,
    CPU_Speed,

    CPU_Number,
    Condition,
    OS,
    Platform,
    HDD_Size,
    HDD_Speed,

    GPU_Type,
    Optical_Drive,
    Audio_Type,
    LAN,
    WIFI,
    Width,

    Height,
    Depth,
    Weight,
    Mouse_Type,
    Power,
    Webcam,
    NUM_OF_FIELDS

}



    public class ProductInfoClass
    {
        public int ProductID { get; set; }
        public float Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RamType { get; set; }
        public string RamSize { get; set; }

        public string DisplayType { get; set; }
        public string ScreenSize { get; set; }
        public string Resolution { get; set; }
        public string CPUClass { get; set; }
        public string CPUBrand { get; set; }
        public string CPUType { get; set; }
        public string CPUSpeed { get; set; }

        public string CPUNumber { get; set; }
        public string Condition { get; set; }
        public string OS { get; set; }
        public string Platform { get; set; }
        public string HDDSize { get; set; }
        public string HDDSpeed { get; set; }

        public string GPUType { get; set; }
        public string OpticalDrive { get; set; }
        public string AudioType { get; set; }
        public string LAN { get; set; }
        public string WIFI { get; set; }
        public string Width { get; set; }

        public string Height { get; set; }
        public string Depth { get; set; }
        public string Weight { get; set; }
        public string MouseType { get; set; }
        public string Power { get; set; }
        public string Webcam { get; set; }



    }
}
