using System;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace TestWebParser
{
    public partial class Parser : Form
    {
        Result res;
        private enum Status
        {
            Standby = 0,
            Downloading_Page = 1,
            Page_Ready = 2,
            Parsing_Tags = 3,
            Tags_Ready = 4
        }
        private Status currentStatus { get; set; }

        private String[] parseType = { "Tag Name", "Tag Id", "Tag Class" };

        private System.Timers.Timer timer;

        private HtmlAgilityPack.HtmlDocument currentPage;
        public Parser()
        {
            InitializeComponent();
            currentStatus = Status.Standby;
            goButton.Enabled = false;
            parseSelectionComboBox.Enabled = false;
            argumentTextBox.Visible = false;
            argumentTextBox.Enabled = false;
            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += (o,e) => checkStatusLoop();
            timer.Start();
            this.parseSelectionComboBox.DataSource = parseType;
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void checkStatusLoop()
        {
            switch (currentStatus)
            {
                case Status.Standby:
                    Invoke((MethodInvoker)delegate
                    {
                        statusLabel.Text = "Standby";
                    });
                    break;
                case Status.Downloading_Page:
                    Invoke((MethodInvoker)delegate
                    {
                        statusLabel.Text = "Downloading Page";
                    });
                    break;
                case Status.Page_Ready:
                    Invoke((MethodInvoker)delegate
                    {
                        statusLabel.Text = "Page Ready";
                        goButton.Enabled = true;
                        argumentTextBox.Visible = true;
                        argumentTextBox.Enabled = true;
                    });
                    break;
                case Status.Parsing_Tags:
                    Invoke((MethodInvoker)delegate
                    {
                        statusLabel.Text = "Parsing Tags";
                    });
                    break;
                case Status.Tags_Ready:
                    Invoke((MethodInvoker)delegate
                    {
                        statusLabel.Text = "Tags Ready";
                    });
                    break;
                default:
                    break;
            }
        }

        private void setStatus(Status currentStatus)
        {
            this.currentStatus = currentStatus;
        }

        private void getPageButton_Click(object sender, EventArgs e)
        {
            setStatus(Status.Downloading_Page);
            checkStatusLoop();
            HtmlWeb web = new HtmlWeb();
            currentPage = web.Load(this.linkTextBox.Text);
            setStatus(Status.Page_Ready);
            parseSelectionComboBox.Enabled = true;
        }

        private void showResult()
        {
            res = new TestWebParser.Result();
            res.StartPosition = FormStartPosition.Manual;
            res.SetDesktopLocation(this.DesktopBounds.Right, this.DesktopBounds.Top);
            res.SizeChanged += Res_SizeChanged;
            res.Show(this);
        }

        private void Res_SizeChanged(object sender, EventArgs e)
        {
            res.listView1.Size = res.Size;
            res.Update();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            setStatus(Status.Parsing_Tags);
            showResult();
            if((String)parseSelectionComboBox.SelectedItem == parseType[0])
            {
                HtmlNodeCollection nodes = currentPage.DocumentNode.SelectNodes("//" + argumentTextBox.Text);
                MessageBox.Show(nodes.Count.ToString());
                foreach(HtmlNode x in nodes)
                {
                    String xString = x.InnerText.ToString().Trim();
                    if (xString != "")
                        res.listView1.Items.Add(xString);
                }
                setStatus(Status.Tags_Ready);
                return;
            }
            if ((String)parseSelectionComboBox.SelectedItem == parseType[1])
            {

                setStatus(Status.Tags_Ready);
                return;
            }
            if ((String)parseSelectionComboBox.SelectedItem == parseType[2])
            {

                setStatus(Status.Tags_Ready);
                return;
            }
        }
    }
}
