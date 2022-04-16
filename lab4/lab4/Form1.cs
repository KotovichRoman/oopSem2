using lab4.Abstract_Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Flats : Form
    {
        const string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab4/lab4/file.xml";
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

        }

        private void roomsCounter_ValueChanged(object sender, EventArgs e)
        {
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

        private void addresChanged()
        {
            addres.Country = countryBox.Text;
            addres.City = cityBox.Text;
            addres.District = districtBox.Text;
            addres.Street = streetBox.Text;
            addres.House = (int)houseNumber.Value;
            addres.FlatNumber = (int)flatNumber.Value;
        }

        private void abstractFactoryButton_Click(object sender, EventArgs e)
        {
            if (FactoryBox.Text == "Беларусь")
            {
                Factory factory = new Factory(new BelarusFactory());
                factory.InfoAboutFactory();

                Addres addres = new Addres();
                BelarusOneRoomFlat belarusOneRoomFlat = new BelarusOneRoomFlat(addres);
                BelarusTwoRoomsFlat belarusTwoRoomsFlat = new BelarusTwoRoomsFlat(addres);

                belarusOneRoomFlat.OneRoomInfo();
                belarusTwoRoomsFlat.TwoRoomsInfo();

                infoTableForFactoty.Rows.Add(belarusOneRoomFlat.Addres.Country, belarusOneRoomFlat.Addres.City,
                                             belarusOneRoomFlat.Addres.District, belarusOneRoomFlat.Addres.Street,
                                             belarusOneRoomFlat.Addres.House, belarusOneRoomFlat.Addres.FlatNumber,
                                             belarusOneRoomFlat.Square, belarusOneRoomFlat.RoomsCount);
                infoTableForFactoty.Rows.Add(belarusTwoRoomsFlat.Addres.Country, belarusTwoRoomsFlat.Addres.City,
                                             belarusTwoRoomsFlat.Addres.District, belarusTwoRoomsFlat.Addres.Street,
                                             belarusTwoRoomsFlat.Addres.House, belarusTwoRoomsFlat.Addres.FlatNumber,
                                             belarusTwoRoomsFlat.Square, belarusTwoRoomsFlat.RoomsCount);
            }
            else if (FactoryBox.Text == "Россия")
            {
                Factory factory = new Factory(new RussianFactory());
                factory.InfoAboutFactory();

                Addres addres = new Addres();
                RussianOneRoomFlat russianOneRoomFlat = new RussianOneRoomFlat(addres);
                RussianTwoRoomsFlat russianTwoRoomsFlat = new RussianTwoRoomsFlat(addres);

                russianOneRoomFlat.OneRoomInfo();
                russianTwoRoomsFlat.TwoRoomsInfo();

                infoTableForFactoty.Rows.Add(russianOneRoomFlat.Addres.Country, russianOneRoomFlat.Addres.City,
                                             russianOneRoomFlat.Addres.District, russianOneRoomFlat.Addres.Street,
                                             russianOneRoomFlat.Addres.House, russianOneRoomFlat.Addres.FlatNumber,
                                             russianOneRoomFlat.Square, russianOneRoomFlat.RoomsCount);
                infoTableForFactoty.Rows.Add(russianTwoRoomsFlat.Addres.Country, russianTwoRoomsFlat.Addres.City,
                                             russianTwoRoomsFlat.Addres.District, russianTwoRoomsFlat.Addres.Street,
                                             russianTwoRoomsFlat.Addres.House, russianTwoRoomsFlat.Addres.FlatNumber,
                                             russianTwoRoomsFlat.Square, russianTwoRoomsFlat.RoomsCount);
            }
            else
            {
                MessageBox.Show("Выберите фабрику");
            }
        }

        public Flat GetFlat()
        {
            Director director = new Director();
            FlatBuilder flatBuilder = new FlatBuilder();

            director.Builder = flatBuilder;
            director.BuildRandomStudent();

            return flatBuilder.GetFlat();
        }

        private void BuilderButton_Click(object sender, EventArgs e)
        {
            flats.Add(GetFlat());

            XmlSerializeWrapper.Serialize(flats, filePath);
            deserializableButton_Click(sender, e);
        }

        private void PrototypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = infoTableAboutFlat.CurrentRow.Index;

                Addres addres = new Addres();
                
                addres.Country = (string)infoTableAboutFlat.Rows[ind].Cells[0].Value;
                addres.City = (string)infoTableAboutFlat.Rows[ind].Cells[1].Value;
                addres.Street = (string)infoTableAboutFlat.Rows[ind].Cells[2].Value;
                addres.District = (string)infoTableAboutFlat.Rows[ind].Cells[3].Value;
                addres.House = (int)infoTableAboutFlat.Rows[ind].Cells[4].Value;
                addres.FlatNumber = (int)infoTableAboutFlat.Rows[ind].Cells[5].Value;

                Flat flat = new Flat(addres);

                flat.BuildDate = (DateTime)infoTableAboutFlat.Rows[ind].Cells[6].Value;
                flat.RoomsCount = (int)infoTableAboutFlat.Rows[ind].Cells[7].Value;
                flat.SquareFootage = (double)infoTableAboutFlat.Rows[ind].Cells[8].Value;

                IPrototype copflat = new Flat(flat);
                IPrototype copiedFlat = copflat.Clone();
                copiedFlat.GetInfo();

                flats.Add(flat);
                XmlSerializeWrapper.Serialize(flats, filePath);
                deserializableButton_Click(sender, e);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Выберите квартира!");
            }
        }

        private void SingletonButton_Click(object sender, EventArgs e)
        {
            SingletonForm singletonForm = SingletonForm.getSingle(BackColor, Font, Size);
            MessageBox.Show(singletonForm.ToString());
        }
    }
}
