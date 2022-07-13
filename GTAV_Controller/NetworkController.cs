namespace GTAV_Controller;

class NetworkController
{
    public void GetNetworkAdaptersNames(ref List<string> nameAdapters)
    {
        foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                || netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
            {
                nameAdapters.Add(netInterface.Name);
            }
        }
    }
    
    public bool CheckList(ref List<string> nameAdapters)
	{
        if (!nameAdapters.Any()) return false;
        else return true;
    }

    public void EnableAdapter(ref List<string> nameAdapters)
	{
        if (!CheckList(ref nameAdapters))
        {
            GetNetworkAdaptersNames(ref nameAdapters);
        }

        foreach (var items in nameAdapters)
		{
            SwitchAdapter(items, true);
		}
    }

    public void DisableAdapter(ref List<string> nameAdapters)
    {
        if (!CheckList(ref nameAdapters))
        {
            GetNetworkAdaptersNames(ref nameAdapters);
        }
        foreach (var items in nameAdapters)
        {
            SwitchAdapter(items, false);
        }
    }

    public void SwitchAdapter(string adapter, bool state)
    {
        ProcessStartInfo psi;

        if (state) psi = new ProcessStartInfo("netsh", "interface set interface \"" + adapter + "\" enable");
        else psi = new ProcessStartInfo("netsh", "interface set interface \"" + adapter + "\" disable");

        Process process = new Process();
        process.StartInfo = psi;

        process.StartInfo.UseShellExecute = false;  // New window
        process.StartInfo.CreateNoWindow = true;    // Hidden window

        process.Start();
    }
}
