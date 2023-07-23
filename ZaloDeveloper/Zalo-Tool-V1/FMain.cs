using OpenQA.Selenium;

namespace Zalo_Tool_V1
{
    public partial class FMain : Form
    {
        private byte[] _QRCode;
        private IWebDriver _driver;
        private List<IWebDriver> _drivers;

        public FMain()
        {
            InitializeComponent();
            this._QRCode = null;
            this._driver = null;
            this._drivers = new();
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            FAccount form = new FAccount();
            form.ShowDialog();
        }
        //FLogin form = new FLogin(this._QRCode);
        //form.ShowDialog();



    }
}
