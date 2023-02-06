namespace DomainModel;
public class Assignment
{
    int id;
    string title;
    string type;
    string description;
    int totalPoints;
    string dueDate;

    public Assignment(int id, string title, string description, int totalPoints, string dueDate) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.totalPoints = totalPoints;
        this.dueDate = dueDate;
    }
    public int getID(){
        return this.id;
    }
    public string getTitle() {
        return this.title;
    }
    public string getDescription() {
        return this.description;
    }
    public string getTotalPoints() {
        return this.totalPoints;
    }
    public string getDueDate() {
        return this.dueDate;
    }
}