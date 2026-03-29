namespace Assignment03_AdvC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //// 1. Create collection
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //// 2. Print collection, count, first, last
            //Console.WriteLine("Grades: " + string.Join(", ", grades));
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First: " + grades.First());
            //Console.WriteLine("Last: " + grades.Last());

            //// 3. Sort ascending
            //grades.Sort();
            //Console.WriteLine("Sorted: " + string.Join(", ", grades));

            //// 4. First grade above 90
            //var above90 = grades.FirstOrDefault(g => g > 90);
            //Console.WriteLine("First > 90: " + above90);

            //// 5. All grades below 75
            //var failing = grades.Where(g => g < 75).ToList();
            //Console.WriteLine("Failing: " + string.Join(", ", failing));

            //// 6. Remove all failing grades
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("After removing failing: " + string.Join(", ", grades));

            //// 7. Check if any grade equals 100
            //bool has100 = grades.Any(g => g == 100);
            //Console.WriteLine("Has 100? " + has100);

            //// 8. Convert to List<string>
            //List<string> gradeStrings = grades
            //    .Select(g => $"Grade: {g}")
            //    .ToList();

            //Console.WriteLine("String list: " + string.Join(" | ", gradeStrings));
            #endregion

            #region Exercise 2: Leaderboard
            //// 1. Add players
            //SortedList<int, string> leaderboard = new SortedList<int, string>()
            //{
            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "Ali"},
            //    {350, "Mona"}
            //};

            //// 2. Print sorted entries
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            //}

            //// 3. First key & value
            //Console.WriteLine("First Key: " + leaderboard.Keys[0]);
            //Console.WriteLine("First Value: " + leaderboard.Values[0]);

            //// 4. Check if score 500 exists
            //Console.WriteLine("Contains 500? " + leaderboard.ContainsKey(500));

            //// 5. Safely get player with score 999
            //if (leaderboard.TryGetValue(999, out string player))
            //    Console.WriteLine(player);
            //else
            //    Console.WriteLine("Score 999 not found");

            //// 6. Remove score 200
            //leaderboard.Remove(200);

            //Console.WriteLine("After removal:");
            //foreach (var entry in leaderboard)
            //{
            //    Console.WriteLine($"{entry.Key} : {entry.Value}");
            //}
            #endregion
        }
    }
}
