using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistrationForm
{
    public partial class ProductSell : Form
    {
        public ProductSell()
        {
            InitializeComponent();
        }


        private void LivlycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LivlycheckBox.Checked == true)
            {
                LivlytextBox.Enabled = true;
            }
            if (LivlycheckBox.Checked == false)
            {
                LivlytextBox.Enabled = false;
                LivlytextBox.Text = "0";
            }
        }

        


        private void BodyLotioncheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //Declare unit Price to different product
        double Mushieup = 30, Creamup = 240, Kokosoup = 40, SOSBalmup = 90, BathSpongeup = 75, BabyLotionup = 50;
        double SkipHopup = 40, FRIGGup = 350, Livlyup = 280, Easgrowup = 70, Fabelabup = 800, Piupiuchickup = 250;


        private void PRINTbutton_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MushieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MushiecheckBox_CheckedChanged_(object sender, EventArgs e)
        {
            if (MushiecheckBox.Checked == true)
            {
                MushieTextBox.Enabled = true;
            }
            if (MushiecheckBox.Checked == false)
            {
                MushieTextBox.Enabled = false;
                MushieTextBox.Text = "0";
            }
        }

        private void CreamCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CreamCheckBox.Checked == true)
            {
                CreamTextBox.Enabled = true;
            }
            if (CreamCheckBox.Checked == false)
            {
                CreamTextBox.Enabled = false;
                CreamTextBox.Text = "0";
            }
        }

        private void KokosocheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (KokosocheckBox.Checked == true)
            {
                KokosotextBox.Enabled = true;
            }
            if (KokosocheckBox.Checked == false)
            {
                KokosotextBox.Enabled = false;
                KokosotextBox.Text = "0";
            }
        }

        private void SOSBalmcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SOSBalmcheckBox.Checked == true)
            {
                SOSBalmtextBox.Enabled = true;
            }
            if (SOSBalmcheckBox.Checked == false)
            {
                SOSBalmtextBox.Enabled = false;
                SOSBalmtextBox.Text = "0";
            }
        }

        private void BathSpongecheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BathSpongecheckBox.Checked == true)
            {
                BathSpongetextBox.Enabled = true;
            }
            if (BathSpongecheckBox.Checked == false)
            {
                BathSpongetextBox.Enabled = false;
                BathSpongetextBox.Text = "0";
            }
        }

        private void BodyLotioncheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BodyLotioncheckBox.Checked == true)
            {
                BodyLotiontextBox.Enabled = true;
            }
            if (BodyLotioncheckBox.Checked == false)
            {
                BodyLotiontextBox.Enabled = false;
                BodyLotiontextBox.Text = "0";
            }
        }

        private void SkipHopcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (SkipHopcheckBox.Checked == true)
            {
                SkipHoptextBox.Enabled = true;
            }
            if (SkipHopcheckBox.Checked == false)
            {
                SkipHoptextBox.Enabled = false;
                SkipHoptextBox.Text = "0";
            }
        }

        private void FRIGGcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (FRIGGcheckBox.Checked == true)
            {
                FRIGGtextBox.Enabled = true;
            }
            if (FRIGGcheckBox.Checked == false)
            {
                FRIGGtextBox.Enabled = false;
                FRIGGtextBox.Text = "0";
            }
        }

       
        private void EasygrowcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (EasygrowcheckBox.Checked == true)
            {
                EasygrowtextBox.Enabled = true;
            }
            if (EasygrowcheckBox.Checked == false)
            {
                EasygrowtextBox.Enabled = false;
                EasygrowtextBox.Text = "0";
            }
        }

        

        private void PiupiuchickcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (PiupiuchickcheckBox.Checked == true)
            {
                PiupiuchicktextBox.Enabled = true;
            }
            if (PiupiuchickcheckBox.Checked == false)
            {
                PiupiuchicktextBox.Enabled = false;
                PiupiuchicktextBox.Text = "0";
            }
        }


        private void ADDbutton_Click_1(object sender, EventArgs e)
        {
            Mushiecp = Mushieup * Convert.ToDouble(MushieTextBox.Text);
            Creamcp = Creamup * Convert.ToDouble(CreamTextBox.Text);
            Kokosocp = Kokosoup * Convert.ToDouble(KokosotextBox.Text);
            SOSBalmcp = SOSBalmup * Convert.ToDouble(SOSBalmtextBox.Text);
            BathSpongecp = BathSpongeup * Convert.ToDouble(BathSpongetextBox.Text);
            BabyLotioncp = BabyLotionup * Convert.ToDouble(BodyLotiontextBox.Text);
            //
            SkipHopcp = SkipHopup * Convert.ToDouble(SkipHoptextBox.Text);
            FRIGGcp = FRIGGup * Convert.ToDouble(FRIGGtextBox.Text);
            Livlycp = Livlyup * Convert.ToDouble(LivlytextBox.Text);
            Easgrowcp = Easgrowup * Convert.ToDouble(EasygrowtextBox.Text);
            Fabelabcp = Fabelabup * Convert.ToDouble(FabelabtextBox.Text);
            Piupiuchickcp = Piupiuchickup * Convert.ToDouble(PiupiuchicktextBox.Text);

            //Now add products in RichTextBox
            MAINrichTextBox.Clear();
            Subtotal = 0;
            tax = 0;
            grdtotal = 0;
            MAINrichTextBox.AppendText(Environment.NewLine);
            MAINrichTextBox.AppendText("\t\t\t uwygyw\t\t\t" + Datelabel.Text + Environment.NewLine);
            MAINrichTextBox.AppendText("\t\t\t *******************" + Environment.NewLine);
            if (MushiecheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tMushie:\t" + Mushiecp + "Rs" + Environment.NewLine);
                Subtotal += Mushiecp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (CreamCheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tCream:\t" + Creamcp + "Rs" + Environment.NewLine);
                Subtotal += Creamcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (KokosocheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tKokoso:\t" + Kokosocp + "Rs" + Environment.NewLine);
                Subtotal += Kokosocp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (SOSBalmcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tSOS Balm:\t" + SOSBalmcp + "Rs" + Environment.NewLine);
                Subtotal += SOSBalmcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (BathSpongecheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tBath Spong:\t" + BathSpongecp + "Rs" + Environment.NewLine);
                Subtotal += BathSpongecp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (BodyLotioncheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tBaby Lotion:\t" + BabyLotioncp + "Rs" + Environment.NewLine);
                Subtotal += BabyLotioncp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (SkipHopcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tSkip Hop:\t" + SkipHopcp + "Rs" + Environment.NewLine);
                Subtotal += SkipHopcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (FRIGGcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tFrigg:\t" + FRIGGcp + "Rs" + Environment.NewLine);
                Subtotal += FRIGGcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (LivlycheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tLivly:\t" + Livlycp + "Rs" + Environment.NewLine);
                Subtotal += Livlycp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (EasygrowcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tEasgrow:\t" + Easgrowcp + "Rs" + Environment.NewLine);
                Subtotal += Easgrowcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (FabelabcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tFabe Lab:\t" + Fabelabcp + "Rs" + Environment.NewLine);
                Subtotal += Fabelabcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (PiupiuchickcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tPiupiu Chick:\t" + Piupiuchickcp + "Rs" + Environment.NewLine);
                Subtotal += Piupiuchickcp;
                RSlabel1.Text = " " + Subtotal;
            }

            tax = Subtotal * 0.15;//15% tax
            grdtotal = Subtotal + tax;
            RSlabel2.Text = "Rs " + tax;
            RSlabel3.Text = "Rs " + grdtotal;
        }

        private void RESETbutton_Click_1(object sender, EventArgs e)
        {
            MushiecheckBox.Checked = false;
            CreamCheckBox.Checked = false;
            KokosocheckBox.Checked = false;
            SOSBalmcheckBox.Checked = false;
            BathSpongecheckBox.Checked = false;
            BodyLotioncheckBox.Checked = false;
            SkipHopcheckBox.Checked = false;
            FRIGGcheckBox.Checked = false;
            LivlycheckBox.Checked = false;
            EasygrowcheckBox.Checked = false;
            FabelabcheckBox.Checked = false;
            PiupiuchickcheckBox.Checked = false;
        }

        private void PRINTbutton_Click_1(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        private void Datelabel_Click(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void ProductSell_Load(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void MushieTextBox_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void CreamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KokosotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KokosopictureBox_Click(object sender, EventArgs e)
        {

        }

        private void FRIGGtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MushiecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MushiecheckBox.Checked == true)
            {
                MushieTextBox.Enabled = true;
            }
            if (MushiecheckBox.Checked == false)
            {
                MushieTextBox.Enabled = false;
                MushieTextBox.Text = "0";
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void CreamCheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (CreamCheckBox.Checked == true)
            {
                CreamTextBox.Enabled = true;
            }
            if (CreamCheckBox.Checked == false)
            {
                CreamTextBox.Enabled = false;
                CreamTextBox.Text = "0";
            }

        }

        private void KokosocheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (KokosocheckBox.Checked == true)
            {
                KokosotextBox.Enabled = true;
            }
            if (KokosocheckBox.Checked == false)
            {
                KokosotextBox.Enabled = false;
                KokosotextBox.Text = "0";
            }
        }

        private void SOSBalmcheckBox_CheckedChanged_2(object sender, EventArgs e)
        {

            if (SOSBalmcheckBox.Checked == true)
            {
                SOSBalmtextBox.Enabled = true;
            }
            if (SOSBalmcheckBox.Checked == false)
            {
                SOSBalmtextBox.Enabled = false;
                SOSBalmtextBox.Text = "0";
            }
        }

        private void BathSpongecheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (BathSpongecheckBox.Checked == true)
            {
                BathSpongetextBox.Enabled = true;
            }
            if (BathSpongecheckBox.Checked == false)
            {
                BathSpongetextBox.Enabled = false;
                BathSpongetextBox.Text = "0";
            }
        }

        private void BodyLotioncheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (BodyLotioncheckBox.Checked == true)
            {
                BodyLotiontextBox.Enabled = true;
            }
            if (BodyLotioncheckBox.Checked == false)
            {
                BodyLotiontextBox.Enabled = false;
                BodyLotiontextBox.Text = "0";
            }
        }

        private void SkipHopcheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (SkipHopcheckBox.Checked == true)
            {
                SkipHoptextBox.Enabled = true;
            }
            if (SkipHopcheckBox.Checked == false)
            {
                SkipHoptextBox.Enabled = false;
                SkipHoptextBox.Text = "0";
            }

        }

        private void FRIGGcheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (FRIGGcheckBox.Checked == true)
            {
                FRIGGtextBox.Enabled = true;
            }
            if (FRIGGcheckBox.Checked == false)
            {
                FRIGGtextBox.Enabled = false;
                FRIGGtextBox.Text = "0";
            }
        }

        private void LivlycheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (LivlycheckBox.Checked == true)
            {
                LivlytextBox.Enabled = true;
            }
            if (LivlycheckBox.Checked == false)
            {
                LivlytextBox.Enabled = false;
                LivlytextBox.Text = "0";
            }
        }

        private void PiupiuchickcheckBox_CheckedChanged_2(object sender, EventArgs e)
        {

            if (PiupiuchickcheckBox.Checked == true)
            {
                PiupiuchicktextBox.Enabled = true;
            }
            if (PiupiuchickcheckBox.Checked == false)
            {
                PiupiuchicktextBox.Enabled = false;
                PiupiuchicktextBox.Text = "0";
            }
        }

        private void EasygrowcheckBox_CheckedChanged_2(object sender, EventArgs e)
        {
            if (EasygrowcheckBox.Checked == true)
            {
                EasygrowtextBox.Enabled = true;
            }
            if (EasygrowcheckBox.Checked == false)
            {
                EasygrowtextBox.Enabled = false;
                EasygrowtextBox.Text = "0";
            }
        }

        private void FabelabcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FabelabcheckBox.Checked == true)
            {
                FabelabtextBox.Enabled = true;
            }
            if (FabelabcheckBox.Checked == false)
            {
                FabelabtextBox.Enabled = false;
                FabelabtextBox.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PaymentForm pf = new PaymentForm();
            this.Hide();
            pf.Show();
        }

        private void SOSBalmtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Babyshoplabel_Click(object sender, EventArgs e)
        {

        }

        private void MushieLabel_Click(object sender, EventArgs e)
        {

        }

        private void BathSpongelabel_Click(object sender, EventArgs e)
        {

        }

        private void MAINrichTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 f34 = new Form1();
            this.Hide();
            f34.Show();
        }

        private void RESETbutton_Click_2(object sender, EventArgs e)
        {
            MushiecheckBox.Checked = false;
            CreamCheckBox.Checked = false;
            KokosocheckBox.Checked = false;
            SOSBalmcheckBox.Checked = false;
            BathSpongecheckBox.Checked = false;
            BodyLotioncheckBox.Checked = false;
            SkipHopcheckBox.Checked = false;
            FRIGGcheckBox.Checked = false;
            LivlycheckBox.Checked = false;
            EasygrowcheckBox.Checked = false;
            FabelabcheckBox.Checked = false;
            PiupiuchickcheckBox.Checked = false;
        }

        private void ADDbutton_Click_2(object sender, EventArgs e)
        {
            Mushiecp = Mushieup * Convert.ToDouble(MushieTextBox.Text);
            Creamcp = Creamup * Convert.ToDouble(CreamTextBox.Text);
            Kokosocp = Kokosoup * Convert.ToDouble(KokosotextBox.Text);
            SOSBalmcp = SOSBalmup * Convert.ToDouble(SOSBalmtextBox.Text);
            BathSpongecp = BathSpongeup * Convert.ToDouble(BathSpongetextBox.Text);
            BabyLotioncp = BabyLotionup * Convert.ToDouble(BodyLotiontextBox.Text);
            //
            SkipHopcp = SkipHopup * Convert.ToDouble(SkipHoptextBox.Text);
            FRIGGcp = FRIGGup * Convert.ToDouble(FRIGGtextBox.Text);
            Livlycp = Livlyup * Convert.ToDouble(LivlytextBox.Text);
            Easgrowcp = Easgrowup * Convert.ToDouble(EasygrowtextBox.Text);
            Fabelabcp = Fabelabup * Convert.ToDouble(FabelabtextBox.Text);
            Piupiuchickcp = Piupiuchickup * Convert.ToDouble(PiupiuchicktextBox.Text);

            //Now add products in RichTextBox
            MAINrichTextBox.Clear();
            Subtotal = 0;
            tax = 0;
            grdtotal = 0;
            MAINrichTextBox.AppendText(Environment.NewLine);
            MAINrichTextBox.AppendText("\t\t\t Cart\t\t\t" + Datelabel.Text + Environment.NewLine);
            MAINrichTextBox.AppendText("\t\t\t ------------" + Environment.NewLine);
            if (MushiecheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tpotato:\t" + Mushiecp + "Tk" + Environment.NewLine);
                Subtotal += Mushiecp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (CreamCheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tApples:\t" + Creamcp + "Tk" + Environment.NewLine);
                Subtotal += Creamcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (KokosocheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tBread:\t" + Kokosocp + "Tk" + Environment.NewLine);
                Subtotal += Kokosocp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (SOSBalmcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tMilk:\t" + SOSBalmcp + "Tk" + Environment.NewLine);
                Subtotal += SOSBalmcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (BathSpongecheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tRice:\t" + BathSpongecp + "Tk" + Environment.NewLine);
                Subtotal += BathSpongecp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (BodyLotioncheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tTomatoes:\t" + BabyLotioncp + "Tk" + Environment.NewLine);
                Subtotal += BabyLotioncp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (SkipHopcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tBanana:\t" + SkipHopcp + "Tk" + Environment.NewLine);
                Subtotal += SkipHopcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (FRIGGcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tCheese:\t" + FRIGGcp + "Tk" + Environment.NewLine);
                Subtotal += FRIGGcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (LivlycheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tYogurt:\t" + Livlycp + "Tk" + Environment.NewLine);
                Subtotal += Livlycp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (EasygrowcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tOnions:\t" + Easgrowcp + "Tk" + Environment.NewLine);
                Subtotal += Easgrowcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (FabelabcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\tBeef:\t" + Fabelabcp + "Tk" + Environment.NewLine);
                Subtotal += Fabelabcp;
                RSlabel1.Text = " " + Subtotal;
            }
            if (PiupiuchickcheckBox.Checked == true)
            {
                MAINrichTextBox.AppendText("\t Chicken:\t" + Piupiuchickcp + "Tk" + Environment.NewLine);
                Subtotal += Piupiuchickcp;
                RSlabel1.Text = " " + Subtotal;
            }

            tax = Subtotal * 0.15;//15% tax
            grdtotal = Subtotal + tax;
            RSlabel2.Text = "Tk " + tax;
            // RSlabel3.Text = "Rs " + grdtotal;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(MAINrichTextBox.Text + "Subtotal " + SubTotallabel.Text + "Tax: " + Taxlabel.Text + "Grand Total" + Totallabel.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void BabyShop_Load(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelabel.Text = DateTime.Now.ToLongTimeString();
        }

        //Declare variable to hold total price
        double Mushiecp, Creamcp, Kokosocp, SOSBalmcp, BathSpongecp, BabyLotioncp, SkipHopcp, FRIGGcp, Livlycp, Easgrowcp, Fabelabcp, Piupiuchickcp;
        double Subtotal = 0, tax, grdtotal;



        /*private void ADDbutton_Click(object sender, EventArgs e)
        {
           
        }
*/
       /* private void RESETbutton_Click(object sender, EventArgs e)
        {
            

        }*/
        private void MAINrichTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void CloseLab_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
