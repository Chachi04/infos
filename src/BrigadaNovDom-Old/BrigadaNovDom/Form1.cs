using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BrigadaNovDom
{

    public partial class Form1 : Form
    {
        private Dictionary<int, Material> materials;
        private Dictionary<int, Paint> paints;
        private Dictionary<int, Door> doors;
        Room room;

        public Form1()
        {
            InitializeComponent();
            materials = new Dictionary<int, Material>();
            paints = new Dictionary<int, Paint>();
            doors = new Dictionary<int, Door>();

            // Materials
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
                Image = Properties.Resources.floor_freedom, // paint
                Price = 33.99,
            };
            materials[6] = new Material
            {
                Name = "Casa Oak",
                Image = Properties.Resources.floor_casa_oak,
                Price = 27.99
            };

            // Paints
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

            // Door
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

            room = new Room();
        }

        /// Floor Methods
        private void FloorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.Floor.Material = materials[FloorType.SelectedIndex];
            FloorImage.BackgroundImage = room.Floor.Material.Image;
            FloorVisualisation.BackgroundImage = room.Floor.Material.Image;
        }
        private void FloorWidth_TextChanged(object sender, EventArgs e)
        {
            room.Floor.Width = ParseOrDefault(FloorWidth.Text);
            room.Walls[0].Width = ParseOrDefault(FloorWidth.Text);
            room.Walls[2].Width = ParseOrDefault(FloorWidth.Text);
        }
        private void FloorLength_TextChanged(object sender, EventArgs e)
        {
            room.Floor.Length = ParseOrDefault(FloorLength.Text);
            room.Walls[1].Width = ParseOrDefault(FloorLength.Text);
            room.Walls[3].Width = ParseOrDefault(FloorLength.Text);
        }
        /// Wall Methods
        private void PaintColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.Walls[0].Paint = paints[PaintColor.SelectedIndex];
            room.Walls[1].Paint = paints[PaintColor.SelectedIndex];
            room.Walls[2].Paint = paints[PaintColor.SelectedIndex];
            room.Walls[3].Paint = paints[PaintColor.SelectedIndex];
            PaintImage.BackgroundImage = room.Walls[0].Paint.Image;
            WallBackVisualisation.BackgroundImage = room.Walls[0].Paint.Image;
            WallLeftVisualisation.BackgroundImage = room.Walls[1].Paint.Image;
        }

        private void WallHeight_TextChanged(object sender, EventArgs e)
        {
            room.Walls[0].Height = ParseOrDefault(WallHeight.Text);
            room.Walls[1].Height = ParseOrDefault(WallHeight.Text);
            room.Walls[2].Height = ParseOrDefault(WallHeight.Text);
            room.Walls[3].Height = ParseOrDefault(WallHeight.Text);
        }

        private void DoorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            room.Door = doors[DoorType.SelectedIndex];
            DoorImage.BackgroundImage = room.Door.Image;
            DoorVisualisation.BackgroundImage = room.Door.Image;
        }
        static int ParseOrDefault(string text)
        {
            int tmp;
            int.TryParse(text, out tmp);
            return tmp;
        }

        private void Roller_CheckedChanged(object sender, EventArgs e)
        {
            RollerImage.Visible = Roller.Checked;
        }

        private void Brush_CheckedChanged(object sender, EventArgs e)
        {
            BrushImage.Visible = Brush.Checked;
        }

        private void AngleGrinder_CheckedChanged(object sender, EventArgs e)
        {
            AngleGrinderImage.Visible = AngleGrinder.Checked;
        }

        private void Ladder_CheckedChanged(object sender, EventArgs e)
        {
            LadderImage.Visible = Ladder.Checked;
        }

        private static string floor;
        private static string walls;
        private static string door;
        private static string tools;
        void TotalListUpdate()
        {
            TotalList.Text =
                $"Общо\n" +
                $"--------------\n" +
                $"Под:\n" +
                $"      Размери: {room.Floor.Length} X {room.Floor.Width}\n" +
                $"      Материал: {room.Floor.Material.Name} - {room.Floor.Material.Price}\n" +
                $"      Цена: {room.Floor.Price}\n" +
                $"------------------------------------------\n" +
                $"Стени:\n" +
                $"      Размери: {room.Walls[0].Width} X {room.Walls[0].Height} &\n" +
                $"               {room.Walls[1].Width} X {room.Walls[1].Height}\n" +
                $"      Боя: {room.Walls[0].Paint.Name} - {room.Walls[0].Paint.Price}\n" +
                $"      Цена: {room.Walls.Sum(x => x.Price)}\n" +
                $"------------------------------------------\n" +
                $"Врата:\n" +
                $"      Име: {room.Door.Name}\n" +
                $"      Цена: {room.Door.Price}\n" +
                $"------------------------------------------\n" +
                $"Инструменти:\n" +
                (Roller.Checked ? $"      - Валяк - " : "");


            // TotalList.Items.Clear();
            // TotalList.Items.Add("Общо");
            // TotalList.Items.Add("---------------------");
            // TotalList.Items.Add("Под:");
            // TotalList.Items.Add(floor);
            // TotalList.Items.Add("Стена 1");
            // TotalList.Items.Add(floor);

        }
    }
}