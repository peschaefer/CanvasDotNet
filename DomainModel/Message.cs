namespace DomainModel;
public class Message
{
    int id;
    string content;
    string timeSent;

    public Message(int id, string content, string timeSent) {
        this.id = id;
        this.content = content;
        this.timeSent = timeSent
    }
    public int getID(){
        return this.id;
    }
    public string getContent() {
        return this.content;
    }
    public string getTimeSent() {
        return this.timeSent;
    }
}