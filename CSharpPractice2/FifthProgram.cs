// 5.
// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы
// и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
// Жига Никита

using System;

namespace CSharpPractice2
{
    public static class FifthProgram
    {
        public static void Run()
        {
            Console.WriteLine("Какой у вас рост? (в см)");
            var heightCm = CSharpPractice1.SixthProgram.ReadDouble();
            Console.WriteLine("Какой у вас вес? (в кг)");
            var weightKg = CSharpPractice1.SixthProgram.ReadDouble();

            var index = CalculateMassIndex(heightCm / 100, weightKg);
            Console.WriteLine($"Ваш ИМТ = {index}");
            Console.WriteLine($"Поздравляем! У вас: {GetRecommendations(index)}");

            var diff = CalculateDiffToNormalWeight(index);
            var action = diff switch
            {
                < 0 => "нужно набрать вес",
                > 0 => "нужно сбросить вес",
                _ => "не нужно что-то делать"
            };
            Console.WriteLine($"Чтобы нормализоваться, вам {action}");
        }

        static double CalculateMassIndex(double heightM, double weightKg) => weightKg / (heightM * heightM);

        static string GetRecommendations(double indexMass) => indexMass switch
        {
            < 16.0 => "Выраженный дефицит массы тела. Необходима срочная консультация специалиста",
            < 18.5 => "Недостаточная (дефицит) масса тела. Необходима консультация специалиста",
            < 25.0 => "Норма",
            < 30.0 => "Избыточная масса тела (предожирение). Необходима консультация специалиста",
            < 35.0 => "Ожирение первой степени. Необходима консультация специалиста",
            < 40.0 => "Ожирение второй степени. Необходима консультация специалиста",
            _ => "Ожирение третьей степени (морбидное). Необходима срочная консультация специалиста"
        };

        static double CalculateDiffToNormalWeight(double indexMass) => indexMass switch
        {
            < 18.5 => indexMass - 18.5,
            >= 25.0 => indexMass - 25.0,
            _ => 0
        };
    }
}