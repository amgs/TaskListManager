public class Task {
    private string id;
    private string description;
    private bool status;

    public Task(int id, string description) {
        this.id = $"{id}";
        this.description = description;
        this.status = false;
    }

    public string GetId() {
        return id;
    }

    public string GetDescription() {
        return description;
    }

    public void MarkCompleted() {
        status = true;
    }

    public bool GetStatus() {
        return status;
    }
}