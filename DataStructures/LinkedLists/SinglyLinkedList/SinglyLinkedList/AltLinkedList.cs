using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedList
{
    public class AltLinkedList<Whatevs>
    {       

        private Nody<Whatevs> baseNode;
        private Nody<Whatevs> currentNode;
        public int Records;

        //Assuming the node list goes from left to right 1->2->3->null
        public AltLinkedList()
        {
            baseNode = new Nody<Whatevs>();
            currentNode = baseNode;
        }

        //appends the element to the end of the list
        public void Attach(Nody<Whatevs> freshNode)
        {
            Nody<Whatevs> temp = new Nody<Whatevs> { Val = freshNode.Val};
            currentNode.Next = temp;

            //refresh the parent node after pointing to the new one
            currentNode = temp;
            Records++;
        }

        public void AttachAfter(Nody<Whatevs> target, Nody<Whatevs> cellToAdd)
        {
           
            if (cellToAdd.Val.Equals(baseNode.Next.Val))
                baseNode.Next = cellToAdd;
            else
            {
                Nody<Whatevs> previous = baseNode;
                Nody<Whatevs> current = baseNode.Next;

                while (current != null)
                {
                    if (current.Val.Equals(target.Val))
                    {
                        cellToAdd.Next = current;
                        Records++;
                        break;
                    }

                    previous = current;
                    current = current.Next;
                }
                //Now celltoadd contains all pointers that should be after that plus it's appended to previous node
                previous.Next = cellToAdd;
            }

        }

        public void AttachFirst(Nody<Whatevs> freshNode)
        {
            freshNode.Next = baseNode.Next;
            baseNode.Next = freshNode;
            Records++;
        }

        public void Delete(Nody<Whatevs> trashNode)
        {
            //Handle edge cases
            if(Records == 0)
            {
                Console.WriteLine("There are no records to delete");
                return;
            }
            if(trashNode == baseNode)
            {
                baseNode = baseNode.Next;
            }
            else
            {
                Nody<Whatevs> previous = baseNode;
                Nody<Whatevs> current = baseNode.Next;

                while (current != null)
                {
                    if (current.Val.Equals(trashNode.Val))
                    {                        
                        previous.Next = current.Next;
                        Records--;
                        break;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
                        
        }

        public Stack<Whatevs> GetValues()
        {
            Stack<Whatevs> Values = new Stack<Whatevs>();

            Nody<Whatevs> first = new Nody<Whatevs>();
            first.Next = baseNode.Next;
            while (first.Next != null)
            {
                first = first.Next;
                Values.Push(first.Val);
            }

            return Values;
        }

    }
    public class Nody<Whatevs>
    {
        public Nody<Whatevs> Next { get; set; }
        public Whatevs Val { get; set; }
    }
}
