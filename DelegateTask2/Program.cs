namespace DelegateTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<Exam> exams = new List<Exam>();

            Exam exam = new Exam ( "Fizika", 2, new DateTime(2023, month: 6, day: 1, hour: 14, minute: 0, second: 0));
            Exam exam1 = new Exam ("Kimya", 1.5 , new DateTime(2023, month: 6, day: 3, hour: 13, minute: 0, second: 0) );
            Exam exam2 = new Exam ("Riyaziyyat", 2.5 , new DateTime(2023, month: 5, day: 12, hour: 10, minute: 0, second: 0));

            exams.Add(exam);
            exams.Add(exam1);
            exams.Add(exam2);

                //1ci shert (- son 1 hefte erzinde olan  examlarin siyahisini gosterirsini)


            bool isExist = false;
            if (exams.Count > 0)
            {
                Console.WriteLine("Axrinci heftenin imtahanlari");
                exams.ForEach(exam =>
                {
                    if (exam.EndDate.AddDays(7) >= DateTime.Now && exam.EndDate <= DateTime.Now)
                    isExist = true;
                    Console.WriteLine(exam);
                });
            }
            else Console.WriteLine("Axrinci hefte imtahanlar yoxdur");

            //2 ci shert (2 saatdan uzun ceken imtahanlarin siyahisi)

            isExist = false;
            if (exams.Count > 0)
            {
                Console.WriteLine("2 saatdan chox olan imtahanlar");
                exams.ForEach(exam =>
                {

                    if (exam.ExamDuration >= 2)
                    {
                        isExist = true;
                        Console.WriteLine(exam);
                    }
                });
            }
            else Console.WriteLine("2 saatdan chox imtahanlar yoxdur");

            //3 Shert'di (bashlayib amma bitmemish(hal-hazirda devam eden) imtahanlarin siyahisi)

            isExist = false;
            if (exams.Count > 0)
            {
                Console.WriteLine("Hal hazirda olan imtahanlar");
                exams.ForEach(exam =>
                {

                    if (exam.EndDate >= DateTime.Now && exam.StartDate <= DateTime.Now)
                    isExist = true;
                    Console.WriteLine(exam);
                });

                
            }
            else Console.WriteLine("Hal hazirda imtahnlar yoxdur");



        }

        }
    }
}
