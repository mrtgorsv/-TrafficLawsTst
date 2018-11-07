using System;
using System.Windows.Forms;

namespace TrafficLawsTest
{
    public partial class ResultForm : Form
    {

        public ResultForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CloseButton.Click += OnCloseButtonClicked;
        }

        private void OnCloseButtonClicked(object sender, EventArgs e)
        {
            OnExit();
        }

        protected virtual void OnExit()
        {
            Close();
        }

        public void SetResult(string[] result)
        {
            ResultListBox.DataSource = result;
        }
    }
}
