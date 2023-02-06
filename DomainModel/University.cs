namespace DomainModel
{
    public class University
    {
        int id;
        List<Course> courseList;
        string name;
        string location;

        public University(string name, int id, string location) {
            this.CourseList = new List<Course>();
            this.id = id;
            this.name = name;
            this.location = location;
        }

        public int getId() {
            return this.id;
        }
        public string getName() {
            return this.name;
        }
        public string getLocation() {
            return this.location;
        }
        public void addCourse(Course course){
            this.courseList.Add()
        }

    }
}