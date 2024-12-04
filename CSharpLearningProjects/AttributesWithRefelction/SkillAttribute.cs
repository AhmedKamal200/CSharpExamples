namespace ConsoleApp1
{
    public class SkillAttribute : Attribute
        {
            
            public string Name { get; private set; }
            public int Maximum {  get; private set; }
            public int Minimum { get; private set; }
            public SkillAttribute(string name, int maximum, int minimum)
            {
                Name = name;
                this.Maximum = maximum;
                this.Minimum = minimum;
            }
            public bool Isvalid(object obj) 
            {
                var value = (int)obj;
                return value >= Minimum && value <=Maximum;

            }

    }
    
}
