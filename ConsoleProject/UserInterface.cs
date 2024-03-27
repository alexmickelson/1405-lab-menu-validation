namespace ConsoleProject;

public static class UserInterface
{
  public static void MainMenu(
    Dictionary<long, string> StudentNames,
    Dictionary<long, string> StudentMajors,
    Dictionary<long, decimal> StudentGPAs
  )
  {
    int input = GetValidInt("Student Application Choices:\n1) Register NEW student\n2) Print Report", minVal: 1, maxVal: 2);
    switch (input)
    {
      case 1:
        string stuName = GetValidString("Enter Student name:", minLength: 1, maxLength: 50);
        string stuMajor = GetValidString("Enter Student major:", minLength: 1, maxLength: 50);
        decimal stuGPA = GetValidDecimal("Enter student GPA (X.XX)", minVal: 0.0m, maxVal: 4.0m);
        long StudentID = DateTime.UnixEpoch.Ticks; //Unique StudentID
        // below is an example of storing the student name
        StudentNames[StudentID] = stuName;
        // TODO1: Add steps to store the major and GPA
        break;

      case 2:
        // logic functions return default values right now, you will implement them properly in part 2
        int count = StudentManager.GetStudentCount(StudentNames);
        decimal averageGPA = StudentManager.GetAverageGPA(StudentGPAs);
        int softwareEngineerCount = StudentManager.GetNumberOfSoftwareEngineeringMajors(StudentMajors);

        // TODO2: Fix output to display all data
        //       also make output easier for user to understand
        Console.WriteLine($"Student report:\n{count}");
        break;

      default:
        throw new ArgumentException("Whoa!  This broke!!!");
    }
  }

  public static decimal GetValidDecimal(string prompt, decimal minVal, decimal maxVal)
  {
    Console.WriteLine(prompt);
    string input = Console.ReadLine();
    bool success = decimal.TryParse(input, out decimal selected);
    if (success && selected >= minVal && selected <= maxVal)
      return selected;
    else
      return GetValidDecimal(prompt, minVal, maxVal);
  }

  public static string GetValidString(string prompt, int minLength, int maxLength)
  {
    // TODO3: 1. display prompt to user
    //       2. get string from user
    //       3. check that string meets min and max length requirements
    //       4. if length requirements are met, return the string, otherwise perform recursive call: return GetValidString(...);
    return "";
  }

  public static int GetValidInt(string prompt, int minVal, int maxVal)
  {
    // TODO4: 1. display prompt to user
    //       2. get string from user
    //       3. use int.TryParse to turn user input into an int
    //       4. if parsing is successful return the number, otherwise perform recursive call: return GetValidInt(...); 
    return -1;
  }
}