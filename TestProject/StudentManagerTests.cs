namespace TestProject;

public class StudentManagerTests
{
    [Fact]
    public void GetStudentCount_CanHandleNoStudents()
    {
        Dictionary<long, string> testStudentNames = new Dictionary<long, string>();

        int actualCount = StudentManager.GetStudentCount(testStudentNames);

        int expectedCount = 0;
        Assert.Equal(expectedCount, actualCount);
    }
    
    // [Fact]
    // public void GetStudentCount_CanHandleOneStudent()
    // {
    //     Dictionary<long, string> testStudentNames = new Dictionary<long, string>();
    //     testStudentNames[500] = "test student name";

    //     int actualCount = StudentManager.GetStudentCount(testStudentNames);

    //     int expectedCount = 1;
    //     Assert.Equal(expectedCount, actualCount);
    // }
    
    // [Fact]
    // public void GetAverageGPA_CanHandleOneStudent()
    // {
    //     Dictionary<long, decimal> testStudentGPAs = new Dictionary<long, decimal>();
    //     testStudentGPAs[500] = 3.05m;

    //     decimal actualAverage = StudentManager.GetAverageGPA(testStudentGPAs);

    //     decimal expectedAverage = 3.05m;
    //     Assert.Equal(expectedAverage, actualAverage);
    // }
    
    // [Fact]
    // public void GetAverageGPA_CanHandleMoreThanOneStudent()
    // {
    //     Dictionary<long, decimal> testStudentGPAs = new Dictionary<long, decimal>();
    //     testStudentGPAs[500] = 3.05m;
    //     testStudentGPAs[501] = 3.10m;

    //     decimal actualAverage = StudentManager.GetAverageGPA(testStudentGPAs);

    //     decimal expectedAverage = 3.075m;
    //     Assert.Equal(expectedAverage, actualAverage);
    // }
    
    // [Fact]
    // public void GetAverageGPA_CanHandleNoStudents()
    // {
    //     Dictionary<long, decimal> testStudentGPAs = new Dictionary<long, decimal>();

    //     decimal actualAverage = StudentManager.GetAverageGPA(testStudentGPAs);

    //     decimal expectedAverage = 0m;
    //     Assert.Equal(expectedAverage, actualAverage);
    // }
    
    // [Fact]
    // public void GetNumberOfSoftwareEngineeringMajors_CanHandleNoStudents()
    // {
    //     Dictionary<long, string> studentMajors = new Dictionary<long, string>();

    //     int actualCount = StudentManager.GetNumberOfSoftwareEngineeringMajors(studentMajors);

    //     int expectedCount = 0;
    //     Assert.Equal(expectedCount, actualCount);
    // }
    
    // [Fact]
    // public void GetNumberOfSoftwareEngineeringMajors_CanCountSoftwareStudents()
    // {
    //     Dictionary<long, string> studentMajors = new Dictionary<long, string>();
    //     studentMajors[500] = "Software Engineering";

    //     int actualCount = StudentManager.GetNumberOfSoftwareEngineeringMajors(studentMajors);

    //     int expectedCount = 1;
    //     Assert.Equal(expectedCount, actualCount);
    // }
    
    // [Fact]
    // public void GetNumberOfSoftwareEngineeringMajors_CanCountManySoftwareStudents()
    // {
    //     Dictionary<long, string> studentMajors = new Dictionary<long, string>();
    //     studentMajors[500] = "Software Engineering";
    //     studentMajors[501] = "Software Engineering";
    //     studentMajors[502] = "Software Engineering";

    //     int actualCount = StudentManager.GetNumberOfSoftwareEngineeringMajors(studentMajors);

    //     int expectedCount = 3;
    //     Assert.Equal(expectedCount, actualCount);
    // }
    
    // [Fact]
    // public void GetNumberOfSoftwareEngineeringMajors_DoesNotCountOtherMajors()
    // {
    //     Dictionary<long, string> studentMajors = new Dictionary<long, string>();
    //     studentMajors[500] = "Software Engineering";
    //     studentMajors[501] = "Physics";
    //     studentMajors[502] = "Software Engineering";

    //     int actualCount = StudentManager.GetNumberOfSoftwareEngineeringMajors(studentMajors);

    //     int expectedCount = 2;
    //     Assert.Equal(expectedCount, actualCount);
    // }

}