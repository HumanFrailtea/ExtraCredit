using System;

namespace ExtraCredit
{
	using System;

	public class WeightedGrades
	{



		public class studentRecord
		{
			private int quiz1;
			private int quiz2;
			private int quiz3;
			private int midterm;
			private int exam;

			public static void Main(string[] args)
			{

				Console.WriteLine("Enter in the first quiz score (out of 100): ");
				int quiz1 = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Enter in the second quiz score (out of 100): ");
				int quiz2 = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Enter in the third quiz score (out of 100): ");
				int quiz3 = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Enter in the Midterm score (out of 100): ");
				int midterm = Int32.Parse(Console.ReadLine());

				Console.WriteLine("Enter in the Final Exam score (out of 100): ");
				int exam = Int32.Parse(Console.ReadLine());

				studentRecord newGrade = new studentRecord(quiz1, quiz2, quiz3, midterm, exam);
				Console.WriteLine();
				Console.WriteLine(newGrade);


			}

			public override string ToString()
			{
				double numericGrade = finalWeightedGrade();
				return ("Student Record: \nQuiz 1: " + quiz1 + " \nQuiz 2: " + quiz2 + " \nQuiz 3: " + quiz3 + " \nMidterm: " + midterm + " \nFinal Exam:  " + exam + " \nClass Numeric Grade " + numericGrade + " \nLetter Grade: " + letterGrade(numericGrade));
			}


			public studentRecord(int q1, int q2, int q3, int mt, int ex)
			{
				midterm = mt;
				exam = ex;

				if (q1 > 100 || q1 < 0)
				{
					Console.WriteLine("Invalid quiz score: must be out of 100");
					Environment.Exit(0);
				}
				else
				{
					quiz1 = q1;
				}
				if (q2 > 100 || q2 < 0)
				{
					Console.WriteLine("Invalid quiz score: must be out of 100");
					Environment.Exit(0);
				}
				else
				{
					quiz2 = q2;
				}
				if (q3 > 100 || q3 < 0)
				{
					Console.WriteLine("Invalid quiz score: must be out of 100");
					Environment.Exit(0);
				}
				else
				{
					quiz3 = q3;
				}
				if (mt > 100)
				{
					Console.WriteLine("Invalid midterm score: must be out of 100");
					Environment.Exit(0);
				}
				else
				{
					midterm = mt;
				}
				if (ex > 100)
				{
					Console.WriteLine("Invalid final Exam score: must be out of 100");
					Environment.Exit(0);
				}
				else
				{
					exam = ex;
				}
			}

			public virtual double QuizGrade
			{
				get
				{
					return ((quiz1 + quiz2 + quiz3) / 3) * 0.25;
				}
			}


			public virtual double Midterm
			{
				get
				{
					return midterm * 0.35;
				}
			}

			public virtual double Exam
			{
				get
				{
					return exam * 0.4;
				}
			}

			public virtual double finalWeightedGrade()
			{

				return QuizGrade + Midterm + Exam;
			}

			public virtual string letterGrade(double numericGrade)
			{
				if (numericGrade >= 90)
				{
					return "A";
				}
				else if (numericGrade < 90 && numericGrade >= 80)
				{
					return "B";
				}
				else if (numericGrade < 80 && numericGrade >= 70)
				{
					return "C";
				}
				else if (numericGrade < 70 && numericGrade >= 60)
				{
					return "D";
				}
				else
				{
					return "F";
				}
			}
		}
	}
}
