
namespace BrigadaNovDom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TotalTab = new System.Windows.Forms.TabPage();
            this.TotalList = new System.Windows.Forms.ListBox();
            this.ViewTab = new System.Windows.Forms.TabPage();
            this.DoorVisualisation = new System.Windows.Forms.PictureBox();
            this.WallBackVisualisation = new System.Windows.Forms.PictureBox();
            this.ToolsTab = new System.Windows.Forms.TabPage();
            this.LadderImage = new System.Windows.Forms.PictureBox();
            this.AngleGrinderImage = new System.Windows.Forms.PictureBox();
            this.BrushImage = new System.Windows.Forms.PictureBox();
            this.RollerImage = new System.Windows.Forms.PictureBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.Ladder = new System.Windows.Forms.CheckBox();
            this.AngleGrinder = new System.Windows.Forms.CheckBox();
            this.Brush = new System.Windows.Forms.CheckBox();
            this.Roller = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DoorTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.DoorType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DoorImage = new System.Windows.Forms.PictureBox();
            this.WallsTab = new System.Windows.Forms.TabPage();
            this.PaintColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WallHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PaintImage = new System.Windows.Forms.PictureBox();
            this.FloorTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.FloorType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FloorImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FloorLength = new System.Windows.Forms.TextBox();
            this.FloorWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.WallLeftVisualisation = new BrigadaNovDom.FlippedParallelogramPictureBox();
            this.FloorVisualisation = new BrigadaNovDom.ParallelogramPictureBox();
            this.TotalTab.SuspendLayout();
            this.ViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorVisualisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallBackVisualisation)).BeginInit();
            this.ToolsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleGrinderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollerImage)).BeginInit();
            this.DoorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorImage)).BeginInit();
            this.WallsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintImage)).BeginInit();
            this.FloorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorImage)).BeginInit();
            this.Tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WallLeftVisualisation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorVisualisation)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalTab
            // 
            this.TotalTab.Controls.Add(this.TotalList);
            this.TotalTab.Location = new System.Drawing.Point(4, 25);
            this.TotalTab.Name = "TotalTab";
            this.TotalTab.Size = new System.Drawing.Size(569, 225);
            this.TotalTab.TabIndex = 4;
            this.TotalTab.Text = "Общо";
            this.TotalTab.UseVisualStyleBackColor = true;
            // 
            // TotalList
            // 
            this.TotalList.FormattingEnabled = true;
            this.TotalList.ItemHeight = 16;
            this.TotalList.Location = new System.Drawing.Point(3, 9);
            this.TotalList.Name = "TotalList";
            this.TotalList.Size = new System.Drawing.Size(563, 212);
            this.TotalList.TabIndex = 0;
            // 
            // ViewTab
            // 
            this.ViewTab.Controls.Add(this.DoorVisualisation);
            this.ViewTab.Controls.Add(this.WallBackVisualisation);
            this.ViewTab.Controls.Add(this.WallLeftVisualisation);
            this.ViewTab.Controls.Add(this.FloorVisualisation);
            this.ViewTab.Location = new System.Drawing.Point(4, 25);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewTab.Size = new System.Drawing.Size(569, 225);
            this.ViewTab.TabIndex = 5;
            this.ViewTab.Text = "Визуализация";
            this.ViewTab.UseVisualStyleBackColor = true;
            // 
            // DoorVisualisation
            // 
            this.DoorVisualisation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoorVisualisation.Location = new System.Drawing.Point(434, 72);
            this.DoorVisualisation.Name = "DoorVisualisation";
            this.DoorVisualisation.Size = new System.Drawing.Size(41, 75);
            this.DoorVisualisation.TabIndex = 3;
            this.DoorVisualisation.TabStop = false;
            // 
            // WallBackVisualisation
            // 
            this.WallBackVisualisation.BackColor = System.Drawing.Color.Transparent;
            this.WallBackVisualisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WallBackVisualisation.Location = new System.Drawing.Point(129, 9);
            this.WallBackVisualisation.Name = "WallBackVisualisation";
            this.WallBackVisualisation.Size = new System.Drawing.Size(437, 138);
            this.WallBackVisualisation.TabIndex = 2;
            this.WallBackVisualisation.TabStop = false;
            // 
            // ToolsTab
            // 
            this.ToolsTab.Controls.Add(this.LadderImage);
            this.ToolsTab.Controls.Add(this.AngleGrinderImage);
            this.ToolsTab.Controls.Add(this.BrushImage);
            this.ToolsTab.Controls.Add(this.RollerImage);
            this.ToolsTab.Controls.Add(this.checkBox5);
            this.ToolsTab.Controls.Add(this.Ladder);
            this.ToolsTab.Controls.Add(this.AngleGrinder);
            this.ToolsTab.Controls.Add(this.Brush);
            this.ToolsTab.Controls.Add(this.Roller);
            this.ToolsTab.Controls.Add(this.label8);
            this.ToolsTab.Location = new System.Drawing.Point(4, 25);
            this.ToolsTab.Name = "ToolsTab";
            this.ToolsTab.Size = new System.Drawing.Size(569, 225);
            this.ToolsTab.TabIndex = 3;
            this.ToolsTab.Text = "Инструменти";
            this.ToolsTab.UseVisualStyleBackColor = true;
            // 
            // LadderImage
            // 
            this.LadderImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LadderImage.Image = global::BrigadaNovDom.Properties.Resources.Ladder;
            this.LadderImage.Location = new System.Drawing.Point(432, 99);
            this.LadderImage.Name = "LadderImage";
            this.LadderImage.Size = new System.Drawing.Size(106, 96);
            this.LadderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LadderImage.TabIndex = 12;
            this.LadderImage.TabStop = false;
            this.LadderImage.Visible = false;
            // 
            // AngleGrinderImage
            // 
            this.AngleGrinderImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AngleGrinderImage.Image = global::BrigadaNovDom.Properties.Resources.tool_angle_grinder;
            this.AngleGrinderImage.Location = new System.Drawing.Point(295, 99);
            this.AngleGrinderImage.Name = "AngleGrinderImage";
            this.AngleGrinderImage.Size = new System.Drawing.Size(106, 96);
            this.AngleGrinderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AngleGrinderImage.TabIndex = 11;
            this.AngleGrinderImage.TabStop = false;
            this.AngleGrinderImage.Visible = false;
            // 
            // BrushImage
            // 
            this.BrushImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrushImage.Image = global::BrigadaNovDom.Properties.Resources.tool_brush;
            this.BrushImage.Location = new System.Drawing.Point(154, 99);
            this.BrushImage.Name = "BrushImage";
            this.BrushImage.Size = new System.Drawing.Size(106, 96);
            this.BrushImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BrushImage.TabIndex = 10;
            this.BrushImage.TabStop = false;
            this.BrushImage.Visible = false;
            // 
            // RollerImage
            // 
            this.RollerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RollerImage.Image = global::BrigadaNovDom.Properties.Resources.tool_roller;
            this.RollerImage.Location = new System.Drawing.Point(22, 99);
            this.RollerImage.Name = "RollerImage";
            this.RollerImage.Size = new System.Drawing.Size(106, 96);
            this.RollerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RollerImage.TabIndex = 9;
            this.RollerImage.TabStop = false;
            this.RollerImage.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(109, 294);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(98, 21);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Ladder
            // 
            this.Ladder.AutoSize = true;
            this.Ladder.Location = new System.Drawing.Point(446, 52);
            this.Ladder.Name = "Ladder";
            this.Ladder.Size = new System.Drawing.Size(79, 21);
            this.Ladder.TabIndex = 7;
            this.Ladder.Text = "Стълба";
            this.Ladder.UseVisualStyleBackColor = true;
            this.Ladder.CheckedChanged += new System.EventHandler(this.Ladder_CheckedChanged);
            // 
            // AngleGrinder
            // 
            this.AngleGrinder.AutoSize = true;
            this.AngleGrinder.Location = new System.Drawing.Point(294, 52);
            this.AngleGrinder.Name = "AngleGrinder";
            this.AngleGrinder.Size = new System.Drawing.Size(108, 21);
            this.AngleGrinder.TabIndex = 6;
            this.AngleGrinder.Text = "Ъглошлайф";
            this.AngleGrinder.UseVisualStyleBackColor = true;
            this.AngleGrinder.CheckedChanged += new System.EventHandler(this.AngleGrinder_CheckedChanged);
            // 
            // Brush
            // 
            this.Brush.AutoSize = true;
            this.Brush.Location = new System.Drawing.Point(172, 52);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(70, 21);
            this.Brush.TabIndex = 5;
            this.Brush.Text = "Четка";
            this.Brush.UseVisualStyleBackColor = true;
            this.Brush.CheckedChanged += new System.EventHandler(this.Brush_CheckedChanged);
            // 
            // Roller
            // 
            this.Roller.AutoSize = true;
            this.Roller.Location = new System.Drawing.Point(40, 52);
            this.Roller.Name = "Roller";
            this.Roller.Size = new System.Drawing.Size(70, 21);
            this.Roller.TabIndex = 4;
            this.Roller.Text = "Валяк";
            this.Roller.UseVisualStyleBackColor = true;
            this.Roller.CheckedChanged += new System.EventHandler(this.Roller_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 36);
            this.label8.TabIndex = 3;
            this.label8.Text = "Инструменти";
            // 
            // DoorTab
            // 
            this.DoorTab.Controls.Add(this.label10);
            this.DoorTab.Controls.Add(this.DoorType);
            this.DoorTab.Controls.Add(this.label7);
            this.DoorTab.Controls.Add(this.DoorImage);
            this.DoorTab.Location = new System.Drawing.Point(4, 25);
            this.DoorTab.Name = "DoorTab";
            this.DoorTab.Size = new System.Drawing.Size(569, 225);
            this.DoorTab.TabIndex = 2;
            this.DoorTab.Text = "Врата";
            this.DoorTab.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(4, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Вид врата";
            // 
            // DoorType
            // 
            this.DoorType.FormattingEnabled = true;
            this.DoorType.Items.AddRange(new object[] {
            "Паркет Африкански дъб - 196 лв.",
            "Паркет Африкански дъб Тундра - 196 лв.",
            "Паркет Мербау - 170 лв.",
            "Паркет Парен бук Универсал - 122 лв.",
            "Паркет Ясен - 158 лв."});
            this.DoorType.Location = new System.Drawing.Point(9, 81);
            this.DoorType.Name = "DoorType";
            this.DoorType.Size = new System.Drawing.Size(275, 24);
            this.DoorType.TabIndex = 11;
            this.DoorType.SelectedIndexChanged += new System.EventHandler(this.DoorType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 36);
            this.label7.TabIndex = 3;
            this.label7.Text = "Врата";
            // 
            // DoorImage
            // 
            this.DoorImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoorImage.Location = new System.Drawing.Point(384, 21);
            this.DoorImage.Name = "DoorImage";
            this.DoorImage.Size = new System.Drawing.Size(120, 189);
            this.DoorImage.TabIndex = 12;
            this.DoorImage.TabStop = false;
            // 
            // WallsTab
            // 
            this.WallsTab.Controls.Add(this.PaintColor);
            this.WallsTab.Controls.Add(this.label5);
            this.WallsTab.Controls.Add(this.label9);
            this.WallsTab.Controls.Add(this.WallHeight);
            this.WallsTab.Controls.Add(this.label6);
            this.WallsTab.Controls.Add(this.PaintImage);
            this.WallsTab.Location = new System.Drawing.Point(4, 25);
            this.WallsTab.Name = "WallsTab";
            this.WallsTab.Padding = new System.Windows.Forms.Padding(3);
            this.WallsTab.Size = new System.Drawing.Size(569, 225);
            this.WallsTab.TabIndex = 1;
            this.WallsTab.Text = "Стени";
            this.WallsTab.UseVisualStyleBackColor = true;
            // 
            // PaintColor
            // 
            this.PaintColor.FormattingEnabled = true;
            this.PaintColor.Items.AddRange(new object[] {
            "Бадем",
            "Бамбук",
            "Златна ръж",
            "Зряла смокиня",
            "Крем брюле",
            "Папая",
            "Праскова",
            "Северно сияние",
            "Слънчево утро",
            "Сребърна лисица"});
            this.PaintColor.Location = new System.Drawing.Point(73, 59);
            this.PaintColor.Name = "PaintColor";
            this.PaintColor.Size = new System.Drawing.Size(221, 24);
            this.PaintColor.TabIndex = 8;
            this.PaintColor.SelectedIndexChanged += new System.EventHandler(this.PaintColor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Боя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Височина: ";
            // 
            // WallHeight
            // 
            this.WallHeight.Location = new System.Drawing.Point(433, 61);
            this.WallHeight.Name = "WallHeight";
            this.WallHeight.Size = new System.Drawing.Size(102, 22);
            this.WallHeight.TabIndex = 13;
            this.WallHeight.TextChanged += new System.EventHandler(this.WallHeight_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "Стени";
            // 
            // PaintImage
            // 
            this.PaintImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaintImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintImage.Location = new System.Drawing.Point(26, 99);
            this.PaintImage.Name = "PaintImage";
            this.PaintImage.Size = new System.Drawing.Size(509, 101);
            this.PaintImage.TabIndex = 10;
            this.PaintImage.TabStop = false;
            // 
            // FloorTab
            // 
            this.FloorTab.Controls.Add(this.label2);
            this.FloorTab.Controls.Add(this.FloorType);
            this.FloorTab.Controls.Add(this.label1);
            this.FloorTab.Controls.Add(this.FloorImage);
            this.FloorTab.Controls.Add(this.label3);
            this.FloorTab.Controls.Add(this.FloorLength);
            this.FloorTab.Controls.Add(this.FloorWidth);
            this.FloorTab.Controls.Add(this.label4);
            this.FloorTab.Location = new System.Drawing.Point(4, 25);
            this.FloorTab.Name = "FloorTab";
            this.FloorTab.Padding = new System.Windows.Forms.Padding(3);
            this.FloorTab.Size = new System.Drawing.Size(569, 225);
            this.FloorTab.TabIndex = 0;
            this.FloorTab.Text = "Под";
            this.FloorTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Под";
            // 
            // FloorType
            // 
            this.FloorType.FormattingEnabled = true;
            this.FloorType.Items.AddRange(new object[] {
            "Паркет Африкански дъб - 56.49 лв.",
            "Паркет Африкански дъб Тундра - 56.49 лв.",
            "Паркет Мербау - 52.80 лв.",
            "Паркет Парен бук Универсал - 44.20 лв.",
            "Паркет Ясен - 47.99 лв.",
            "Ламинат Freedom - 33.99 лв.",
            "Ламинат Каса Дъб - 27.99 лв."});
            this.FloorType.Location = new System.Drawing.Point(133, 57);
            this.FloorType.Name = "FloorType";
            this.FloorType.Size = new System.Drawing.Size(400, 24);
            this.FloorType.TabIndex = 0;
            this.FloorType.SelectedIndexChanged += new System.EventHandler(this.FloorType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид под";
            // 
            // FloorImage
            // 
            this.FloorImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FloorImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FloorImage.Location = new System.Drawing.Point(319, 87);
            this.FloorImage.Name = "FloorImage";
            this.FloorImage.Size = new System.Drawing.Size(214, 95);
            this.FloorImage.TabIndex = 3;
            this.FloorImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ширина: ";
            // 
            // FloorLength
            // 
            this.FloorLength.Location = new System.Drawing.Point(133, 152);
            this.FloorLength.Name = "FloorLength";
            this.FloorLength.Size = new System.Drawing.Size(140, 22);
            this.FloorLength.TabIndex = 7;
            this.FloorLength.TextChanged += new System.EventHandler(this.FloorLength_TextChanged);
            // 
            // FloorWidth
            // 
            this.FloorWidth.Location = new System.Drawing.Point(133, 115);
            this.FloorWidth.Name = "FloorWidth";
            this.FloorWidth.Size = new System.Drawing.Size(140, 22);
            this.FloorWidth.TabIndex = 6;
            this.FloorWidth.TextChanged += new System.EventHandler(this.FloorWidth_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дължина:";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.FloorTab);
            this.Tabs.Controls.Add(this.WallsTab);
            this.Tabs.Controls.Add(this.DoorTab);
            this.Tabs.Controls.Add(this.ToolsTab);
            this.Tabs.Controls.Add(this.TotalTab);
            this.Tabs.Controls.Add(this.ViewTab);
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(577, 254);
            this.Tabs.TabIndex = 12;
            // 
            // WallLeftVisualisation
            // 
            this.WallLeftVisualisation.BackColor = System.Drawing.Color.Transparent;
            this.WallLeftVisualisation.HeightPart = 0.65F;
            this.WallLeftVisualisation.Location = new System.Drawing.Point(19, 8);
            this.WallLeftVisualisation.Name = "WallLeftVisualisation";
            this.WallLeftVisualisation.Size = new System.Drawing.Size(112, 211);
            this.WallLeftVisualisation.TabIndex = 1;
            this.WallLeftVisualisation.TabStop = false;
            this.WallLeftVisualisation.WidthPart = 0F;
            // 
            // FloorVisualisation
            // 
            this.FloorVisualisation.BackColor = System.Drawing.Color.Transparent;
            this.FloorVisualisation.HeightPart = 0.5F;
            this.FloorVisualisation.Location = new System.Drawing.Point(18, 146);
            this.FloorVisualisation.Name = "FloorVisualisation";
            this.FloorVisualisation.Size = new System.Drawing.Size(548, 73);
            this.FloorVisualisation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FloorVisualisation.TabIndex = 0;
            this.FloorVisualisation.TabStop = false;
            this.FloorVisualisation.WidthPart = 0.8F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 274);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Бригада Нов Дом";
            this.TotalTab.ResumeLayout(false);
            this.ViewTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoorVisualisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallBackVisualisation)).EndInit();
            this.ToolsTab.ResumeLayout(false);
            this.ToolsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LadderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AngleGrinderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrushImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollerImage)).EndInit();
            this.DoorTab.ResumeLayout(false);
            this.DoorTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoorImage)).EndInit();
            this.WallsTab.ResumeLayout(false);
            this.WallsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintImage)).EndInit();
            this.FloorTab.ResumeLayout(false);
            this.FloorTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorImage)).EndInit();
            this.Tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WallLeftVisualisation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloorVisualisation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TotalTab;
        private System.Windows.Forms.ListBox TotalList;
        private System.Windows.Forms.TabPage ViewTab;
        private System.Windows.Forms.PictureBox WallBackVisualisation;
        private FlippedParallelogramPictureBox WallLeftVisualisation;
        private ParallelogramPictureBox FloorVisualisation;
        private System.Windows.Forms.TabPage ToolsTab;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox Ladder;
        private System.Windows.Forms.CheckBox AngleGrinder;
        private System.Windows.Forms.CheckBox Brush;
        private System.Windows.Forms.CheckBox Roller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage DoorTab;
        private System.Windows.Forms.ComboBox DoorType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox DoorImage;
        private System.Windows.Forms.TabPage WallsTab;
        private System.Windows.Forms.ComboBox PaintColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WallHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PaintImage;
        private System.Windows.Forms.TabPage FloorTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FloorType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FloorImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FloorLength;
        private System.Windows.Forms.TextBox FloorWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.PictureBox DoorVisualisation;
        private System.Windows.Forms.PictureBox LadderImage;
        private System.Windows.Forms.PictureBox AngleGrinderImage;
        private System.Windows.Forms.PictureBox BrushImage;
        private System.Windows.Forms.PictureBox RollerImage;
        private System.Windows.Forms.Label label10;
    }
}

