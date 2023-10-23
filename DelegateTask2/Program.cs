namespace DelegateTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();

            Exam exam = new Exam { Subject = "Fizika", ExamDuration = 120, StartDate = new DateTime(2023, month: 6, day: 4, hour: 14, minute: 0, second: 0) };
            Exam exam1 = new Exam { Subject = "Kimya", ExamDuration = 90, StartDate = new DateTime(2023, month: 6, day: 8, hour: 13, minute: 0, second: 0) };
            Exam exam2 = new Exam { Subject = "Riyaziyyat", ExamDuration = 150, StartDate = new DateTime(2023, month: 6, day: 12, hour: 10, minute: 0, second: 0) };

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
                    {
                        isExist = true;
                        Console.WriteLine(exam);
                    }
                });

                if (!isExist) Console.WriteLine("Axrinci hefte imtahanlar yoxdur");
            }
            else Console.WriteLine("Imtahanlar hele elave olunmuyub");

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

                if (!isExist) Console.WriteLine("2 saatdan chox imtahanlar yoxdur");
            }
            else Console.WriteLine("Imtahanlar hele elave olunmuyub");

            //3 Shert'di (bashlayib amma bitmemish(hal-hazirda devam eden) imtahanlarin siyahisi)

            isExist = false;
            if (exams.Count > 0)
            {
                Console.WriteLine("Hal hazirda olan imtahanlar");
                exams.ForEach(exam =>
                {

                    if (exam.EndDate >= DateTime.Now && exam.StartDate <= DateTime.Now)
                    {
                        isExist = true;
                        Console.WriteLine(exam);
                    }
                });

                if (!isExist) Console.WriteLine("Hal hazirda imtahan yoxdur");
            }
            else Console.WriteLine("Imtahanlar elave olunmuyub");



        }
    }
}