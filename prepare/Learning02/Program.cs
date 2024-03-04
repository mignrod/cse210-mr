using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Cellphone Technician";
        job1._company = "JL Solutions";
        job1._startYear = 2017;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "DS Telecomunications";
        job2._startYear = 2010;
        job2._endYear = 2017;

        Resume resume = new Resume();
        resume._personName = "Miguelangel Rodriguez";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();

    }
}