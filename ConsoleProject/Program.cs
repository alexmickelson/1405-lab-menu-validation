using ConsoleProject;

Dictionary<long, string> StudentNames = new();
Dictionary<long, string> StudentMajors = new();
Dictionary<long, decimal> StudentGPAs = new();

while (true)
{
  // store data in the main function so that it is persisted between runs
  UserInterface.MainMenu(StudentNames, StudentMajors, StudentGPAs);
}


