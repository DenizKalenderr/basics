namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() {
                    Id=1, 
                    Title = "aspnet kursu", Description = "İyidir", 
                    Image="1.jpg",
                    Tags = new string[] {"aspnet", "web geliştirme"},
                    isActive = true,
                    isHome = true,
                    },
                new Course() {
                    Id=2, 
                    Title = "c# kursu", 
                    Description = "İyidir", 
                    Image="2.jpg",
                    Tags = new string[] {"c#", "web geliştirme"},
                    isActive = true,
                    isHome = true,
                    
                    },
                new Course() {
                    Id=3, 
                    Title = "python kursu", Description = "İyidir", 
                    Image="2.jpg",
                    isActive = true,
                    //aktif olacak ama anasayfada olmayacak.
                    isHome = false,
                    },
                new Course() {
                    Id=4, 
                    Title = "java kursu", Description = "İyidir", 
                    Image="2.jpg",
                    isActive = true,
                    isHome = true,
                    }
            };
        }
        public static List<Course> Courses
        {
            get{
                return _courses;
            }
        }
        //static tanımladık çünkü diğer sınıfta çağırırken direkt sınıf ismiyle çağırıyoruz. Repository.GetById/Courses gibi
        public static Course? GetById(int? id)
        {
            //// istenilen id kurslarda belirttiğim Id değeriyse _courses listesinden istenilen değeri getir.
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}
