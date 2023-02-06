namespace DomainModel;
public class Course
{
    int id;
    int courseNumber;
    string name;

    List<Student> students;
    List<Assignment> assignments;
    List<Instructor> instructors;
    List<Messages> messages;

    public Course(int id, int courseNumber, string name) {
        this.students = new List<Student>();
        this.assignments = new List<Assignment>();
        this.instructors = new List<Instructor>();
        this.messages = new List<Message>();
        this.id = id;
        this.courseNumber = courseNumber;
        this.name = name;
    }
    public List<Assignment> getAssignments(){
        return this.assignments;
    }
    public List<Student> getStudents() {
        return this.students;
    }
    public List<Instructor> getInstructors() {
        return this.instructors;
    }
    public List<Message> getMessages() {
        return this.messages;
    }
    public int getId() {
        return this.id;
    }
    public int getCourseNumber() {
        return this.courseNumber;
    }
    public string getCourseName() {
        return this.courseName;
    }
    public void addStudent(Student student){
        this.students.Add(student)
    }
    public void addInstructor(Instructor instructor){
        this.instructors.Add(instructor)
    }
    public void addAssignment(Assignment assignment){
        this.assignments.Add(assignment)
    }
    public void sendMessage(Message message){
        this.messages.Add(message)
    }

}