using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Owner";
        job1._startYear = "1905";
        job1._endYear = "Present";

        Job job2 = new Job();
        job2._company = "Ford";
        job2._jobTitle = "Owner";
        job2._startYear = "1593";
        job2._endYear = "Present";

        Resume myResume = new Resume();
        myResume._name = "Nathan Jackson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}