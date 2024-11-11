namespace MVCProject.Models.Task1
{
    public class Accessing_Data
    {
        public Datamodel1 ImageData()
        {
            Datamodel1 Obj1 = new Datamodel1()
            {
                Image_Name = "Mountain View",
                Source = "Google",
                Size = 2.6,
            };
            return Obj1;
        }
    }
}
