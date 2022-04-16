using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Flats : Form
    {
        const string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab2/lab2/file.xml";
        public List<Flat> flats = new List<Flat>();
        public List<Room> rooms = new List<Room>();
        public Addres addres = new Addres();

        public Flats()
        {
            InitializeComponent();
        }

        private void Flats_Load(object sender, EventArgs e)
        {
            Flat[] arrayFlats = XmlSerializeWrapper.Deserialize<Flat>(filePath);

            foreach (var flat in arrayFlats)
            {
                flats.Add(flat);
            }

            infoAboutRooms.Rows.Add(1, " ", " ", " ");
        }


        private void roomsCounter_ValueChanged(object sender, EventArgs e)
        {
            if (infoAboutRooms.Rows.Count <= (int)roomsCount.Value)
            {
                infoAboutRooms.Rows.Add($"{roomsCount.Value}");
            }
            else
            {
                infoAboutRooms.Rows.RemoveAt((int)roomsCount.Value);
            }

            flatChanged();
        }

        private void serializableButton_Click(object sender, EventArgs e)
        {
            try
            {
                Flat flat = flatChanged();


                flats.Add(flat);

                XmlSerializeWrapper.Serialize<Flat>(flats, filePath);
                MessageBox.Show("Сериализованно");
            }
            catch
            {
                MessageBox.Show("Несериализовано");
            }
        }

        private void deserializableButton_Click(object sender, EventArgs e)
        {
            infoTableAboutFlat.Rows.Clear();

            foreach (var flat in flats)
            {
                infoTableAboutFlat.Rows.Add(flat.Addres.Country, flat.Addres.City, flat.Addres.Street, flat.Addres.District, flat.Addres.House, flat.Addres.FlatNumber,
                    flat.BuildDate, flat.RoomsCount, flat.SquareFootage, flat.Kitchen, flat.BathRoom, flat.Toilet, flat.Basement, flat.Balcony);
            }
        }

        private Flat flatChanged()
        {
            roomsChanged();
            addresChanged();

            Flat flat = new Flat(addres, rooms);
            try
            {
                flat.SquareFootage = Convert.ToDouble(squareFootageBox.Text);
                flat.RoomsCount = Convert.ToInt32(roomsCount.Value);
                flat.BuildDate = buildDate.Value;

                if (kitchenCheckBox.Checked)
                {
                    flat.Kitchen = "+";
                }
                if (bathCheckBox.Checked)
                {
                    flat.BathRoom = "+";
                }
                if (toiletCheckBox.Checked)
                {
                    flat.Toilet = "+";
                }
                if (basementCheckBox.Checked)
                {
                    flat.Basement = "+";
                }
                if (balconyCheckBox.Checked)
                {
                    flat.Balcony = "+";
                }

                flat.PriceCounter();

                PriceBox.Text = Convert.ToString(flat.Price);

                return flat;
            }
            catch
            {
                MessageBox.Show("Только числа (для вещественных чисел использовать запятую)");
                squareFootageBox.Text = "";

                Flat flatNull = new Flat();

                return flatNull;
            }
        }

        private void squareFootageBox_TextChanged(object sender, EventArgs e)
        {
            flatChanged();
        }

        private void roomsGroupBox_Enter(object sender, EventArgs e)
        {
            flatChanged();
        }

        private void roomsChanged()
        {
                for (int i = 0; i < infoAboutRooms.Rows.Count; i++)
                {
                    Room room = new Room();
                    room.Square = Convert.ToDouble(infoAboutRooms[1, i].Value);
                    room.RoomWindows = Convert.ToInt32(infoAboutRooms[2, i].Value);
                    room.WindowsSide = Convert.ToString(infoAboutRooms[3, i].Value);
                }
        }

        private void addresChanged()
        {
            addres.Country = countryBox.Text;
            addres.City = cityBox.Text;
            addres.District = districtBox.Text;
            addres.Street = streetBox.Text;
            addres.House = (int)houseNumber.Value;
            addres.FlatNumber = (int)flatNumber.Value;
        }

    }
}
