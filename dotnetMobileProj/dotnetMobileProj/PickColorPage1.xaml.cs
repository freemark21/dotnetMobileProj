using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dotnetMobileProj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickColorPage1 : ContentPage
    {   
        Dictionary<string, Color> colorDict = new Dictionary<string, Color>
        {
            { "Aqua", Color.Aqua }, { "Black", Color.Black },
            { "Blue", Color.Blue }, { "Pink", Color.Pink },
            { "Gray", Color.Gray }, { "Green", Color.Green },
            { "Lime", Color.Lime }, { "Maroon", Color.Maroon },
            { "Navy", Color.Navy }, { "Olive", Color.Olive },
            { "Purple", Color.Purple }, { "Red", Color.Red },
            { "Silver", Color.Silver }, { "Teal", Color.Teal },
            { "White", Color.White }, { "Yellow", Color.Yellow }
        };
        public PickColorPage1()
        {
            InitializeComponent();
            //remove backgroundcolor resource (picker text color not changeable)
            BackgroundColor = Color.Default;

            //create list for picker
            var colorList = new List<string>();
            foreach (string colorName in colorDict.Keys)
            {
                colorList.Add(colorName);
            }
            //add list to picker
            pickerColorPicker.ItemsSource = colorList;
        }

        
        public void pickerColorPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
  
           
            if (pickerColorPicker.SelectedIndex == -1)
            {
                bxvColorPicker.Color = Color.Default;
            }
            else
            {
                //change boxview color to picked color

                bxvColorPicker.Color = colorDict[pickerColorPicker.SelectedItem.ToString()];
            }
        }

    }
}