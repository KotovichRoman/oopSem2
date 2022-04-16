using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab3
{
    public partial class Flats : Form
    {
        const string filePath = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab3/lab3/file.xml";
        const string filePathSortBySquare = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab3/lab3/fileSortBySquare.xml";
        const string filePathSortByRoomsCount = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab3/lab3/fileSortByRoomsCount.xml";
        const string filePathSortByCity = "C:/Users/User/Desktop/GitHub/oop (sem 2)/lab3/lab3/fileSortByCity.xml";
        public List<Flat> flats = new List<Flat>();
        public List<Room> rooms = new List<Room>();
        public Addres addres = new Addres();
        string LastEvent;

        public Flats()
        {
            InitializeComponent();

            searchStripButton.Click += searchStripButton_Click;
            поПлощадиToolStripMenuItem.Click += SortBySquare_Click;
            поКоличествукомнатToolStripMenuItem.Click += SortByRoomsCount_Click;
            поГородуToolStripMenuItem.Click += SortByCity_Click;
            aboutProgram.Click += aboutProgram_Click;
            hideButton.Click += HideButton_Click;
            backwardButton.Click += UndoAction;
            forewardButton.Click += RedoAction;
            LastEventLabel();
            objectsCount_Value();
            TimeLabel();
        }

        private static void Validate(Flat flat)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(flat);
            if (!Validator.TryValidateObject(flat, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("Пользователь прошел валидацию!");
            }
        }

        private void Flats_Load(object sender, EventArgs e)
        {
            Flat[] arrayFlats = XmlSerializeWrapper.Deserialize<Flat>(filePath);

            foreach (var flat in arrayFlats)
            {
                flats.Add(flat);
            }
        }

        private void serializableButton_Click(object sender, EventArgs e)
        {
            try
            {
                addresChanged();

                Flat flat = new Flat(addres, rooms);

                flat.SquareFootage = Convert.ToDouble(squareFootageBox.Text);
                flat.RoomsCount = Convert.ToInt32(roomsCount.Value);
                flat.BuildDate = buildDate.Value;
                flat.Price = Convert.ToDouble(PriceBox.Text);

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

                Validate(flat);

                flats.Add(flat);

                XmlSerializeWrapper.Serialize<Flat>(flats, filePath);
                MessageBox.Show("Сериализованно");
                LastEvent = "Сериализация";
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
                infoTableAboutFlat.Rows.Add(flat.Addres.Country, flat.Addres.City, flat.Addres.Street,
                        flat.Addres.District, flat.Addres.House, flat.Addres.FlatNumber,
                        flat.BuildDate, flat.RoomsCount, flat.SquareFootage, flat.Kitchen,
                        flat.BathRoom, flat.Toilet, flat.Basement, flat.Balcony, flat.Price);
            }
        }

        private void flatChanged()
        {
            Flat flat = new Flat();
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
            }
            catch
            {
                MessageBox.Show("Только числа (для вещественных чисел использовать запятую)");
                squareFootageBox.Text = "";

                Flat flatNull = new Flat();
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

        private void searchStripButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            LastEvent = "Поиск";
        }

        private void SortBySquare_Click(object sender, EventArgs e)
        {
            infoTableAboutFlat.Rows.Clear();

            var sortedItem = flats.OrderBy(flat => flat.SquareFootage).ToList();

            foreach (var flat in sortedItem)
            {
                infoTableAboutFlat.Rows.Add(flat.Addres.Country, flat.Addres.City, flat.Addres.Street,
                        flat.Addres.District, flat.Addres.House, flat.Addres.FlatNumber,
                        flat.BuildDate, flat.RoomsCount, flat.SquareFootage, flat.Kitchen,
                        flat.BathRoom, flat.Toilet, flat.Basement, flat.Balcony, flat.Price);
            }

            XmlSerializeWrapper.Serialize<Flat>(sortedItem, filePathSortBySquare);
            LastEvent = "Сортировка";
        }

        private void SortByRoomsCount_Click(object sender, EventArgs e)
        {
            infoTableAboutFlat.Rows.Clear();

            var sortedItem = flats.OrderBy(flat => flat.RoomsCount).ToList();

            foreach (var flat in sortedItem)
            {
                infoTableAboutFlat.Rows.Add(flat.Addres.Country, flat.Addres.City, flat.Addres.Street,
                        flat.Addres.District, flat.Addres.House, flat.Addres.FlatNumber,
                        flat.BuildDate, flat.RoomsCount, flat.SquareFootage, flat.Kitchen,
                        flat.BathRoom, flat.Toilet, flat.Basement, flat.Balcony, flat.Price);
            }

            XmlSerializeWrapper.Serialize<Flat>(sortedItem, filePathSortByRoomsCount);
            LastEvent = "Сортировка";
        }

        private void SortByCity_Click(object sender, EventArgs e)
        {
            infoTableAboutFlat.Rows.Clear();

            var sortedItem = flats.OrderBy(flat => flat.Addres.City).ToList();

            foreach (var flat in sortedItem)
            {
                infoTableAboutFlat.Rows.Add(flat.Addres.Country, flat.Addres.City, flat.Addres.Street,
                        flat.Addres.District, flat.Addres.House, flat.Addres.FlatNumber,
                        flat.BuildDate, flat.RoomsCount, flat.SquareFootage, flat.Kitchen,
                        flat.BathRoom, flat.Toilet, flat.Basement, flat.Balcony, flat.Price);
            }

            XmlSerializeWrapper.Serialize<Flat>(sortedItem, filePathSortByCity);
            LastEvent = "Сортировка";
        }

        private void aboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("version 1.0");
            LastEvent = "О приложении";
        }

        private void objectsCount_Value()
        {
            Flat[] arrayFlats = XmlSerializeWrapper.Deserialize<Flat>(filePath);
            objectsValue.Text = Convert.ToString(arrayFlats.Length);
        }
        private void LastEventLabel()
        {
            last.Text = LastEvent;
        }

        private void TimeLabel()
        {
            date.Text = DateTime.Now.ToLongDateString();

        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            if (hideButton.Text == "Скрыть")
            {
                hideButton.Text = "Показать";
                searchStripButton.Visible = false;
                sortStripDropDownButton.Visible = false;
                backwardButton.Visible = false;
                forewardButton.Visible = false;
            }
            else
            {
                hideButton.Text = "Скрыть";
                searchStripButton.Visible = true;
                sortStripDropDownButton.Visible = true;
                backwardButton.Visible = true;
                forewardButton.Visible = true;
            }
            LastEvent = "Скрытие";
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            State state = new State("cityBox", cityBox.Text);
            StateControl.undoStack.Push(state);
        }

        private void districtBox_TextChanged(object sender, EventArgs e)
        {
            State state = new State("districtBox", districtBox.Text);
            StateControl.undoStack.Push(state);
        }

        private void streetBox_TextChanged(object sender, EventArgs e)
        {
            State state = new State("streetBox", streetBox.Text);
            StateControl.undoStack.Push(state);
        }

        private void houseNumber_ValueChanged(object sender, EventArgs e)
        {
            State state = new State("houseNumber", houseNumber.Text);
            StateControl.undoStack.Push(state);
        }

        private void UndoAction(object sender, EventArgs e)
        {
            if (StateControl.undoStack.Count > 1)
            {
                State temp1 = StateControl.undoStack.Pop();
                StateControl.redoStack.Push(temp1);
                temp1 = StateControl.undoStack.Peek();
                if (temp1.Location == "cityBox")
                {
                    if (cityBox.TextLength == 1)
                    {
                        cityBox.Text = " ";
                    }
                    else
                    {
                        cityBox.Text = temp1.Value;
                    }
                }
                else if (temp1.Location == "districtBox")
                {
                    if (districtBox.TextLength == 1)
                    {
                        districtBox.Text = " ";
                    }
                    else
                    {
                        districtBox.Text = temp1.Value;
                    }
                }
                else if (temp1.Location == "streetBox")
                {
                    if (streetBox.TextLength == 1)
                    {
                        streetBox.Text = " ";
                    }
                    else
                    {
                        streetBox.Text = temp1.Value;
                    }
                }
                else if (temp1.Location == "houseNumber")
                {
                        houseNumber.Value = Convert.ToDecimal(temp1.Value);
                }
            }
            LastEvent = "Назад";
        }

        private void RedoAction(object sender, EventArgs e)
        {
            if (StateControl.redoStack.Count > 0)
            {
                State temp1 = StateControl.redoStack.Pop();
                if (temp1.Location == "cityBox")
                {
                    cityBox.Text = temp1.Value;
                }
                else if (temp1.Location == "districtBox")
                {
                    districtBox.Text = temp1.Value;
                }
                else if (temp1.Location == "streerBox")
                {
                    streetBox.Text = temp1.Value;
                }
                else if (temp1.Location == "houseNumber")
                {
                    houseNumber.Value = Convert.ToDecimal(temp1.Value);
                }
            }
            LastEvent = "Вперёд";

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            LastEvent = "Очистка";
            infoTableAboutFlat.Rows.Clear();
            squareFootageBox.Text = "0";
            buildDate.Value = DateTime.Now;
            kitchenCheckBox.Checked = false;
            bathCheckBox.Checked = false;
            toiletCheckBox.Checked = false;
            basementCheckBox.Checked = false;
            balconyCheckBox.Checked = false;
            countryBox.Text = "";
            cityBox.Text = "";
            districtBox.Text = "";
            streetBox.Text = "";
            houseNumber.Value = 1;
            flatNumber.Value = 1;
            indexBox.Text = "";
            PriceBox.Text = "";
            StateControl.redoStack.Clear();
            StateControl.undoStack.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchStripButton_Click(sender, e);
        }

        private void sortByCityButton_Click(object sender, EventArgs e)
        {
            SortByCity_Click(sender, e);
        }

        private void sortBySquareButton_Click(object sender, EventArgs e)
        {
            SortBySquare_Click(sender, e);
        }

        private void sortByRoomsCountButton_Click(object sender, EventArgs e)
        {
            SortByRoomsCount_Click(sender, e);
        }
    }
}
