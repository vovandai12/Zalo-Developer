namespace Zalo_Tool_V1
{
    public partial class FLogin : Form
    {
        private byte[] _data;
        public FLogin(byte[] data)
        {
            InitializeComponent();
            this._data = data;
        }

        private void BtnFLoginUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
