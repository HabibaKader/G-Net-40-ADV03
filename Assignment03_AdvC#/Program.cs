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

            #region Exercise 3: Phone Book
            //// 1. Create phone book
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    {"Ahmed", "0100"},
            //    {"Sara", "0111"},
            //    {"Ali", "0122"},
            //    {"Mona", "0133"}
            //};

            //// 2. Add/update using []
            //phoneBook["Ahmed"] = "9999";
            //phoneBook["Omar"] = "0144";

            //// 3. Add duplicate using Add()
            //try
            //{
            //    phoneBook.Add("Ahmed", "0000");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //// 4. TryAdd
            //bool added = phoneBook.TryAdd("Ahmed", "0000");
            //Console.WriteLine("TryAdd success? " + added);

            //// 5. Search for non-existing contact
            //Console.WriteLine("Contains 'Yara'? " + phoneBook.ContainsKey("Yara"));

            //// 6. Get with fallback
            //string result = phoneBook.TryGetValue("Yara", out string value)
            //    ? value
            //    : "Not Found";

            //Console.WriteLine("Yara: " + result);

            //// 7. Print keys and values
            //Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
            //Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
            #endregion

            #region Exercise 4: Unique Email Validator
            // 1. Case-insensitive HashSet
            var emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            // 2. Add emails
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            // 3. Print Count
            Console.WriteLine("Count: " + emails.Count);

            // Print actual values
            Console.WriteLine("Stored Emails:");
            foreach (var e in emails)
                Console.WriteLine(e);
            /*
             Explanation:
             Count = 2
             Because HashSet ignores case,
             so duplicates like "ahmed@test.com" and "AHMED@test.com" are considered same
            */

            // 4. Create sets
            var setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            var setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            // 5. Operations
            var union = new HashSet<int>(setA);
            union.UnionWith(setB);
            Console.WriteLine("Union: " + string.Join(", ", union));

            var intersect = new HashSet<int>(setA);
            intersect.IntersectWith(setB);
            Console.WriteLine("Intersect: " + string.Join(", ", intersect));

            var except = new HashSet<int>(setA);
            except.ExceptWith(setB);
            Console.WriteLine("Except (A - B): " + string.Join(", ", except));

            // 6. Subset check
            var subset = new HashSet<int> { 1, 2 };
            Console.WriteLine("Is subset? " + subset.IsSubsetOf(setA));
            #endregion

            #region Exercise 5: Print Queue Simulator
            Queue<string> queue = new Queue<string>();

            // Add documents
            queue.Enqueue("Report.pdf");
            queue.Enqueue("Invoice.pdf");
            queue.Enqueue("Letter.docx");
            queue.Enqueue("Resume.pdf");
            queue.Enqueue("Photo.jpg");

            // 1. Print queue + count
            Console.WriteLine("Queue: " + string.Join(", ", queue));
            Console.WriteLine("Count: " + queue.Count);

            // 2. Peek
            Console.WriteLine("Next document: " + queue.Peek());

            // 3. Process queue
            while (queue.Count > 0)
            {
                string doc = queue.Dequeue();
                Console.WriteLine("Printing: " + doc);
            }

            // 4. TryDequeue on empty queue
            bool success = queue.TryDequeue(out string result);
            Console.WriteLine("TryDequeue success? " + success);
            Console.WriteLine("Result: " + (result ?? "null"));

            /*
             Explanation:
             - TryDequeue returns false
             - result = null (default for string)
             - No exception thrown (safe)
            */
            #endregion
        }
    }
}
