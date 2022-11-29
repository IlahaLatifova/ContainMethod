
using ContainTask.Services.Interfaces;

internal class GroupService:IGroupService
    {
    Group[] Groups = new Group[0];

    public void Add(string groupNo)
    {
        Group group = new Group();
        Array.Resize(ref Groups, Groups.Length + 1);
        Groups[Groups.Length - 1] = group;
    }

    public void GetAll()
    {
        foreach(Group group in Groups)
        {
            Console.WriteLine($"Group No: {group.No}\nGroup Id: {group.Id}");
        }
    }

    public void GetById(int id)
    {
        foreach (Group group in Groups)
        {
            if(group.Id == id) 
            { 
                Console.WriteLine($"Group No: {group.No}\nGroup Id: {group.Id}"); 
                return;
            }
        }
            Console.WriteLine("There is no group with this Id.");    
    }

    public void Update(int id,string no)
    {
        foreach (Group group in Groups)
        {
            if (group.Id == id)
            {
                group.No = no;
                Console.WriteLine($"Group`s new No: {group.No}\nGroup Id: {group.Id}");
                return;
            }
        }
        Console.WriteLine("There is no group with this Id.");
    }
}

