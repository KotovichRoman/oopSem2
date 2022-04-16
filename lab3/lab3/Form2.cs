using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace lab3
{
    public partial class Form2 : Form
    {
        const string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab3/lab3/file.xml";
        Addres searchAddres = new Addres();

        public Form2()
        {
            InitializeComponent();
        }

        private void Search()
        {
            infoTableAboutFlat.Rows.Clear();

            Flat[] arrayFlats = XmlSerializeWrapper.Deserialize<Flat>(filePath);
            List<Flat> foundItems = new List<Flat>();

            searchAddres.City = cityBox.Text;
            searchAddres.District = districtBox.Text;

            Flat searchFlat = new Flat(searchAddres);

            searchFlat.RoomsCount = Convert.ToInt32(roomsCount.Value);
            searchFlat.BuildDate = buildDate.Value;

            if (!String.IsNullOrEmpty(searchFlat.Addres.City) && searchFlat.Addres.District == "")
            {
                Regex regex = new Regex(searchFlat.Addres.City);
                foreach (var flat in arrayFlats)
                {
                    if (regex.IsMatch(flat.Addres.City))
                    {
                        foundItems.Add(flat);
                    }
                }
            }
            else if (!String.IsNullOrEmpty(searchFlat.Addres.District) && searchFlat.Addres.City == "")
            {
                Regex regex = new Regex(searchFlat.Addres.District);
                foreach (var flat in arrayFlats)
                {
                    if (regex.IsMatch(flat.Addres.District))
                    {
                        foundItems.Add(flat);
                    }
                }
            }
            else if (!String.IsNullOrEmpty(searchFlat.Addres.City) && !String.IsNullOrEmpty(searchFlat.Addres.District))
            {
                Regex regexCity = new Regex(searchFlat.Addres.District);
                Regex regexDistrict = new Regex(searchFlat.Addres.District);
                foreach (var flat in arrayFlats)
                {
                    if (regexDistrict.IsMatch(flat.Addres.District) && regexCity.IsMatch(flat.Addres.City))
                    {
                        foundItems.Add(flat);
                    }
                }
            }
            else
            {
                foreach (var element in arrayFlats)
                {
                    foundItems.Add(element);
                }
            }

            foreach (var element in foundItems)
            {
                bool flag = true;

                if (searchFlat.RoomsCount != element.RoomsCount)
                {
                    flag = false;
                }

                if (searchFlat.BuildDate != element.BuildDate || searchFlat.BuildDate == DateTime.Now)
                {
                    flag = false;
                }
            
                if (flag)
                {
                    infoTableAboutFlat.Rows.Add(element.Addres.Country, element.Addres.City, element.Addres.Street,
                        element.Addres.District, element.Addres.House, element.Addres.FlatNumber,
                        element.BuildDate, element.RoomsCount, element.SquareFootage, element.Kitchen,
                        element.BathRoom, element.Toilet, element.Basement, element.Balcony, element.Price);
                }
            }
        }

        private void roomsCount_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void buildDate_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void districtBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

    }
}
