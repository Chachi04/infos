using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace BrigadaNovDom
{
    public partial class Form1 : Form
    {
        // Declearing Dictionaries for containing all available materials, paints, doors
        private Dictionary<int, Material> materials;
        private Dictionary<int, Paint> paints;
        private Dictionary<int, Door> doors;
        private Room room;

        public Form1()
        {
            InitializeComponent();

            // Initialising Dictionaries for the available floor materials, wall paints, doors
            materials = new Dictionary<int, Material>();
            paints = new Dictionary<int, Paint>();
            doors = new Dictionary<int, Door>();

            // Initialising the room
            room = new Room();
            
            // Defining available floor materials
            materials[0] = new Material
            {
                Name = "African Oak Exquisit Trend",
                Image = Properties.Resources.floor_exquisit_trend,
                Price = 56.49
            };
            materials[1] = new Material
            {
                Name = "African Oak Tundra",
                Image = Properties.Resources.floor_tundra,
                Price = 56.49
            };
            materials[2] = new Material
            {
                Name = "Marbau",
                Image = Properties.Resources.Merbau_525_190,
                Price = 52.8
            };
            materials[3] = new Material
            {
                Name = "Buche degaumpft Universal Interieur",
                Image = Properties.Resources.floor_buche,
                Price = 44.2
            };
            materials[4] = new Material
            {
                Name = "ASH Trend",
                Image = Properties.Resources.floor_ash_trend,
                Price = 47.99
            };
            materials[5] = new Material
            {
                Name = "Freedom",
                Image = Properties.Resources.floor_freedom,
                Price = 33.99,
            };
            materials[6] = new Material
            {
                Name = "Casa Oak",
                Image = Properties.Resources.floor_casa_oak,
                Price = 27.99
            };

            // Defining available wall paints
            paints[0] = new Paint
            {
                Name = "Бадем",
                Image = Properties.Resources.wall_badem,
                Price = 22.59
            };
            paints[1] = new Paint
            {
                Name = "Бамбук",
                Image = Properties.Resources.wall_bambuk,
                Price = 22.59
            };
            paints[2] = new Paint
            {
                Name = "Златна ръж",
                Image = Properties.Resources.wall_zlatna_ruj,
                Price = 22.59
            };
            paints[3] = new Paint
            {
                Name = "Зряла Смокиня",
                Image = Properties.Resources.wall_smokinq,
                Price = 22.59
            };
            paints[4] = new Paint
            {
                Name = "Крем брюле",
                Image = Properties.Resources.wall_crem_brule,
                Price = 22.59
            };
            paints[5] = new Paint
            {
                Name = "Папая",
                Image = Properties.Resources.wall_papaq,
                Price = 22.59
            };
            paints[6] = new Paint
            {
                Name = "Праскова",
                Image = Properties.Resources.wall_praskova,
                Price = 22.59
            };
            paints[7] = new Paint
            {
                Name = "Северно сияние",
                Image = Properties.Resources.wall_severno_siqnie,
                Price = 22.59
            };
            paints[8] = new Paint
            {
                Name = "Слънчево утро",
                Image = Properties.Resources.wall_slunchevo_utro,
                Price = 22.59
            };
            paints[9] = new Paint
            {
                Name = "Сребърна лисица",
                Image = Properties.Resources.wall_sreburna_lisica,
                Price = 22.59
            };

            // Defining available doors
            doors[0] = new Door
            {
                Name = "Врата Century Oak",
                Image = Properties.Resources.door_century_oak,
                Price = 110,
            };
            doors[1] = new Door
            {
                Name = "Врата Ceres Wallnut",
                Image = Properties.Resources.door_ceres_wallnut,
                Price = 150,
            };
            doors[2] = new Door
            {
                Name = "Врата Century Wallnut",
                Image = Properties.Resources.door_century_wallnut,
                Price = 120,
            };
            doors[3] = new Door
            {
                Name = "Врата Ceres Oak",
                Image = Properties.Resources.door_ceres_oak,
                Price = 120,
            };
            doors[4] = new Door
            {
                Name = "Врата Malaga",
                Image = Properties.Resources.door_malaga,
                Price = 310,
            };
        }

        #region Floor Methods
        // Selecting the Floor Material
        private void FloorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.Floor.Material = materials[FloorType.SelectedIndex]; // Setting floor material to the selected one from the dictionary
            FloorImage.BackgroundImage = room.Floor.Material.Image; // Setting picturebox for floor material
            FloorVisualisation.BackgroundImage = room.Floor.Material.Image; // Setting 3D floor material
            TotalListUpdate(); // Update the total list
        }
        private void FloorWidth_TextChanged(object sender, EventArgs e)
        {
            room.Floor.Width = ParseOrDefault(FloorWidth.Text); // Setting the width of the floor
            room.Walls[0].Width = ParseOrDefault(FloorWidth.Text); // Setting the width of the walls with the same edge
            room.Walls[2].Width = ParseOrDefault(FloorWidth.Text); // Setting the width of the walls with the same edge
            TotalListUpdate(); // Update the total list
        }
        private void FloorLength_TextChanged(object sender, EventArgs e)
        {
            room.Floor.Length = ParseOrDefault(FloorLength.Text); // Setting the length of the floor
            room.Walls[1].Width = ParseOrDefault(FloorLength.Text); // Setting the length of the walls with the same edge
            room.Walls[3].Width = ParseOrDefault(FloorLength.Text); // Setting the length of the walls with the same edge
            TotalListUpdate(); // Update the total list
        }
        #endregion


        #region Wall Methods
        // Selecting the Wall Paint
        private void PaintColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.Walls[0].Paint = paints[PaintColor.SelectedIndex]; // Setting Wall1's paint 
            room.Walls[1].Paint = paints[PaintColor.SelectedIndex]; // Setting Wall2's paint
            room.Walls[2].Paint = paints[PaintColor.SelectedIndex]; // Setting Wall3's paint
            room.Walls[3].Paint = paints[PaintColor.SelectedIndex]; // Setting Wall4's paint
            PaintImage.BackgroundImage = room.Walls[0].Paint.Image; // Showing the paint image
            WallBackVisualisation.BackgroundImage = room.Walls[0].Paint.Image; // Setting the 3D wall paint 
            WallLeftVisualisation.BackgroundImage = room.Walls[1].Paint.Image; // Setting the 3D wall paint
            TotalListUpdate(); // Update the total list
        }
        private void WallHeight_TextChanged(object sender, EventArgs e)
        {
            room.Walls[0].Height = ParseOrDefault(WallHeight.Text); // Setting Wall1's height
            room.Walls[1].Height = ParseOrDefault(WallHeight.Text); // Setting Wall2's height
            room.Walls[2].Height = ParseOrDefault(WallHeight.Text); // Setting Wall3's height
            room.Walls[3].Height = ParseOrDefault(WallHeight.Text); // Setting Wall4's height
            TotalListUpdate(); // Update the total list
        }
        #endregion

        private void DoorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.Door = doors[DoorType.SelectedIndex]; // Setting room's door to the selected one
            DoorImage.BackgroundImage = room.Door.Image; // Showing the door image
            DoorVisualisation.BackgroundImage = room.Door.Image; // Setting 3D door image
            TotalListUpdate(); // Update the total list
        }

        #region Tools Methods

        private void Roller_CheckedChanged(object sender, EventArgs e)
        {
            RollerImage.Visible = Roller.Checked; // Showing/Hiding Image
            if (Roller.Checked) // Adding/Removing roller from Tools
                room.Tools.Add("roller", 8.49);
            else room.Tools.Remove("roller");
            TotalListUpdate(); // Update the total list
        }

        private void Brush_CheckedChanged(object sender, EventArgs e)
        {
            BrushImage.Visible = Brush.Checked; // Showing/Hiding Image
            if (Brush.Checked) // Adding/Removing brush from Tools
                room.Tools.Add("brush", 5.99);
            else room.Tools.Remove("brush");
            TotalListUpdate(); // Update the total list
        }

        private void AngleGrinder_CheckedChanged(object sender, EventArgs e)
        {
            AngleGrinderImage.Visible = AngleGrinder.Checked; // Showing/Hiding Image
            if (AngleGrinder.Checked) // Adding/Removing angle grinder from Tools
                room.Tools.Add("anglegrinder", 139.99);
            else room.Tools.Remove("anglegrinder");
            TotalListUpdate(); // Update the total list
        }

        private void Ladder_CheckedChanged(object sender, EventArgs e)
        {
            LadderImage.Visible = Ladder.Checked; // Showing/Hiding Image
            if (Ladder.Checked) // Adding/Removing ladder from Tools
                room.Tools.Add("ladder", 59.99);
            else room.Tools.Remove("ladder");
            TotalListUpdate(); // Update the total list
        }
        #endregion

        /// <summary>
        /// Updating the total list
        /// </summary>
        void TotalListUpdate()
        {
            TotalList.Items.Clear(); // clearing the list
            TotalList.Items.Add("ОБЩО"); // list title
            TotalList.Items.Add(new string('-', 150)); // seperator
            TotalList.Items.Add($"Под:"); // section title
            TotalList.Items.Add($"      Размери: {room.Floor.Length} X {room.Floor.Width}"); // dimensions
            TotalList.Items.Add($"      Материал: {room.Floor.Material.Name} - {room.Floor.Material.Price}"); // material
            TotalList.Items.Add($"      Цена: {room.Floor.Price}"); // cost
            TotalList.Items.Add(new string('-', 150)); // seperator
            TotalList.Items.Add($"Стени:\n"); // section title
            TotalList.Items.Add($"      Размери: {room.Walls[0].Width} X {room.Walls[0].Height} " +
                $"& {room.Walls[1].Width} X {room.Walls[1].Height}"); // dimensions
            TotalList.Items.Add($"      Боя: {room.Walls[0].Paint.Name} - {room.Walls[0].Paint.Price}"); // paint color
            TotalList.Items.Add($"      Цена: {room.Walls.Sum(x => x.Price)}"); // cost
            TotalList.Items.Add(new string('-', 150)); // seperator
            TotalList.Items.Add($"Врата:"); // section title
            TotalList.Items.Add($"      Име: {room.Door.Name}"); // door name
            TotalList.Items.Add($"      Цена: {room.Door.Price}"); // cost
            TotalList.Items.Add(new string('-', 150)); // seperator
            TotalList.Items.Add($"Инструменти:\n"); // section title
            if (Roller.Checked) TotalList.Items.Add($"      - Валяк - {room.Tools["roller"]}"); // shows if tool is added
            if (Brush.Checked) TotalList.Items.Add($"      - Четка - {room.Tools["brush"]}"); // shows if tool is added
            if (AngleGrinder.Checked) TotalList.Items.Add($"      - Ъглошлайф - {room.Tools["anglegrinder"]}"); // shows if tool is added
            if (Ladder.Checked) TotalList.Items.Add($"      - Стълба - {room.Tools["ladder"]}\n"); // shows if tool is added
            TotalList.Items.Add(new string('-', 150)); // seperator
            TotalList.Items.Add($"Крайна цена:\n"); // section title
            TotalList.Items.Add($"{room.Price}"); // cost
        }
        /// <summary>
        /// Helper function that safely parses string to int
        /// </summary>
        /// <param name="text">Text to be parsed</param>
        /// <returns>The number in text. If cannot be parsed returns 0</returns>
        static double ParseOrDefault(string text)
        {
            double.TryParse(text, out double tmp);
            return tmp;
        }
    }
}
