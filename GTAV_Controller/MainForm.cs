namespace GTAV_Tool;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        Update();
    }

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    
    private void MainForm_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, 0x112, 0xf012, 0);
    }

    private void MainForm_Load(object sender, EventArgs e)
	{
        Update();
    }

    private void MainForm_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
    }

    private void BtnClearSession_Click(object sender, EventArgs e)
    {
        if (Update())
        {
		    if (_timerWait != null) _timerWait.Stop();
		    _tool.SuspendProcess();
            TimerWait();
        }
        Update();
    }

    private void BtnKillPrrocess_Click(object sender, EventArgs e)
    { 
        if(Update())
		{
            if (_timerWait != null) _timerWait.Stop();
            _delay = _PERMANENT_DALAY;
            _tool.KillProcess();
            NotFoundMsg();
        }
    }

    private bool Update()
	{
        if (_delay == _PERMANENT_DALAY)
		{
            _tool = null;
            _tool = new Tool(_processName);

            if (_tool.CheckProcess())
            {
                ReadyMsg();
                return true;
            }
            else if (!_tool.CheckProcess())
            {
                NotFoundMsg();
                return false;
            }
		}
        return false;
	}

    private void TimerWait()
	{
        _timerWait = new System.Windows.Forms.Timer();
        _timerWait.Tick += new EventHandler(TimerWait_Tick);
        _timerWait.Interval = 1000; // 1 second
        _timerWait.Start();
    }

    private void TimerWait_Tick(object sender, EventArgs e)
    {
        if (_delay == 0)
        {
            _delay = _PERMANENT_DALAY;
            _timerWait.Stop();
            _tool.ResumeProcess();
            Update();
            return;
        }
        LblProcessInfo.ForeColor = ColorTranslator.FromHtml(_yellow);
        LblProcessInfo.Text = $"WAIT: {_delay.ToString()}";
        --_delay;
    }

    private void ReadyMsg()
	{
        LblProcessInfo.ForeColor = ColorTranslator.FromHtml(_green);
        LblProcessInfo.Text = "READY";
    }

    private void NotFoundMsg()
	{
        LblProcessInfo.ForeColor = ColorTranslator.FromHtml(_red);
        LblProcessInfo.Text = "PRROCESS NOT FOUND";
    }
    private void LblClouse_Click(object sender, EventArgs e)
    {
        Close();
    }

	private void LblMinimize_Click(object sender, EventArgs e)
	{
        this.WindowState = FormWindowState.Minimized;
    }

    private Tool _tool;
    private string _processName = "GTA5";
    private System.Windows.Forms.Timer _timerWait;
    private int _delay = _PERMANENT_DALAY;
    private const int _PERMANENT_DALAY = 15;

    private string _green = "#36AE7C";
    private string _red = "#EB5353";
    private string _yellow = "#FFFDA2";
    private string _grey = "#476072";
}
