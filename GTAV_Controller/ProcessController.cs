namespace GTAV_Controller;

class ProcessController
{
	public ProcessController(in string name)
	{
		_name = name;
		_pid = ProcessAccess.GetPidWithName(_name);
		_state = CheckProcess();
	}
	public bool CheckProcess()
	{
		if (_pid == 0 || _name == String.Empty) return false;
		return true;
	}
	public bool SuspendProcess()
	{
		if (!_state) return false;
		ProcessAccess.SuspendProcess(_pid);
		return true;
	}
	public bool ResumeProcess()
	{
		if (!_state) return false;
		ProcessAccess.ResumeProcess(_pid);
		return true;
	}
	public void KillProcess()
	{
		Process killProcess = Process.GetProcessById(_pid);
		killProcess.Kill();
	}

	private string _name;
	private int _pid;
	private bool _state;
}
