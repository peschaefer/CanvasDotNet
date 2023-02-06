namespace DomainModel;
public class Student
{
    int id;
    string name;
    string email;

    public Student(string name, string email, int id) {
        this.id = id
        this.name = name
        this.email = email
    }
    public int getID(){
        return this.id;
    }
    public string getEmail() {
        return this.email;
    }
    public string getName() {
        return this.name;
    }
}