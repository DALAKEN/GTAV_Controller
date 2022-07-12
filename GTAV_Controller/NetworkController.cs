namespace GTAV_Controller;

class NetworkController
{
    public void GetNetworkAdaptersNames(ref List<string> adaptersName)
    {
        foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                || netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
            {
                adaptersName.Add(netInterface.Name);
            }
        }
    }
    
    public bool CheckList(ref List<string> adaptersName)
	{
        if (!adaptersName.Any()) return false;
        else return true;
    }

    public void EnableAdapter(ref List<string> adaptersName)
	{
        if (!CheckList(ref adaptersName)) GetNetworkAdaptersNames(ref adaptersName);

        foreach (var items in adaptersName) SwitchAdapter(items, true);
    }

    public void DisableAdapter(ref List<string> adaptersName)
    {
        if (!CheckList(ref adaptersName)) GetNetworkAdaptersNames(ref adaptersName);

        foreach (var items in adaptersName) SwitchAdapter(items, false);
    }

    public void SwitchAdapter(string interfaceName, bool state)
    {
        ProcessStartInfo psi;

        if (state) psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" enable");
        else psi = new ProcessStartInfo("netsh", "interface set interface \"" + interfaceName + "\" disable");

        Process p = new Process();
        p.StartInfo = psi;
        p.Start();
    }
}
