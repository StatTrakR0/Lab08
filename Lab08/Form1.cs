using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class PrinterInfo : Form
    {
        public PrinterInfo()
        {
            InitializeComponent();
        }

        private void btnAddPrinter_Click(object sender, EventArgs e)
        {


            //Printer printer = new Printer(printerName, pDPI, pPaperSize, pSpeedWrite, pWiFi, pTexWrite, printerLife);
            double DPI =  double.Parse("1,1");
            Printer printer = new Printer("",DPI,"",0.0, false, Printer.TextWriteState.Inkjet,0.0);
            PrinterForm pf = new PrinterForm(printer);
            if (pf.ShowDialog() == DialogResult.OK) 
            {
                tbPrinterInfo.Text += string.Format("Назва принтеру: {0}", pf.ThePrinter.printerName);
                tbPrinterInfo.Text += string.Format("Якість друку: {0}", pf.ThePrinter.pDPI);
                tbPrinterInfo.Text += string.Format("Рормір паперу: {0}", pf.ThePrinter.pPaperSize);
                tbPrinterInfo.Text += string.Format(" Швидкіть друку: {0}", pf.ThePrinter.pSpeedWrite);
                tbPrinterInfo.Text += string.Format(" Підтримка WiFi: {0}", pf.ThePrinter.pWiFi);
                tbPrinterInfo.Text += string.Format(" Тип печаті: {0}", pf.ThePrinter.pTexWrite);
                tbPrinterInfo.Text += string.Format(" Строк придатності: {0}", pf.ThePrinter.printerLife);
                




                // tbPrinterInfo.Text += string.Format("Назва принтеру: {0},\n Якість друку: {1},\n Рормір паперу: {2}.\n Швидкіть друку: { 3}.\n", pf.ThePrinter., pf.ThePrinter.pDPI, pf.ThePrinter.pSpeedWrite);
            }
        }

        private void tbPrinterInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                            if (MessageBox.Show("Припинити роботу застосунку?",
                "Припинити роботу", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                                Application.Exit();
        }
    }
}
