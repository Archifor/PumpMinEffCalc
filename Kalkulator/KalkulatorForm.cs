using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class KalkulatorForm : Form
    {

        public KalkulatorForm()
        {
            InitializeComponent();
        }   

        private void KalkulatorForm_Load(object sender, EventArgs e)
        {
            AktualizujWszystko();
            cbJednostkaPredkoscObrotowa.Text = "obr/min";
            cbJednostkaWydajnosc.Text = "m^3/s";
            cbJednostkaWysokoscPodnoszenia.Text = "m";
            cbPredkoscObrotowaWybor.Text = "2900";
            cbRodzajPompy.Text = "ESOB";
            cbMEI.Text = "0,1";
            cbJednostkaWynik.Text = "%";
            cbIloscStopni.Text = "1";
            cbIloscStopni.Visible = false;
            lblIloscStopni.Visible = false;
            lblIloscStopniJednostka.Visible = false;
            Oblicz();
        }

        private void chBManualnyWyroznikSzybkobieznosci_CheckedChanged(object sender, EventArgs e)
        {
            DrawingControl.SuspendDrawing(this);
            AktualizujWszystko();
            Oblicz();
            DrawingControl.ResumeDrawing(this);
        }

        private void chbManualnaStalaC_CheckedChanged(object sender, EventArgs e)
        {
            DrawingControl.SuspendDrawing(this);
            AktualizujWszystko();
            Oblicz();
            DrawingControl.ResumeDrawing(this);
        }

        private void AktualizujWszystko()
        {
            AktualizujWysokoscPodnoszenia();
            AktualizujWyroznikSzybkobieznosci();
            AktualizujWyroznikSzybkobieznosciWynik();
            AktualizujPredkoscObrotowa();
            AktualizujRodzajPompy();
            AktualizujStalaC();
            AktualizujStalaCWynik();
            AktualizujMEI();
            AktualizujIloscStopni();
        }

        private void AktualizujWysokoscPodnoszenia()
        {
            lblWysokoscPodnoszenia.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? false : true;
            txtWysokoscPodnoszenia.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? false : true;
            cbJednostkaWysokoscPodnoszenia.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? false : true;
            pbWysokoscPodnoszenia.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? false : true;
        }

        private void AktualizujWyroznikSzybkobieznosci()
        {
            lblWyroznikSzybkobieznosci.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? true : false;
            txtWyroznikSzybkobieznosci.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? true : false;
            lblJednostkaWyroznikSzybkobieznosci.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? true : false;
            pbWyroznikSzybkobieznosci.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? true : false;
        }

        private void AktualizujWyroznikSzybkobieznosciWynik()
        {
            lblWyroznikSzybkobieznosciWynik.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? false : true;
            txtWyroznikSzybkobieznosciWynik.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? false : true;
            lblJednostkaWyroznikSzybkobieznosciWynik.Visible = chBManualnyWyroznikSzybkobieznosci.Checked ? false : true;
        }

        private void AktualizujPredkoscObrotowa()
        {
            if (chBManualnyWyroznikSzybkobieznosci.Checked && chbManualnaStalaC.Checked)
            {
                lblPredkoscObrotowa.Visible = false;
                txtPredkoscObrotowa.Visible = false;
                cbJednostkaPredkoscObrotowa.Visible = false;
                pbPredkoscObrotowa.Visible = false;
                lblPredkoscObrotowaWybor.Visible = false;
                cbPredkoscObrotowaWybor.Visible = false;
                lblJednostkaPredkoscObrotowaWybor.Visible = false;
            }
            else if (!chBManualnyWyroznikSzybkobieznosci.Checked && !chbManualnaStalaC.Checked)
            {
                lblPredkoscObrotowa.Visible = false;
                txtPredkoscObrotowa.Visible = false;
                cbJednostkaPredkoscObrotowa.Visible = false;
                pbPredkoscObrotowa.Visible = false;
                lblPredkoscObrotowaWybor.Visible = true;
                cbPredkoscObrotowaWybor.Visible = true;
                lblJednostkaPredkoscObrotowaWybor.Visible = true;
            }
            else if (chBManualnyWyroznikSzybkobieznosci.Checked && !chbManualnaStalaC.Checked)
            {
                lblPredkoscObrotowa.Visible = false;
                txtPredkoscObrotowa.Visible = false;
                cbJednostkaPredkoscObrotowa.Visible = false;
                pbPredkoscObrotowa.Visible = false;
                lblPredkoscObrotowaWybor.Visible = true;
                cbPredkoscObrotowaWybor.Visible = true;
                lblJednostkaPredkoscObrotowaWybor.Visible = true;
            }
            else
            {
                lblPredkoscObrotowa.Visible = true;
                txtPredkoscObrotowa.Visible = true;
                cbJednostkaPredkoscObrotowa.Visible = true;
                pbPredkoscObrotowa.Visible = true;
                lblPredkoscObrotowaWybor.Visible = false;
                cbPredkoscObrotowaWybor.Visible = false;
                lblJednostkaPredkoscObrotowaWybor.Visible = false;
            }
        }

        private void AktualizujRodzajPompy()
        {
            lblRodzajPompy.Visible = chbManualnaStalaC.Checked ? false : true;
            cbRodzajPompy.Visible = chbManualnaStalaC.Checked ? false : true;
            lblJednostkaRodzajPompy.Visible = chbManualnaStalaC.Checked ? false : true;
        }

        private void AktualizujStalaC()
        {
            lblStalaC.Visible = chbManualnaStalaC.Checked ? true : false;
            txtStalaC.Visible = chbManualnaStalaC.Checked ? true : false;
            lblJednostkaStalaC.Visible = chbManualnaStalaC.Checked ? true : false;
            pbStalaC.Visible = chbManualnaStalaC.Checked ? true : false;
        }

        private void AktualizujStalaCWynik()
        {
            lblStalaCWynik.Visible = chbManualnaStalaC.Checked ? false : true;
            txtStalaCWynik.Visible = chbManualnaStalaC.Checked ? false : true;
            lblJednostkaStalaCWynik.Visible = chbManualnaStalaC.Checked ? false : true;
        }

        private void AktualizujIloscStopni()
        {
            String selected = cbPredkoscObrotowaWybor.Text;
            if (cbRodzajPompy.Text == "MS-V" || cbRodzajPompy.Text == "MSS")
            {
                cbPredkoscObrotowaWybor.Items.Clear();
                cbPredkoscObrotowaWybor.Items.Add("2900");
                cbPredkoscObrotowaWybor.Text = "2900";
                if (!chBManualnyWyroznikSzybkobieznosci.Checked)
                {
                    lblIloscStopni.Visible = true;
                    cbIloscStopni.Visible = true;
                    lblIloscStopniJednostka.Visible = true;
                    iloscStopni = int.Parse(cbIloscStopni.Text);
                }
                else
                {
                    lblIloscStopni.Visible = false;
                    cbIloscStopni.Visible = false;
                    lblIloscStopniJednostka.Visible = false;
                }
            }
            else
            {
                cbPredkoscObrotowaWybor.Items.Clear();
                cbPredkoscObrotowaWybor.Items.Add("1450");
                cbPredkoscObrotowaWybor.Items.Add("2900");
                cbPredkoscObrotowaWybor.Text = selected;

                lblIloscStopni.Visible = false;
                cbIloscStopni.Visible = false;
                lblIloscStopniJednostka.Visible = false;
                iloscStopni = 1;
            }
        }

        private void AktualizujMEI()
        {
            lblMEI.Visible = chbManualnaStalaC.Checked ? false : true;
            cbMEI.Visible = chbManualnaStalaC.Checked ? false : true;
            lblJednostkaMEI.Visible = chbManualnaStalaC.Checked ? false : true;
        }

        private void Znaczek(bool spr, PictureBox znx)
        {
            znx.Image = spr ? Properties.Resources.greenV : Properties.Resources.redX;
        }

        bool poprawnoscWydajnosc = false;
        bool poprawnoscWysokoscPodnoszenia = false;
        bool poprawnoscPredkoscObrotowa = false;
        bool poprawnoscWyroznikSzybkobieznosci = false;
        bool poprawnoscStalaC = false;

        double wydajnosc;
        double wysokoscPodnoszenia;
        double predkoscObrotowa;
        double wyroznikSzybkobieznosci;
        double stalaC;
        int iloscStopni = 1;

        private void txtWydajnosc_TextChanged(object sender, EventArgs e)
        {
            poprawnoscWydajnosc = double.TryParse(txtWydajnosc.Text, out wydajnosc);
            wydajnosc = KJ.Przelicz(wydajnosc, cbJednostkaWydajnosc.Text, "m^3/s");
            Znaczek(poprawnoscWydajnosc, pbWydajnosc);
            Oblicz();
        }

        private void txtWysokoscPodnoszenia_TextChanged(object sender, EventArgs e)
        {
            poprawnoscWysokoscPodnoszenia = double.TryParse(txtWysokoscPodnoszenia.Text, out wysokoscPodnoszenia);
            wysokoscPodnoszenia = KJ.Przelicz(wysokoscPodnoszenia, cbJednostkaWysokoscPodnoszenia.Text, "m");
            Znaczek(poprawnoscWysokoscPodnoszenia, pbWysokoscPodnoszenia);
            Oblicz();
        }

        private void txtPredkoscObrotwa_TextChanged(object sender, EventArgs e)
        {
            poprawnoscPredkoscObrotowa = double.TryParse(txtPredkoscObrotowa.Text, out predkoscObrotowa);
            Znaczek(poprawnoscPredkoscObrotowa, pbPredkoscObrotowa);
            Oblicz();
        }

        private void txtWyroznikSzybkobieznosci_TextChanged(object sender, EventArgs e)
        {
            poprawnoscWyroznikSzybkobieznosci = double.TryParse(txtWyroznikSzybkobieznosci.Text, out wyroznikSzybkobieznosci);
            Znaczek(poprawnoscWyroznikSzybkobieznosci, pbWyroznikSzybkobieznosci);
            Oblicz();
        }

        private void txtStalaC_TextChanged(object sender, EventArgs e)
        {
            poprawnoscStalaC = double.TryParse(txtStalaC.Text, out stalaC);
            Znaczek(poprawnoscStalaC, pbStalaC);
            Oblicz();
        }


        private void Oblicz()
        {
            if (!chbManualnaStalaC.Checked && !chBManualnyWyroznikSzybkobieznosci.Checked && poprawnoscWydajnosc && poprawnoscWysokoscPodnoszenia)
            {
                txtWyroznikSzybkobieznosciWynik.Text = RequiredMinimumEfficiency.SpecificSpeedCalc(double.Parse(cbPredkoscObrotowaWybor.Text), wydajnosc, wysokoscPodnoszenia,iloscStopni).ToString("0.0");
                txtStalaCWynik.Text = RequiredMinimumEfficiency.ConstantC[cbRodzajPompy.Text][ cbPredkoscObrotowaWybor.Text][ cbMEI.Text].ToString("0.00");
                txtWynik.Text = KJ.Przelicz(RequiredMinimumEfficiency.MinimumEfficiency(wydajnosc, wysokoscPodnoszenia, double.Parse(cbPredkoscObrotowaWybor.Text), cbRodzajPompy.Text, cbMEI.Text,iloscStopni), "%", cbJednostkaWynik.Text).ToString("0.000");
            }
            else if (!chbManualnaStalaC.Checked && chBManualnyWyroznikSzybkobieznosci.Checked && poprawnoscWydajnosc && poprawnoscWyroznikSzybkobieznosci)
            {
                txtStalaCWynik.Text = RequiredMinimumEfficiency.ConstantC[cbRodzajPompy.Text][cbPredkoscObrotowaWybor.Text][cbMEI.Text].ToString("0.00");
                txtWynik.Text = KJ.Przelicz(RequiredMinimumEfficiency.MinimumEfficiency(cbRodzajPompy.Text, wydajnosc, wyroznikSzybkobieznosci, double.Parse(cbPredkoscObrotowaWybor.Text), cbMEI.Text), "%", cbJednostkaWynik.Text).ToString("0.000");
            }
            else if (!chbManualnaStalaC.Checked && !poprawnoscWydajnosc || !poprawnoscWysokoscPodnoszenia)
            {
                txtStalaCWynik.Text = RequiredMinimumEfficiency.ConstantC[cbRodzajPompy.Text][cbPredkoscObrotowaWybor.Text][cbMEI.Text].ToString("0.00");
                txtWyroznikSzybkobieznosciWynik.Text = "-";
                txtWynik.Text = "-";
            }
            else if (chbManualnaStalaC.Checked && chBManualnyWyroznikSzybkobieznosci.Checked && poprawnoscWydajnosc && poprawnoscStalaC && poprawnoscWyroznikSzybkobieznosci)
            {
                txtWynik.Text = KJ.Przelicz(RequiredMinimumEfficiency.MinimumEfficiency(wydajnosc, stalaC, wyroznikSzybkobieznosci), "%", cbJednostkaWynik.Text).ToString("0.000");
            }
            else if (chbManualnaStalaC.Checked && !chBManualnyWyroznikSzybkobieznosci.Checked && poprawnoscWydajnosc && poprawnoscStalaC && poprawnoscPredkoscObrotowa && poprawnoscWysokoscPodnoszenia)
            {
                txtWyroznikSzybkobieznosciWynik.Text = RequiredMinimumEfficiency.SpecificSpeedCalc(predkoscObrotowa, wydajnosc, wysokoscPodnoszenia, iloscStopni).ToString("0.0");
                txtWynik.Text = KJ.Przelicz(RequiredMinimumEfficiency.MinimumEfficiency(wydajnosc, wysokoscPodnoszenia, predkoscObrotowa, stalaC, iloscStopni), "%", cbJednostkaWynik.Text).ToString("0.000");
            }
            else
            {
                txtWyroznikSzybkobieznosciWynik.Text = "-";
                txtStalaCWynik.Text = "-";
                txtWynik.Text = "-";
            }
        }


        private void cbPredkoscObrotowaWybor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Oblicz();
        }

        private void cbMEI_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Oblicz();
        }

        private void cbRodzajPompy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AktualizujIloscStopni();
            Oblicz();
        }

        private void cbJednostkaWydajnosc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            poprawnoscWydajnosc = double.TryParse(txtWydajnosc.Text, out wydajnosc);
            wydajnosc = KJ.Przelicz(wydajnosc, cbJednostkaWydajnosc.Text, "m^3/s");
            Oblicz();
        }

        private void cbJednostkaWysokoscPodnoszenia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            poprawnoscWysokoscPodnoszenia = double.TryParse(txtWysokoscPodnoszenia.Text, out wysokoscPodnoszenia);
            wysokoscPodnoszenia = KJ.Przelicz(wysokoscPodnoszenia, cbJednostkaWysokoscPodnoszenia.Text, "m");
            Oblicz();
        }

        private void cbJednostkaPredkoscObrotowa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            poprawnoscPredkoscObrotowa = double.TryParse(txtPredkoscObrotowa.Text, out predkoscObrotowa);
            predkoscObrotowa = KJ.Przelicz(predkoscObrotowa, cbJednostkaPredkoscObrotowa.Text, "obr/min");
            Oblicz();
        }

        private void cbJednostkaWynik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Oblicz();
        }

        private void tlpParametry_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Rectangle rect = e.CellBounds;
            rect.Width-=2;
            rect.Height-=2;
            e.Graphics.DrawRectangle(new Pen(Color.Black), rect);
            /*
            if (e.Row < tlpParametry.RowCount-1 && e.Column < tlpParametry.ColumnCount-1)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            }
            else
            {
                if (e.Row == tlpParametry.RowCount-1)
                {
                    Rectangle rct = e.CellBounds;
                    rct.Height--;
                    e.Graphics.DrawRectangle(new Pen(Color.Black), rct);
                }
                if (e.Column == tlpParametry.ColumnCount-1)
                {
                    Rectangle rct = e.CellBounds;
                    rct.Width--;
                    e.Graphics.DrawRectangle(new Pen(Color.Black), rct);
                }
            }
          */
        }

        private void tlpWynik_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Rectangle rect = e.CellBounds;
            rect.Width -= 2;
            rect.Height -= 2;
            e.Graphics.DrawRectangle(new Pen(Color.Black), rect);
            /*if (e.Row < tlpWynik.RowCount - 1 && e.Column < tlpWynik.ColumnCount - 1)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds);
            }
            else
            {
                if (e.Row == tlpWynik.RowCount - 1)
                {
                    Rectangle rct = e.CellBounds;
                    rct.Height--;
                    e.Graphics.DrawRectangle(new Pen(Color.Black), rct);
                }
                if (e.Column == tlpWynik.ColumnCount - 1)
                {
                    Rectangle rct = e.CellBounds;
                    rct.Width--;
                    e.Graphics.DrawRectangle(new Pen(Color.Black), rct);
                }
            }*/
          
        }

        private void cbIloscStopni_SelectionChangeCommitted(object sender, EventArgs e)
        {
            iloscStopni = int.Parse(cbIloscStopni.Text);
            Oblicz();
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {            
            MessageBox.Show(Properties.Resources.Pomoc,"Info");
        }

    }
}
