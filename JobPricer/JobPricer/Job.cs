using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPricer
{
    class Job
    {
        private string jobDescription;
        private double jobTime;
        private double jobRate;
        private double totalFee;

        public string JobDescription
        {
            get
            {
                return jobDescription;
            }

            set
            {
                jobDescription = value;
            }
        }

        public double JobTime
        {
            get
            {
                return jobTime;
            }

            set
            {
                jobTime = value;
                calculateFee();
            }
        }

        public double JobRate
        {
            get
            {
                return jobRate;
            }

            set
            {
                jobRate = value;
                calculateFee();
            }
        }

        public double TotalFee
        {
            get
            {
                return totalFee;
            }
        }


        public void PriceJob()
        {
            Console.WriteLine("Welcome to Job Pricer. \nPlease enter the total number of Jobs:");
            int numOfJobs = int.Parse(Console.ReadLine());
            Job[] jobArray = new Job[numOfJobs];

            for (int i = 0; i < jobArray.Length; i++)
            {
                jobArray[i] = new Job();
                Console.WriteLine("Please enter a Description for Job {0}", i + 1);
                jobArray[i].JobDescription = Console.ReadLine();

                Console.WriteLine("Please enter in the total number of Hours needed to complete Job {0}", i + 1);
                jobArray[i].JobTime = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter in the Hourly Rate for Job {0}", i + 1);
                jobArray[i].JobRate = double.Parse(Console.ReadLine());


            }

            for (int i = 0; i < jobArray.Length; i++)
            {
                calculateFee();
                Console.WriteLine("Job {0}: {1}. The Time needed is {2} hours. The Hourly rate is ${3}. The total fee for the job is ${4}",
                    i + 1, jobArray[i].JobDescription, jobArray[i].JobTime, jobArray[i].JobRate, jobArray[i].TotalFee);

            }

            if (numOfJobs == 2)
            {
                
                Job newJob = jobArray[0] + jobArray[1];
                Console.WriteLine("The combination of both {0} is {1} hours at a rate of ${2} for a total of ${3}"
                    , newJob.JobDescription, newJob.JobTime, newJob.JobRate, newJob.TotalFee);

            }
           
        }

        private void calculateFee()
        {
            totalFee = jobTime * jobRate;
        }

        public static Job operator +(Job job1, Job job2)
        {
            string newjobDescription = job1.JobDescription + " and " + job2.JobDescription;
            double newjobTime = job1.JobTime + job2.JobTime;
            double newjobRate = (job1.JobRate + job2.JobRate) / 2;

            Job newJob = new Job();
            return newJob;
        }

    }
}
