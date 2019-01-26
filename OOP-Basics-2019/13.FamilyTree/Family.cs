using System.Collections.Generic;
using System.Text;

namespace _13.FamilyTree
{
    public class Family
    {
        private List<Person> parents;
        private List<Person> children;

        public Family(Person mainPerson)
        {
            this.MainPerson = mainPerson;
            this.parents = new List<Person>();
            this.children = new List<Person>();
        }

        public Person MainPerson { get; private set; }

        public void AddParent(Person parent)
        {
            this.parents.Add(parent);
        }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(MainPerson.ToString());
            sb.AppendLine("Parents:");
            this.parents.ForEach(p => sb.AppendLine(p.ToString()));
            sb.AppendLine("Children:");
            this.children.ForEach(p => sb.AppendLine(p.ToString()));

            return sb.ToString().TrimEnd();

        }
    }
}
