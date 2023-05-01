using System;

class Program
{
    static void Main(string[] args)
    {
        //create job instance called job1
        Job job1 = new Job();
        job1._jobTitle = "Padawan";
        job1._company = "Jedi Order";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //create job2
        Job job2 = new Job();
        job2._jobTitle = "Jedi Master";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Obi Wan Kenobi";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}