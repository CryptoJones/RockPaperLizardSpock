// See https://aka.ms/new-console-template for more information
foreach (string str in args)
{
    if (str.Count() < 1)
    {
        string ErrorProgramNeedsVariables = "Error: name of pcap file must be supplied!";
        Console.WriteLine(ErrorProgramNeedsVariables);
    }

    if (str.Count() > 1)
    {
        string ErrorProgramNeedsOnlyOneVariable = "Error: name of pcap file must be supplied!";
        Console.WriteLine(ErrorProgramNeedsOnlyOneVariable);
    }
}
string InfoProgramCompleted = "Program has completed sucessfully. Or unsuccessfully. What do I know? I'm a computer program!";
Console.WriteLine(InfoProgramCompleted);

string returnPFIX(string filename) {

    string results = null;
    return results;
}

string returnCSV(string filename)
{

    string results = null;
    return results;
}