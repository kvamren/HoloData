using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holo_Data.Structure
{
    class Mottaker
    {
        internal int id;
        internal string navn;
        internal List<Bestilling> bestillinger;

        internal TreeNode GetNode()
        {
            TreeNode node = new TreeNode(navn);
            foreach (Bestilling b in bestillinger)
            {
                node.Nodes.Add(b.GetNode());
            }
            return node;
        }

        internal TreeNode GetNodes(DateTime date, byte type)
        {
            TreeNode node = new TreeNode("");
            foreach (Bestilling b in bestillinger)
            {
                if (type == 0)
                {
                    if (b.sendt.Date == date)
                    {
                        node.Nodes.Add(b.GetNode());
                    }
                }
                else if (type == 1)
                {
                    if (b.sendt.Month == date.Month && b.sendt.Year == date.Year)
                    {
                        node.Nodes.Add(b.GetNode());
                    }
                }
                else if (type == 2)
                {
                    if (b.sendt.Year == date.Year)
                    {
                        node.Nodes.Add(b.GetNode());
                    }
                }
            }

            node.Text = navn + " @ " + date.ToString() + "(" + node.Nodes.Count + ")";

            return node;
        }

        internal void Save(System.IO.BinaryWriter bw)
        {
            bw.Write(navn);
            bw.Write(bestillinger.Count);
            foreach (Bestilling b in bestillinger)
            {
                b.Save(bw);
            }
        }

        internal static Mottaker Load(System.IO.BinaryReader br)
        {
            Mottaker m = new Mottaker();
            m.navn = br.ReadString();
            m.bestillinger = new List<Bestilling>();
            int blen = br.ReadInt32();
            for (int i = 0; i < blen; i++)
            {
                m.bestillinger.Add(Bestilling.Load(br));
            }
            return m;
        }

        internal void Remove(string p)
        {
            for (int i = 0; i < bestillinger.Count; i++)
            {
                if (bestillinger[i].GetNode().Text == p)
                {
                    bestillinger.RemoveAt(i);
                }
            }
        }
    }
}
