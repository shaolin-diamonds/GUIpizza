namespace GUIpizza
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.GrpBoxCrust = new System.Windows.Forms.GroupBox();
            this.RadStuffedCrust = new System.Windows.Forms.RadioButton();
            this.RadDeepDish = new System.Windows.Forms.RadioButton();
            this.RadTraditional = new System.Windows.Forms.RadioButton();
            this.RadThinCrust = new System.Windows.Forms.RadioButton();
            this.GrpBoxToppings = new System.Windows.Forms.GroupBox();
            this.ChkMushrooms = new System.Windows.Forms.CheckBox();
            this.ChkBlackOlives = new System.Windows.Forms.CheckBox();
            this.ChkSausage = new System.Windows.Forms.CheckBox();
            this.ChkPepperoni = new System.Windows.Forms.CheckBox();
            this.ChkExtraCheese = new System.Windows.Forms.CheckBox();
            this.GrpBoxDining = new System.Windows.Forms.GroupBox();
            this.RadDelivery = new System.Windows.Forms.RadioButton();
            this.RadTakeOut = new System.Windows.Forms.RadioButton();
            this.RadDineIn = new System.Windows.Forms.RadioButton();
            this.TxtOrder = new System.Windows.Forms.TextBox();
            this.MTxtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.MnuMain = new System.Windows.Forms.MenuStrip();
            this.MnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.PicBoxPizza = new System.Windows.Forms.PictureBox();
            this.PicBoxSign = new System.Windows.Forms.PictureBox();
            this.TmrBlink1 = new System.Windows.Forms.Timer(this.components);
            this.TmrBlink2 = new System.Windows.Forms.Timer(this.components);
            this.TmrBlinker = new System.Windows.Forms.Timer(this.components);
            this.ChkJalapenos = new System.Windows.Forms.CheckBox();
            this.ChkPineapple = new System.Windows.Forms.CheckBox();
            this.ChkBacon = new System.Windows.Forms.CheckBox();
            this.GrpBoxDrinks = new System.Windows.Forms.GroupBox();
            this.ChkMountainDew = new System.Windows.Forms.CheckBox();
            this.ChkSierraMist = new System.Windows.Forms.CheckBox();
            this.ChkDietPepsi = new System.Windows.Forms.CheckBox();
            this.ChkPepsi = new System.Windows.Forms.CheckBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.GrpBoxCrust.SuspendLayout();
            this.GrpBoxToppings.SuspendLayout();
            this.GrpBoxDining.SuspendLayout();
            this.MnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSign)).BeginInit();
            this.GrpBoxDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBoxCrust
            // 
            this.GrpBoxCrust.Controls.Add(this.RadStuffedCrust);
            this.GrpBoxCrust.Controls.Add(this.RadDeepDish);
            this.GrpBoxCrust.Controls.Add(this.RadTraditional);
            this.GrpBoxCrust.Controls.Add(this.RadThinCrust);
            this.GrpBoxCrust.Location = new System.Drawing.Point(13, 51);
            this.GrpBoxCrust.Name = "GrpBoxCrust";
            this.GrpBoxCrust.Size = new System.Drawing.Size(147, 209);
            this.GrpBoxCrust.TabIndex = 0;
            this.GrpBoxCrust.TabStop = false;
            this.GrpBoxCrust.Text = "Crust";
            // 
            // RadStuffedCrust
            // 
            this.RadStuffedCrust.AutoSize = true;
            this.RadStuffedCrust.Location = new System.Drawing.Point(7, 89);
            this.RadStuffedCrust.Name = "RadStuffedCrust";
            this.RadStuffedCrust.Size = new System.Drawing.Size(128, 17);
            this.RadStuffedCrust.TabIndex = 3;
            this.RadStuffedCrust.Text = "Stuffed Crust   $17.00";
            this.RadStuffedCrust.UseVisualStyleBackColor = true;
            this.RadStuffedCrust.CheckedChanged += new System.EventHandler(this.RadStuffedCrust_CheckedChanged);
            // 
            // RadDeepDish
            // 
            this.RadDeepDish.AutoSize = true;
            this.RadDeepDish.Location = new System.Drawing.Point(6, 66);
            this.RadDeepDish.Name = "RadDeepDish";
            this.RadDeepDish.Size = new System.Drawing.Size(117, 17);
            this.RadDeepDish.TabIndex = 2;
            this.RadDeepDish.Text = "Deep Dish   $16.00";
            this.RadDeepDish.UseVisualStyleBackColor = true;
            // 
            // RadTraditional
            // 
            this.RadTraditional.AutoSize = true;
            this.RadTraditional.Checked = true;
            this.RadTraditional.Location = new System.Drawing.Point(7, 43);
            this.RadTraditional.Name = "RadTraditional";
            this.RadTraditional.Size = new System.Drawing.Size(116, 17);
            this.RadTraditional.TabIndex = 1;
            this.RadTraditional.TabStop = true;
            this.RadTraditional.Text = "Traditional   $15.00";
            this.RadTraditional.UseVisualStyleBackColor = true;
            // 
            // RadThinCrust
            // 
            this.RadThinCrust.AutoSize = true;
            this.RadThinCrust.Location = new System.Drawing.Point(7, 20);
            this.RadThinCrust.Name = "RadThinCrust";
            this.RadThinCrust.Size = new System.Drawing.Size(115, 17);
            this.RadThinCrust.TabIndex = 0;
            this.RadThinCrust.Text = "Thin Crust   $15.00";
            this.RadThinCrust.UseVisualStyleBackColor = true;
            // 
            // GrpBoxToppings
            // 
            this.GrpBoxToppings.Controls.Add(this.ChkBacon);
            this.GrpBoxToppings.Controls.Add(this.ChkPineapple);
            this.GrpBoxToppings.Controls.Add(this.ChkJalapenos);
            this.GrpBoxToppings.Controls.Add(this.ChkMushrooms);
            this.GrpBoxToppings.Controls.Add(this.ChkBlackOlives);
            this.GrpBoxToppings.Controls.Add(this.ChkSausage);
            this.GrpBoxToppings.Controls.Add(this.ChkPepperoni);
            this.GrpBoxToppings.Controls.Add(this.ChkExtraCheese);
            this.GrpBoxToppings.Location = new System.Drawing.Point(166, 51);
            this.GrpBoxToppings.Name = "GrpBoxToppings";
            this.GrpBoxToppings.Size = new System.Drawing.Size(126, 209);
            this.GrpBoxToppings.TabIndex = 1;
            this.GrpBoxToppings.TabStop = false;
            this.GrpBoxToppings.Text = "Toppings";
            // 
            // ChkMushrooms
            // 
            this.ChkMushrooms.AutoSize = true;
            this.ChkMushrooms.Location = new System.Drawing.Point(7, 112);
            this.ChkMushrooms.Name = "ChkMushrooms";
            this.ChkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.ChkMushrooms.TabIndex = 4;
            this.ChkMushrooms.Text = "Mushrooms";
            this.ChkMushrooms.UseVisualStyleBackColor = true;
            // 
            // ChkBlackOlives
            // 
            this.ChkBlackOlives.AutoSize = true;
            this.ChkBlackOlives.Location = new System.Drawing.Point(7, 89);
            this.ChkBlackOlives.Name = "ChkBlackOlives";
            this.ChkBlackOlives.Size = new System.Drawing.Size(85, 17);
            this.ChkBlackOlives.TabIndex = 3;
            this.ChkBlackOlives.Text = "Black Olives";
            this.ChkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ChkSausage
            // 
            this.ChkSausage.AutoSize = true;
            this.ChkSausage.Location = new System.Drawing.Point(7, 67);
            this.ChkSausage.Name = "ChkSausage";
            this.ChkSausage.Size = new System.Drawing.Size(110, 17);
            this.ChkSausage.TabIndex = 2;
            this.ChkSausage.Text = "Sausage  + $1.25";
            this.ChkSausage.UseVisualStyleBackColor = true;
            // 
            // ChkPepperoni
            // 
            this.ChkPepperoni.AutoSize = true;
            this.ChkPepperoni.Location = new System.Drawing.Point(7, 43);
            this.ChkPepperoni.Name = "ChkPepperoni";
            this.ChkPepperoni.Size = new System.Drawing.Size(116, 17);
            this.ChkPepperoni.TabIndex = 1;
            this.ChkPepperoni.Text = "Pepperoni  + $1.25";
            this.ChkPepperoni.UseVisualStyleBackColor = true;
            // 
            // ChkExtraCheese
            // 
            this.ChkExtraCheese.AutoSize = true;
            this.ChkExtraCheese.Location = new System.Drawing.Point(7, 21);
            this.ChkExtraCheese.Name = "ChkExtraCheese";
            this.ChkExtraCheese.Size = new System.Drawing.Size(89, 17);
            this.ChkExtraCheese.TabIndex = 0;
            this.ChkExtraCheese.Text = "Extra Cheese";
            this.ChkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // GrpBoxDining
            // 
            this.GrpBoxDining.Controls.Add(this.RadDelivery);
            this.GrpBoxDining.Controls.Add(this.RadTakeOut);
            this.GrpBoxDining.Controls.Add(this.RadDineIn);
            this.GrpBoxDining.Location = new System.Drawing.Point(450, 51);
            this.GrpBoxDining.Name = "GrpBoxDining";
            this.GrpBoxDining.Size = new System.Drawing.Size(126, 209);
            this.GrpBoxDining.TabIndex = 2;
            this.GrpBoxDining.TabStop = false;
            this.GrpBoxDining.Text = "Dining";
            // 
            // RadDelivery
            // 
            this.RadDelivery.AutoSize = true;
            this.RadDelivery.Location = new System.Drawing.Point(7, 66);
            this.RadDelivery.Name = "RadDelivery";
            this.RadDelivery.Size = new System.Drawing.Size(108, 17);
            this.RadDelivery.TabIndex = 2;
            this.RadDelivery.Text = "Delivery   + $5.75";
            this.RadDelivery.UseVisualStyleBackColor = true;
            this.RadDelivery.CheckedChanged += new System.EventHandler(this.RadDelivery_CheckedChanged);
            // 
            // RadTakeOut
            // 
            this.RadTakeOut.AutoSize = true;
            this.RadTakeOut.Location = new System.Drawing.Point(7, 43);
            this.RadTakeOut.Name = "RadTakeOut";
            this.RadTakeOut.Size = new System.Drawing.Size(70, 17);
            this.RadTakeOut.TabIndex = 1;
            this.RadTakeOut.Text = "Take Out";
            this.RadTakeOut.UseVisualStyleBackColor = true;
            // 
            // RadDineIn
            // 
            this.RadDineIn.AutoSize = true;
            this.RadDineIn.Checked = true;
            this.RadDineIn.Location = new System.Drawing.Point(7, 20);
            this.RadDineIn.Name = "RadDineIn";
            this.RadDineIn.Size = new System.Drawing.Size(58, 17);
            this.RadDineIn.TabIndex = 0;
            this.RadDineIn.TabStop = true;
            this.RadDineIn.Text = "Dine in";
            this.RadDineIn.UseVisualStyleBackColor = true;
            // 
            // TxtOrder
            // 
            this.TxtOrder.Location = new System.Drawing.Point(13, 292);
            this.TxtOrder.Name = "TxtOrder";
            this.TxtOrder.ReadOnly = true;
            this.TxtOrder.Size = new System.Drawing.Size(649, 20);
            this.TxtOrder.TabIndex = 3;
            // 
            // MTxtBoxPhoneNumber
            // 
            this.MTxtBoxPhoneNumber.Location = new System.Drawing.Point(13, 329);
            this.MTxtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.MTxtBoxPhoneNumber.Name = "MTxtBoxPhoneNumber";
            this.MTxtBoxPhoneNumber.Size = new System.Drawing.Size(81, 20);
            this.MTxtBoxPhoneNumber.TabIndex = 4;
            // 
            // BtnOrder
            // 
            this.BtnOrder.Location = new System.Drawing.Point(13, 356);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(81, 25);
            this.BtnOrder.TabIndex = 5;
            this.BtnOrder.Text = "Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // MnuMain
            // 
            this.MnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFile,
            this.MnuCalculator,
            this.MnuHelp});
            this.MnuMain.Location = new System.Drawing.Point(0, 0);
            this.MnuMain.Name = "MnuMain";
            this.MnuMain.Size = new System.Drawing.Size(674, 24);
            this.MnuMain.TabIndex = 6;
            this.MnuMain.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            this.MnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFileExit});
            this.MnuFile.Name = "MnuFile";
            this.MnuFile.Size = new System.Drawing.Size(37, 20);
            this.MnuFile.Text = "&File";
            // 
            // MnuFileExit
            // 
            this.MnuFileExit.Name = "MnuFileExit";
            this.MnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.MnuFileExit.Size = new System.Drawing.Size(166, 22);
            this.MnuFileExit.Text = "E&xit";
            this.MnuFileExit.Click += new System.EventHandler(this.MnuFileExit_Click);
            // 
            // MnuCalculator
            // 
            this.MnuCalculator.Name = "MnuCalculator";
            this.MnuCalculator.Size = new System.Drawing.Size(73, 20);
            this.MnuCalculator.Text = "&Calculator";
            this.MnuCalculator.Click += new System.EventHandler(this.MnuCalculator_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(44, 20);
            this.MnuHelp.Text = "&Help";
            this.MnuHelp.Click += new System.EventHandler(this.MnuHelp_Click);
            // 
            // PicBoxPizza
            // 
            this.PicBoxPizza.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxPizza.Image")));
            this.PicBoxPizza.Location = new System.Drawing.Point(221, 329);
            this.PicBoxPizza.Name = "PicBoxPizza";
            this.PicBoxPizza.Size = new System.Drawing.Size(50, 50);
            this.PicBoxPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxPizza.TabIndex = 7;
            this.PicBoxPizza.TabStop = false;
            // 
            // PicBoxSign
            // 
            this.PicBoxSign.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxSign.Image")));
            this.PicBoxSign.Location = new System.Drawing.Point(289, 329);
            this.PicBoxSign.Name = "PicBoxSign";
            this.PicBoxSign.Size = new System.Drawing.Size(71, 49);
            this.PicBoxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxSign.TabIndex = 8;
            this.PicBoxSign.TabStop = false;
            // 
            // TmrBlink1
            // 
            this.TmrBlink1.Enabled = true;
            this.TmrBlink1.Interval = 3000;
            this.TmrBlink1.Tick += new System.EventHandler(this.TmrBlink1_Tick);
            // 
            // TmrBlink2
            // 
            this.TmrBlink2.Interval = 1000;
            this.TmrBlink2.Tick += new System.EventHandler(this.TmrBlink2_Tick);
            // 
            // TmrBlinker
            // 
            this.TmrBlinker.Enabled = true;
            this.TmrBlinker.Interval = 3000;
            this.TmrBlinker.Tick += new System.EventHandler(this.TmrBlinker_Tick);
            // 
            // ChkJalapenos
            // 
            this.ChkJalapenos.AutoSize = true;
            this.ChkJalapenos.Location = new System.Drawing.Point(7, 135);
            this.ChkJalapenos.Name = "ChkJalapenos";
            this.ChkJalapenos.Size = new System.Drawing.Size(74, 17);
            this.ChkJalapenos.TabIndex = 5;
            this.ChkJalapenos.Text = "Jalapenos";
            this.ChkJalapenos.UseVisualStyleBackColor = true;
            // 
            // ChkPineapple
            // 
            this.ChkPineapple.AutoSize = true;
            this.ChkPineapple.Location = new System.Drawing.Point(7, 158);
            this.ChkPineapple.Name = "ChkPineapple";
            this.ChkPineapple.Size = new System.Drawing.Size(73, 17);
            this.ChkPineapple.TabIndex = 6;
            this.ChkPineapple.Text = "Pineapple";
            this.ChkPineapple.UseVisualStyleBackColor = true;
            // 
            // ChkBacon
            // 
            this.ChkBacon.AutoSize = true;
            this.ChkBacon.Location = new System.Drawing.Point(7, 181);
            this.ChkBacon.Name = "ChkBacon";
            this.ChkBacon.Size = new System.Drawing.Size(93, 17);
            this.ChkBacon.TabIndex = 7;
            this.ChkBacon.Text = "Bacon  + $.50";
            this.ChkBacon.UseVisualStyleBackColor = true;
            // 
            // GrpBoxDrinks
            // 
            this.GrpBoxDrinks.Controls.Add(this.ChkMountainDew);
            this.GrpBoxDrinks.Controls.Add(this.ChkSierraMist);
            this.GrpBoxDrinks.Controls.Add(this.ChkDietPepsi);
            this.GrpBoxDrinks.Controls.Add(this.ChkPepsi);
            this.GrpBoxDrinks.Location = new System.Drawing.Point(298, 51);
            this.GrpBoxDrinks.Name = "GrpBoxDrinks";
            this.GrpBoxDrinks.Size = new System.Drawing.Size(146, 209);
            this.GrpBoxDrinks.TabIndex = 8;
            this.GrpBoxDrinks.TabStop = false;
            this.GrpBoxDrinks.Text = "Drinks";
            // 
            // ChkMountainDew
            // 
            this.ChkMountainDew.AutoSize = true;
            this.ChkMountainDew.Location = new System.Drawing.Point(7, 89);
            this.ChkMountainDew.Name = "ChkMountainDew";
            this.ChkMountainDew.Size = new System.Drawing.Size(128, 17);
            this.ChkMountainDew.TabIndex = 3;
            this.ChkMountainDew.Text = "Mountain Dew   $ .75";
            this.ChkMountainDew.UseVisualStyleBackColor = true;
            // 
            // ChkSierraMist
            // 
            this.ChkSierraMist.AutoSize = true;
            this.ChkSierraMist.Location = new System.Drawing.Point(7, 67);
            this.ChkSierraMist.Name = "ChkSierraMist";
            this.ChkSierraMist.Size = new System.Drawing.Size(108, 17);
            this.ChkSierraMist.TabIndex = 2;
            this.ChkSierraMist.Text = "Sierra Mist   $ .75";
            this.ChkSierraMist.UseVisualStyleBackColor = true;
            // 
            // ChkDietPepsi
            // 
            this.ChkDietPepsi.AutoSize = true;
            this.ChkDietPepsi.Location = new System.Drawing.Point(7, 43);
            this.ChkDietPepsi.Name = "ChkDietPepsi";
            this.ChkDietPepsi.Size = new System.Drawing.Size(107, 17);
            this.ChkDietPepsi.TabIndex = 1;
            this.ChkDietPepsi.Text = "Diet Pepsi   $ .75";
            this.ChkDietPepsi.UseVisualStyleBackColor = true;
            // 
            // ChkPepsi
            // 
            this.ChkPepsi.AutoSize = true;
            this.ChkPepsi.Location = new System.Drawing.Point(7, 21);
            this.ChkPepsi.Name = "ChkPepsi";
            this.ChkPepsi.Size = new System.Drawing.Size(85, 17);
            this.ChkPepsi.TabIndex = 0;
            this.ChkPepsi.Text = "Pepsi   $ .75";
            this.ChkPepsi.UseVisualStyleBackColor = true;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(457, 318);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(70, 20);
            this.TxtTotal.TabIndex = 9;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(417, 325);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(34, 13);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total:";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(100, 356);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(81, 25);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sales Tax:";
            // 
            // TxtSales
            // 
            this.TxtSales.Location = new System.Drawing.Point(457, 344);
            this.TxtSales.Name = "TxtSales";
            this.TxtSales.ReadOnly = true;
            this.TxtSales.Size = new System.Drawing.Size(70, 20);
            this.TxtSales.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subtotal:";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Location = new System.Drawing.Point(457, 370);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.ReadOnly = true;
            this.TxtSubTotal.Size = new System.Drawing.Size(70, 20);
            this.TxtSubTotal.TabIndex = 14;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSales);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.GrpBoxDrinks);
            this.Controls.Add(this.PicBoxSign);
            this.Controls.Add(this.PicBoxPizza);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.MTxtBoxPhoneNumber);
            this.Controls.Add(this.TxtOrder);
            this.Controls.Add(this.GrpBoxDining);
            this.Controls.Add(this.GrpBoxToppings);
            this.Controls.Add(this.GrpBoxCrust);
            this.Controls.Add(this.MnuMain);
            this.MainMenuStrip = this.MnuMain;
            this.Name = "FrmMain";
            this.Text = "Tony\'s Pizza";
            this.GrpBoxCrust.ResumeLayout(false);
            this.GrpBoxCrust.PerformLayout();
            this.GrpBoxToppings.ResumeLayout(false);
            this.GrpBoxToppings.PerformLayout();
            this.GrpBoxDining.ResumeLayout(false);
            this.GrpBoxDining.PerformLayout();
            this.MnuMain.ResumeLayout(false);
            this.MnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxSign)).EndInit();
            this.GrpBoxDrinks.ResumeLayout(false);
            this.GrpBoxDrinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBoxCrust;
        private System.Windows.Forms.RadioButton RadStuffedCrust;
        private System.Windows.Forms.RadioButton RadDeepDish;
        private System.Windows.Forms.RadioButton RadTraditional;
        private System.Windows.Forms.RadioButton RadThinCrust;
        private System.Windows.Forms.GroupBox GrpBoxToppings;
        private System.Windows.Forms.CheckBox ChkMushrooms;
        private System.Windows.Forms.CheckBox ChkBlackOlives;
        private System.Windows.Forms.CheckBox ChkSausage;
        private System.Windows.Forms.CheckBox ChkPepperoni;
        private System.Windows.Forms.CheckBox ChkExtraCheese;
        private System.Windows.Forms.GroupBox GrpBoxDining;
        private System.Windows.Forms.RadioButton RadDelivery;
        private System.Windows.Forms.RadioButton RadTakeOut;
        private System.Windows.Forms.RadioButton RadDineIn;
        private System.Windows.Forms.TextBox TxtOrder;
        private System.Windows.Forms.MaskedTextBox MTxtBoxPhoneNumber;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.MenuStrip MnuMain;
        private System.Windows.Forms.ToolStripMenuItem MnuFile;
        private System.Windows.Forms.ToolStripMenuItem MnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem MnuCalculator;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
        private System.Windows.Forms.PictureBox PicBoxPizza;
        private System.Windows.Forms.PictureBox PicBoxSign;
        private System.Windows.Forms.Timer TmrBlink1;
        private System.Windows.Forms.Timer TmrBlink2;
        private System.Windows.Forms.Timer TmrBlinker;
        private System.Windows.Forms.CheckBox ChkBacon;
        private System.Windows.Forms.CheckBox ChkPineapple;
        private System.Windows.Forms.CheckBox ChkJalapenos;
        private System.Windows.Forms.GroupBox GrpBoxDrinks;
        private System.Windows.Forms.CheckBox ChkMountainDew;
        private System.Windows.Forms.CheckBox ChkSierraMist;
        private System.Windows.Forms.CheckBox ChkDietPepsi;
        private System.Windows.Forms.CheckBox ChkPepsi;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSubTotal;
    }
}

