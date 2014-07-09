using System;
using System.Windows.Forms;

namespace rswecker.portal
{
    public partial class UI : Form
    {
        private System.Threading.SynchronizationContext _ctx;

        public UI()
        {
            InitializeComponent();
            _ctx = System.Threading.SynchronizationContext.Current;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var wa = new Weckauftrag(this.txtZeitwert.Text, rdWeckzeit.Checked);
            Start_gefordert(wa);
        }


        public void Restzeit_anzeigen(TimeSpan restzeit)
        {
           _ctx.Send(_ => {
                this.lblRestzeit.Text = restzeit.ToString();
            }, null);
        }

        public void Uhrzeit_anzeigen(DateTime uhrzeit)
        {
            _ctx.Send(_ => {
                this.lblUhrzeit.Text = uhrzeit.ToString("HH:mm:ss");
            }, null);
        }


        internal event Action<Weckauftrag> Start_gefordert;
    }
}
