public class Greeting
{
    struct Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Author}";
        }
    }
    class Student
    {
        private static int studentCount = 0; 

        public string Name { get; set; }
        public Book FavoriteBook { get; set; }

        public Student(string name, Book favoriteBook)
        {
            Name = name;
            FavoriteBook = favoriteBook;
            studentCount++;
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Любимая книга: {FavoriteBook}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Начальное кол-во студентов: {Student.StudentCount}");


            Student student1 = new Student("Катя", new Book("Золотая рыбка", "А.С. Пушкин"));
            Console.WriteLine($"Студент создан: {student1}, всего студентов: {Student.StudentCount}");

            Student student2 = new Student("Виталя", new Book("Молот правосудия", "Герсон Бум"));
            Console.WriteLine($"Студент создан: {student2}, всего студентов: {Student.StudentCount}");

            Student student3 = new Student("Петька", new Book("1984", "Джордж Орвел"));
            Console.WriteLine($"Заспавнился студент:{student3}, Всего студентов: {Student.StudentCount}");

            Console.WriteLine("\n---Копирование---");

            Student studentCopy = student1;
            Book bookCopy = student1.FavoriteBook;
            studentCopy.Name = "Тима ";
            bookCopy.Title = "Золотая рыбка";

            Console.WriteLine($"Оригинальный студент: {student1}"); 
            Console.WriteLine($"Оригинальная книга: {student1.FavoriteBook}"); 
            Console.WriteLine($"Фейковый студент: {studentCopy}"); 
            Console.WriteLine($"Копия книги: {bookCopy}");
      
            Console.WriteLine("\n--- Объяснение ---");
            Console.WriteLine("когда мы копируем объект 'студент' (class), копируется только ссылка на объект");
            Console.WriteLine("Таким образом, изменения, внесенные в скопированный объект, также отражаются в исходном объекте");
            Console.WriteLine("Когда мы копируем объект'книга'(struct),мы создаем копию нового объекта");
            Console.WriteLine("Таким образом создание копии объекта никак не влияет на сам объект");
        }
    }
}